using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            IPBox.Text   = (!AutomaticBox.Checked)   ? "Input IP"    : "127.0.0.1";
            PortBox.Text = (!AutomaticBox.Checked)   ? "Input Port"  : "8080";
        }

        private void RunServer_Click(object sender, EventArgs e)
        {
            if (_Server == null)
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
                    _ = MessageBox.Show("Server cannot run !", "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static TCPServer _Server = null;

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
            if (_Server != null && _Server.connected)
            {
                _Server.Stop();
                _Server = null;

                StopServer.Enabled = false;
                RunServer.Enabled = true;
            }
        }
    }
}
