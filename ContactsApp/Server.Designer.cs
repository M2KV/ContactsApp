namespace ContactsApp
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AutomaticBox = new System.Windows.Forms.CheckBox();
            this.StopServer = new System.Windows.Forms.Button();
            this.RunServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ConsoleLogger = new System.Windows.Forms.RichTextBox();
            this.ConsoleStatus = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.AutomaticBox);
            this.groupBox1.Controls.Add(this.StopServer);
            this.groupBox1.Controls.Add(this.RunServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(301, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 29);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(430, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 30);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AutomaticBox
            // 
            this.AutomaticBox.AutoSize = true;
            this.AutomaticBox.Location = new System.Drawing.Point(30, 117);
            this.AutomaticBox.Name = "AutomaticBox";
            this.AutomaticBox.Size = new System.Drawing.Size(97, 24);
            this.AutomaticBox.TabIndex = 6;
            this.AutomaticBox.Text = "Automatic";
            this.AutomaticBox.UseVisualStyleBackColor = true;
            this.AutomaticBox.CheckedChanged += new System.EventHandler(this.AutomaticBox_CheckedChanged);
            // 
            // StopServer
            // 
            this.StopServer.BackColor = System.Drawing.Color.White;
            this.StopServer.Enabled = false;
            this.StopServer.Location = new System.Drawing.Point(311, 109);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(83, 39);
            this.StopServer.TabIndex = 5;
            this.StopServer.Text = "Stop";
            this.StopServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopServer.UseVisualStyleBackColor = false;
            this.StopServer.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // RunServer
            // 
            this.RunServer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunServer.Location = new System.Drawing.Point(421, 109);
            this.RunServer.Name = "RunServer";
            this.RunServer.Size = new System.Drawing.Size(83, 39);
            this.RunServer.TabIndex = 4;
            this.RunServer.Text = "Start";
            this.RunServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunServer.UseVisualStyleBackColor = false;
            this.RunServer.Click += new System.EventHandler(this.RunServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Number";
            // 
            // PortBox
            // 
            this.PortBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PortBox.Location = new System.Drawing.Point(311, 63);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(226, 27);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "Input Port";
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            this.PortBox.Enter += new System.EventHandler(this.PortBox_Enter);
            this.PortBox.Leave += new System.EventHandler(this.PortBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // IPBox
            // 
            this.IPBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IPBox.Location = new System.Drawing.Point(26, 63);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(226, 27);
            this.IPBox.TabIndex = 0;
            this.IPBox.Enter += new System.EventHandler(this.IPBox_Enter);
            this.IPBox.Leave += new System.EventHandler(this.IPBox_Leave);
            // 
            // ConsoleLogger
            // 
            this.ConsoleLogger.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ConsoleLogger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleLogger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLogger.Location = new System.Drawing.Point(4, 57);
            this.ConsoleLogger.Name = "ConsoleLogger";
            this.ConsoleLogger.ReadOnly = true;
            this.ConsoleLogger.Size = new System.Drawing.Size(366, 265);
            this.ConsoleLogger.TabIndex = 1;
            this.ConsoleLogger.Text = "";
            this.ConsoleLogger.TextChanged += new System.EventHandler(this.ConsoleLogger_TextChanged);
            // 
            // ConsoleStatus
            // 
            this.ConsoleStatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ConsoleStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleStatus.Location = new System.Drawing.Point(373, 57);
            this.ConsoleStatus.Name = "ConsoleStatus";
            this.ConsoleStatus.ReadOnly = true;
            this.ConsoleStatus.Size = new System.Drawing.Size(188, 265);
            this.ConsoleStatus.TabIndex = 2;
            this.ConsoleStatus.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(376, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status Remote Clients";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConsoleStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ConsoleLogger);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(10, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 328);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // Server
            // 
            this.AcceptButton = this.RunServer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(585, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server Digital Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button RunServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button StopServer;
        private System.Windows.Forms.CheckBox AutomaticBox;
        private System.Windows.Forms.RichTextBox ConsoleLogger;
        private System.Windows.Forms.RichTextBox ConsoleStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

