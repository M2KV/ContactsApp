using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ContactsApp
{
    internal class TCPServer
    {
        public TCPServer(string ip, string  port, int bytes)
        {
            _IP         = IPAddress.Parse(ip);
            _Port       = int.Parse(port);
            _Bytes      = bytes;
            _Buffers    = new byte[bytes];
            connected   = false;
            _Clients    = new List<Socket>();
            _ResData    = new List<Contacts>();
        }

        private static void InvokeConsole(RichTextBox console, string text, bool append = false)
        {
            if (!console.IsDisposed)
            {
                _ = console.Invoke(new MethodInvoker(delegate {
                    if (!append) console.Text = text;
                    else console.Text += text;
                }));
            }
        }

        private static void InvokeConsole(RichTextBox console, string text, string newText)
        {
            if (!console.IsDisposed)
            {
                _ = console.Invoke(new MethodInvoker(delegate {
                    console.Text = console.Text.Replace(text, newText);
                }));
            }
        }

        private void LoadDatabase()
        {
            string json = File.ReadAllText("Database/contacts.json");
            JToken token = JsonConvert.DeserializeObject<JToken>(json);
            _Data = JsonConvert.DeserializeObject<List<ContactsDB>>(token.First.First.ToString());
        }

        public void Run()
        {
            try
            {
                _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _Socket.Bind(new IPEndPoint(_IP, _Port));

                _Socket.Listen(0);
                
                _ = _Socket.BeginAccept(AcceptCallback, null);
                
                connected = true;
                InvokeConsole(_ConsoleLogger, "\n   Server running successfully !\n", true);
                InvokeConsole(_ConsoleStatus, "\n", false);
                LoadDatabase();
            }
            catch (SocketException ex)
            {
                _ = MessageBox.Show(ex.Message, "Socket create error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = _Socket.EndAccept(ar);
                _Clients.Add(socket);

                string Msg = "   Client IP: " + ((IPEndPoint)socket.RemoteEndPoint).Address.ToString() + " - Port: " + ((IPEndPoint)socket.RemoteEndPoint).Port.ToString() + "\n";
                InvokeConsole(_ConsoleStatus, Msg, true);

                _ =  socket.BeginReceive(_Buffers, 0, _Bytes, SocketFlags.None, ReceiveCallback, socket);
                _ =  _Socket.BeginAccept(AcceptCallback, null);
            }
            catch (ObjectDisposedException) { }
        }

        private static bool IsConnected(Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch
            {
                return false;
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = ar.AsyncState as Socket;
            try
            {
                if (IsConnected(socket) == false)
                {
                    string Msg = "   Client IP: " + ((IPEndPoint)socket.RemoteEndPoint).Address.ToString() + " - Port: " + ((IPEndPoint)socket.RemoteEndPoint).Port.ToString() + "\n";
                    InvokeConsole(_ConsoleStatus, Msg, string.Empty);

                    socket.Close();
                    _ = _Clients.Remove(socket);

                    return;
                }

                int bytes = socket.EndReceive(ar);

                if (bytes > 1)
                {
                    Requests req = new Requests(_Buffers, bytes);
                    switch (req.action)
                    {
                        case "Disconnected":
                            string Msg = "   Client IP: " + ((IPEndPoint)socket.RemoteEndPoint).Address.ToString() + " - Port: " + ((IPEndPoint)socket.RemoteEndPoint).Port.ToString() + "\n";
                            InvokeConsole(_ConsoleStatus, Msg, string.Empty);

                            socket.Close();
                            _ = _Clients.Remove(socket);
                            break;

                        case "request-all":
                            _ResData.Clear();
                            foreach (ContactsDB contact in _Data)
                                _ResData.Add(new Contacts(contact));

                            string json = JsonConvert.SerializeObject(_ResData);

                            Responses res = new Responses("request-all", json);
                            byte[] buff = res.toBytes();

                            _ = socket.Send(buff);
                            break;
                    }    
                }    
                else _ = socket.Send(Encoding.UTF8.GetBytes(" "));
                _ = socket.BeginReceive(_Buffers, 0, _Bytes, SocketFlags.None, ReceiveCallback, socket);
            }
            catch (SocketException) 
            {
                string Msg = "   Client IP: " + ((IPEndPoint)socket.RemoteEndPoint).Address.ToString() + " - Port: " + ((IPEndPoint)socket.RemoteEndPoint).Port.ToString() + "\n";
                InvokeConsole(_ConsoleStatus, Msg, string.Empty);

                socket.Close();
                _ = _Clients.Remove(socket);
            }
            catch (ObjectDisposedException) { }
        }

        public void Stop()
        {
            try
            {
                Responses res = new Responses("Disconnected", "Server was disconnected");
                foreach (Socket socket in _Clients)
                {
                    _ = socket.Send(res.toBytes());
                    
                    string Msg = "   Client IP: " + ((IPEndPoint)socket.RemoteEndPoint).Address.ToString() + " - Port: " + ((IPEndPoint)socket.RemoteEndPoint).Port.ToString() + "\n";
                    InvokeConsole(_ConsoleStatus, Msg, string.Empty);

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
                _Socket.Close();

                connected = false;
                InvokeConsole(_ConsoleLogger, "   Server stopped !\n", true);
                GC.Collect(0);
            }
            catch { }
        }

        private static Socket _Socket;
        private static List<Socket> _Clients;
        private static List<ContactsDB> _Data;
        private static List<Contacts> _ResData;
        private static IPAddress _IP;
        private static int _Port;
        private static int _Bytes;
        private static byte[] _Buffers;
        private static RichTextBox _ConsoleLogger;
        private static RichTextBox _ConsoleStatus;

        public bool connected;
        public RichTextBox ConsoleLogger
        {
            set { _ConsoleLogger = value; }
        }

        public RichTextBox ConsoleStatus
        {
            set { _ConsoleStatus = value; }
        }
    }
}
