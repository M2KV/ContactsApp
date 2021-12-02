using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            IPBox.Text = (!AutomaticBox.Checked) ? "Input IP" : "127.0.0.1";
            PortBox.Text = (!AutomaticBox.Checked) ? "Input Port" : "8080";
        }

        private void ConnectClient_Click(object sender, EventArgs e)
        {

        }
    }
}
