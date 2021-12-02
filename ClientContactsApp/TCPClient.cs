using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ClientContactsApp
{
    public class TCPClient
    {
        public TCPClient(string ip, string port, int bytes)
        {
            _IP = IPAddress.Parse(ip);
            _Port = int.Parse(port);
            _Bytes = bytes;
            _Buffers = new byte[bytes];
            connected = false;
        }

        public void Connect()
        {
            try
            {
                _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _Socket.Connect(_IP, _Port);

                connected = true;
            }
            catch (SocketException ex)
            {
                _ = MessageBox.Show(ex.Message, "Socket create error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Send(Requests req)
        {
            _Socket.Send(req.toBytes());
        }

        public void Send(string str)
        {
            try
            {
                _Socket.Send(Encoding.UTF8.GetBytes(str));
            }
            catch (SocketException) { }
            catch (ObjectDisposedException) { }
        }

        public Responses Receive()
        {
            try
            {
                int bytes = _Socket.Receive(_Buffers, 0, _Bytes, SocketFlags.None);
                return (bytes > 1) ? new Responses(_Buffers, bytes) : null;
            }
            catch (SocketException) { return null; }
            catch (ObjectDisposedException) { return null; }
        }

        public void Disconnect()
        {
            try
            {
                Requests req = new Requests("Disconnected", "Client was disconnected");
                _Socket.Close();

                connected = false;
                GC.Collect(0);
            }
            catch { }
        }

        private static Socket _Socket;
        private static IPAddress _IP;
        private static int _Port;
        private static int _Bytes;
        private static byte[] _Buffers;

        public bool connected;
    }
}
