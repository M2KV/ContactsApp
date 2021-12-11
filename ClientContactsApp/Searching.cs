using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClientContactsApp
{
    public partial class Searching : Form
    {
        public Searching()
        {
            InitializeComponent();
        }

        private bool Empty(string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Searching...")
            {
                SearchBox.ForeColor = SystemColors.WindowText;
                SearchBox.Clear();
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (Empty(SearchBox.Text))
            {
                SearchBox.ForeColor = SystemColors.WindowFrame;
                SearchBox.Text = "Searching...";
            }
        }

        private void Searching_Load(object sender, EventArgs e)
        {
            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox0);
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);

            RichTextBoxs = new List<RichTextBox>();
            RichTextBoxs.Add(richTextBox0);
            RichTextBoxs.Add(richTextBox1);
            RichTextBoxs.Add(richTextBox2);
            RichTextBoxs.Add(richTextBox3);
            RichTextBoxs.Add(richTextBox4);
            RichTextBoxs.Add(richTextBox5);


            Requests req = new Requests("request-all", "all");
            _Client.Send(req);
            Receive();
        }

        private void Receive()
        {
            running = true;

            ReceiveThread = new Thread(() => {
                Responses res = null;
                while (running && _Client != null && _Client.connected)
                {
                    res = _Client.Receive();
                    _Client.Send(" "); // handshake

                    if (res == null) running = false;
                    else if (res.action != null)
                    {
                        if (res.action == "Disconnected")
                            _ = Invoke(new MethodInvoker(delegate {
                                _ = MessageBox.Show(res.message, "Server stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }));
                        else
                        {
                            contacts = JsonConvert.DeserializeObject<List<Contacts>>(res.message);
                            page = 0;
                            UpdateForm();
                        }
                    }
                }
            });
            ReceiveThread.Start();
        }

        private void UpdateForm()
        {
            Invoke(new MethodInvoker(delegate { 
                Text = "Searching Digital Contacts - Page " + (page + 1).ToString() + "/" + (contacts.Count / step + 1).ToString();
            }));

            for (int i = 0; i < step; ++i)
            {
                _ = Invoke(new MethodInvoker(delegate
                  {
                      if (page * step + i >= contacts.Count)
                      {
                          pictureBoxes[i].Visible = false;
                          RichTextBoxs[i].Visible = false;

                          pictureBoxes[i].Image = null;
                          RichTextBoxs[i].Text = "";
                      }
                      else
                      {
                          pictureBoxes[i].Visible = true;
                          RichTextBoxs[i].Visible = true;

                          RichTextBoxs[i].Text = "";
                          using (MemoryStream memstr = new MemoryStream(contacts[page * step + i].avarta))
                          {
                              Bitmap bmp = new Bitmap(Image.FromStream(memstr), pictureBoxes[i].Width, pictureBoxes[i].Height);
                              Image img = bmp;
                              pictureBoxes[i].Image = img;
                          }

                          RichTextBoxs[i].Text += "   ID: " + contacts[page * step + i].id;
                          RichTextBoxs[i].Text += "\n\n   Full name: " + contacts[page * step + i].username;
                          RichTextBoxs[i].Text += "\n\n   Phonenumbers: \n";

                          for (int j = 0; j < contacts[page * step + i].phonenumber.Count; ++j)
                              RichTextBoxs[i].Text += "\t" + contacts[page * step + i].phonenumber[j] + "\n";

                          RichTextBoxs[i].Text += "\n   Email: " + contacts[page * step + i].email;
                      }
                  }));
            }
        }

        private void EndReceive()
        {
            running = false;
            ReceiveThread.Join();
        }

        private void Searching_FormClosing(object sender, FormClosingEventArgs e)
        {
            EndReceive();
            GC.Collect(0);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (page < contacts.Count / step)
            {
                page++;
                UpdateForm();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                UpdateForm();
            }
        }

        private List<PictureBox> pictureBoxes;
        private List<RichTextBox> RichTextBoxs;

        private bool running = false;
        private Thread ReceiveThread = null;
        
        private TCPClient _Client = null;
        
        private List<Contacts> contacts;

        private int page = 0;
        private int step = 6;

        public TCPClient Client { set { _Client = value; } }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Empty(SearchBox.Text) || SearchBox.Text == "Searching..." || Empty(DropdownChoice.Text))
                MessageBox.Show("Search and choice cannot empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Requests req;
                if (DropdownChoice.Text == "Default")
                    req = new Requests("request-all", "all");
                else req = new Requests("request-" + DropdownChoice.Text, SearchBox.Text);
                _Client.Send(req);
            }
        }
    }
}
