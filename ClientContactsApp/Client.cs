using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ClientContactsApp
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private bool Empty(string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        private bool IsIPAddress(string ip)
        {
            Match collection = Regex.Match(ip, @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b");

            if (collection.Value.Length <= 0) return false;
            return true;
        }

        private bool IsPortNumber(string port)
        {
            Match collection = Regex.Match(port, @"^([0-9]{1,4}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$");

            if (collection.Value.Length <= 0) return false;
            return true;
        }

        private void IPBox_Enter(object sender, EventArgs e)
        {
            if (IPBox.Text == "Input IP")
            {
                IPBox.ForeColor = SystemColors.WindowText;
                IPBox.Clear();
            }
        }

        private void IPBox_Leave(object sender, EventArgs e)
        {
            if (Empty(IPBox.Text))
            {
                IPBox.ForeColor = SystemColors.WindowFrame;
                IPBox.Text = "Input IP";
            }
        }

        private void PortBox_Enter(object sender, EventArgs e)
        {
            if (PortBox.Text == "Input Port")
            {
                PortBox.ForeColor = SystemColors.WindowText;
                PortBox.Clear();
            }
        }

        private void PortBox_Leave(object sender, EventArgs e)
        {
            if (Empty(PortBox.Text))
            {
                PortBox.ForeColor = SystemColors.WindowFrame;
                PortBox.Text = "Input Port";
            }
        }

        private void AutomaticBox_CheckedChanged(object sender, EventArgs e)
        {
            IPBox.BackColor = SystemColors.Window;
            PortBox.BackColor = SystemColors.Window;

            IPBox.ReadOnly = AutomaticBox.Checked;
            PortBox.ReadOnly = AutomaticBox.Checked;

            IPBox.ForeColor = (AutomaticBox.Checked) ? SystemColors.WindowText : SystemColors.WindowFrame;
            PortBox.ForeColor = (AutomaticBox.Checked) ? SystemColors.WindowText : SystemColors.WindowFrame;

            IPBox.Text = (!AutomaticBox.Checked) ? "Input IP" : IPAddress.Loopback.ToString();
            PortBox.Text = (!AutomaticBox.Checked) ? "Input Port" : "8080";
        }

        private void ConnectClient_Click(object sender, EventArgs e)
        {
            if (Empty(IPBox.Text) || Empty(PortBox.Text))
                _ = MessageBox.Show("IP address or Port number can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!IsIPAddress(IPBox.Text) || !IsPortNumber(PortBox.Text))
                _ = MessageBox.Show("IP address or Port number is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (_Client == null)
            {
                _Client = new TCPClient(IPBox.Text, PortBox.Text, 10485760);
                _Client.Connect();

                if (_Client.connected)
                { 
                    DisconnectClient.Enabled = true;
                    ConnectClient.Enabled = false;

                    _ = MessageBox.Show("Client connected to server successfully !", "Client connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Hide();
                    
                    Searching search = new Searching();
                    search.Client = _Client;
                    search.ShowDialog();
                    
                    Show();
                    Receive();
                }
                else
                {
                    _Client = null;
                    _ = MessageBox.Show("Client cannot connect to server", "Client error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Receive()
        {
            running = true;

            ReceiveThread = new Thread(() => {
                Responses res = null;
                while (running && _Client != null && _Client.connected)
                {
                    res = _Client.Receive();

                    if (res != null)
                    {
                        if (res.action == "Disconnected")
                            Invoke(new MethodInvoker(delegate
                            {
                                _ = MessageBox.Show(res.message, "Server stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }));
                    }
                    else running = false;
                }
            });
            ReceiveThread.Start();
        }

        private void EndReceive()
        {
            running = false;
            ReceiveThread.Join();
        }

        private void DisconnectClient_Click(object sender, EventArgs e)
        {
            if (_Client != null && _Client.connected)
            {
                _Client.Disconnect();
                if (!_Client.connected)
                {
                    _Client = null;
                    EndReceive();

                    DisconnectClient.Enabled = false;
                    ConnectClient.Enabled = true;
                    _ = MessageBox.Show("Client disconnected !", "Client disconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    _ = MessageBox.Show("Client cannot disconnect !", "Client error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit ?", "Exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
                if (_Client != null && _Client.connected)
                {
                    _Client.Disconnect();
                    _Client = null;
                    EndReceive();
                }
            }
            else e.Cancel = true;
        }

        private bool running = false;
        private Thread ReceiveThread = null;
        private TCPClient _Client = null;
    }

}
