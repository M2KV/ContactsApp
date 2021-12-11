using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class Server : Form
    {
        public Server()
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
            IPBox.BackColor     = SystemColors.Window;
            PortBox.BackColor   = SystemColors.Window;

            IPBox.ReadOnly      = AutomaticBox.Checked;
            PortBox.ReadOnly    = AutomaticBox.Checked;

            IPBox.ForeColor     = (AutomaticBox.Checked) ? SystemColors.WindowText : SystemColors.WindowFrame;
            PortBox.ForeColor   = (AutomaticBox.Checked) ? SystemColors.WindowText : SystemColors.WindowFrame;

            IPBox.Text   = (!AutomaticBox.Checked)   ? "Input IP"    : IPAddress.Loopback.ToString();
            PortBox.Text = (!AutomaticBox.Checked)   ? "Input Port"  : "8080";
        }

        private void RunServer_Click(object sender, EventArgs e)
        {
            if (Empty(IPBox.Text) || Empty(PortBox.Text))
                _ = MessageBox.Show("IP address or Port number can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!IsIPAddress(IPBox.Text) || !IsPortNumber(PortBox.Text))
                _ = MessageBox.Show("IP address or Port number is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (_Server == null)
            {
                _Server = new TCPServer(IPBox.Text, PortBox.Text, 10485760);
                _Server.ConsoleLogger = ConsoleLogger;
                _Server.ConsoleStatus = ConsoleStatus;

                _Server.Run();

                if (_Server.connected)
                {
                    StopServer.Enabled = true;
                    RunServer.Enabled = false;

                    _ = MessageBox.Show("Server is running !", "Server running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _Server = null;
                    _ = MessageBox.Show("Server cannot run !", "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
            if (_Server.connected)
            {
                _Server.Stop();
                
                if (!_Server.connected)
                {
                    _Server = null;

                    StopServer.Enabled = false;
                    RunServer.Enabled = true;
                    _ = MessageBox.Show("Server stopped !", "Server disconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    _ = MessageBox.Show("Server cannot stop !", "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit ?", "Exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
                if (_Server != null && _Server.connected)
                {
                    _Server.Stop();
                    _Server = null;
                }
            }
            else e.Cancel = true;
        }

        private static TCPServer _Server = null;
    }
}
