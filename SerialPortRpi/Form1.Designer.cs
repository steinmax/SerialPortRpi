namespace SerialPortRpi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbSerialPorts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsole = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.lbnTime = new System.Windows.Forms.Label();
            this.gpConnection = new System.Windows.Forms.GroupBox();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSerialPorts
            // 
            this.lbSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSerialPorts.FormattingEnabled = true;
            this.lbSerialPorts.ItemHeight = 23;
            this.lbSerialPorts.Items.AddRange(new object[] {
            "Loading..."});
            this.lbSerialPorts.Location = new System.Drawing.Point(0, 30);
            this.lbSerialPorts.Name = "lbSerialPorts";
            this.lbSerialPorts.Size = new System.Drawing.Size(190, 556);
            this.lbSerialPorts.TabIndex = 1;
            this.lbSerialPorts.SelectedIndexChanged += new System.EventHandler(this.lbSerialPorts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available COM-Ports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbConsole);
            this.groupBox1.Location = new System.Drawing.Point(194, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 453);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I / O Currently: Offline";
            // 
            // tbConsole
            // 
            this.tbConsole.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsole.Location = new System.Drawing.Point(6, 29);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(1005, 413);
            this.tbConsole.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsole);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(194, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 123);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration / Console";
            // 
            // btnConsole
            // 
            this.btnConsole.Location = new System.Drawing.Point(56, 70);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(130, 43);
            this.btnConsole.TabIndex = 2;
            this.btnConsole.Text = "Clear";
            this.btnConsole.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(140, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "9600";
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(43, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Baudrate:";
            // 
            // lbnTime
            // 
            this.lbnTime.Location = new System.Drawing.Point(931, 4);
            this.lbnTime.Name = "lbnTime";
            this.lbnTime.Size = new System.Drawing.Size(282, 31);
            this.lbnTime.TabIndex = 4;
            this.lbnTime.Text = "Samstag, 7. Nov 18:56";
            this.lbnTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpConnection
            // 
            this.gpConnection.Controls.Add(this.btnNewMessage);
            this.gpConnection.Controls.Add(this.btnConnect);
            this.gpConnection.Location = new System.Drawing.Point(436, 4);
            this.gpConnection.Name = "gpConnection";
            this.gpConnection.Size = new System.Drawing.Size(349, 123);
            this.gpConnection.TabIndex = 5;
            this.gpConnection.TabStop = false;
            this.gpConnection.Text = "Connection";
            this.gpConnection.Visible = false;
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.Location = new System.Drawing.Point(180, 30);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(157, 75);
            this.btnNewMessage.TabIndex = 1;
            this.btnNewMessage.Text = "New Message";
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 29);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(168, 76);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to <serialPortName>";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 587);
            this.Controls.Add(this.gpConnection);
            this.Controls.Add(this.lbnTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSerialPorts);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialmonitor for RPI [Touchfriendly]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpConnection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbSerialPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Label lbnTime;
        private System.Windows.Forms.GroupBox gpConnection;
        private System.Windows.Forms.Button btnNewMessage;
        private System.Windows.Forms.Button btnConnect;
    }
}

