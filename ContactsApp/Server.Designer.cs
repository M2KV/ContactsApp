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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.RunServer = new System.Windows.Forms.Button();
            this.StopServer = new System.Windows.Forms.Button();
            this.AutomaticBox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
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
            // 
            // IPBox
            // 
            this.IPBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IPBox.Location = new System.Drawing.Point(24, 63);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(226, 27);
            this.IPBox.TabIndex = 0;
            this.IPBox.Enter += new System.EventHandler(this.IPBox_Enter);
            this.IPBox.Leave += new System.EventHandler(this.IPBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Number";
            // 
            // PortBox
            // 
            this.PortBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PortBox.Location = new System.Drawing.Point(309, 63);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(226, 27);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "Input Port";
            this.PortBox.Enter += new System.EventHandler(this.PortBox_Enter);
            this.PortBox.Leave += new System.EventHandler(this.PortBox_Leave);
            // 
            // RunServer
            // 
            this.RunServer.Location = new System.Drawing.Point(430, 109);
            this.RunServer.Name = "RunServer";
            this.RunServer.Size = new System.Drawing.Size(105, 39);
            this.RunServer.TabIndex = 4;
            this.RunServer.Text = "Start";
            this.RunServer.UseVisualStyleBackColor = true;
            this.RunServer.Click += new System.EventHandler(this.RunServer_Click);
            // 
            // StopServer
            // 
            this.StopServer.Enabled = false;
            this.StopServer.Location = new System.Drawing.Point(309, 109);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(105, 39);
            this.StopServer.TabIndex = 5;
            this.StopServer.Text = "Stop";
            this.StopServer.UseVisualStyleBackColor = true;
            // 
            // AutomaticBox
            // 
            this.AutomaticBox.AutoSize = true;
            this.AutomaticBox.Location = new System.Drawing.Point(28, 117);
            this.AutomaticBox.Name = "AutomaticBox";
            this.AutomaticBox.Size = new System.Drawing.Size(97, 24);
            this.AutomaticBox.TabIndex = 6;
            this.AutomaticBox.Text = "Automatic";
            this.AutomaticBox.UseVisualStyleBackColor = true;
            this.AutomaticBox.CheckedChanged += new System.EventHandler(this.AutomaticBox_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(366, 265);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(373, 57);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(188, 265);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label3);
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
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(585, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server Digital Contacts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

