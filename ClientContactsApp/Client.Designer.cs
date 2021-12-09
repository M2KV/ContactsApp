namespace ClientContactsApp
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AutomaticBox = new System.Windows.Forms.CheckBox();
            this.DisconnectClient = new System.Windows.Forms.Button();
            this.ConnectClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.AutomaticBox);
            this.groupBox1.Controls.Add(this.DisconnectClient);
            this.groupBox1.Controls.Add(this.ConnectClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ClientContactsApp.Properties.Resources.port;
            this.pictureBox4.Location = new System.Drawing.Point(311, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ClientContactsApp.Properties.Resources.servers1;
            this.pictureBox3.Location = new System.Drawing.Point(26, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClientContactsApp.Properties.Resources.disconnect;
            this.pictureBox2.Location = new System.Drawing.Point(285, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientContactsApp.Properties.Resources.connect;
            this.pictureBox1.Location = new System.Drawing.Point(431, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AutomaticBox
            // 
            this.AutomaticBox.AutoSize = true;
            this.AutomaticBox.Location = new System.Drawing.Point(30, 117);
            this.AutomaticBox.Name = "AutomaticBox";
            this.AutomaticBox.Size = new System.Drawing.Size(120, 29);
            this.AutomaticBox.TabIndex = 6;
            this.AutomaticBox.Text = "Automatic";
            this.AutomaticBox.UseVisualStyleBackColor = true;
            this.AutomaticBox.CheckedChanged += new System.EventHandler(this.AutomaticBox_CheckedChanged);
            // 
            // DisconnectClient
            // 
            this.DisconnectClient.BackColor = System.Drawing.Color.White;
            this.DisconnectClient.Enabled = false;
            this.DisconnectClient.Location = new System.Drawing.Point(275, 109);
            this.DisconnectClient.Name = "DisconnectClient";
            this.DisconnectClient.Size = new System.Drawing.Size(141, 45);
            this.DisconnectClient.TabIndex = 5;
            this.DisconnectClient.Text = "Disconnect";
            this.DisconnectClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconnectClient.UseVisualStyleBackColor = false;
            this.DisconnectClient.Click += new System.EventHandler(this.DisconnectClient_Click);
            // 
            // ConnectClient
            // 
            this.ConnectClient.BackColor = System.Drawing.Color.White;
            this.ConnectClient.Location = new System.Drawing.Point(422, 109);
            this.ConnectClient.Name = "ConnectClient";
            this.ConnectClient.Size = new System.Drawing.Size(125, 45);
            this.ConnectClient.TabIndex = 4;
            this.ConnectClient.Text = "Connect";
            this.ConnectClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConnectClient.UseVisualStyleBackColor = false;
            this.ConnectClient.Click += new System.EventHandler(this.ConnectClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PortBox
            // 
            this.PortBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PortBox.Location = new System.Drawing.Point(311, 63);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(226, 32);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "Input Port";
            this.PortBox.Enter += new System.EventHandler(this.PortBox_Enter);
            this.PortBox.Leave += new System.EventHandler(this.PortBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // IPBox
            // 
            this.IPBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IPBox.Location = new System.Drawing.Point(26, 63);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(226, 32);
            this.IPBox.TabIndex = 0;
            this.IPBox.Enter += new System.EventHandler(this.IPBox_Enter);
            this.IPBox.Leave += new System.EventHandler(this.IPBox_Leave);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(585, 188);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Client";
            this.Text = "Client Digital Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox AutomaticBox;
        private System.Windows.Forms.Button DisconnectClient;
        private System.Windows.Forms.Button ConnectClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

