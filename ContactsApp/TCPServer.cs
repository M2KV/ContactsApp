using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void InvokeConsole(RichTextBox console, string text, bool append = false)
        {
            if (!console.IsDisposed)
            {
                _ = console.Invoke(new MethodInvoker(delegate {
                    if (!append) console.Text = text;
                    else console.Text += text;
                }));
            }
        }

        public void Run()
        {
            try
            {
                _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _Socket.Bind(new IPEndPoint(_IP, _Port));
                _Socket.Listen(0);
                _Socket.BeginAccept(AcceptCallback, null);
                
                connected = true;
                InvokeConsole(_ConsoleLogger, "\n   Server running successfully !\n", true);
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

                socket.BeginReceive(_Buffers, 0, _Bytes, SocketFlags.None, ReceiveCallback, socket);
                _Socket.BeginAccept(AcceptCallback, null);
            }
            catch (ObjectDisposedException) { }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = ar.AsyncState as Socket;
                int bytes = socket.EndReceive(ar);

                if (bytes > 0)
                {
                    Requests req = new Requests(_Buffers, bytes);
                    switch (req.action)
                    {
                        case "1":
                            break;
                    }    
                }    
            }
            catch (SocketException) { }
            catch (ObjectDisposedException) { }
        }

        public void Stop()
        {
            try
            {
                Responses res = new Responses("Disconnected", "Server was disconnected");
                foreach (Socket socket in _Clients)
                {
                    socket.Send(res.toBytes());
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
        private static IPAddress _IP;
        private static int _Port;
        private static int _Bytes;
        private static byte[] _Buffers;
        private RichTextBox _ConsoleLogger;
        private RichTextBox _ConsoleStatus;

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
