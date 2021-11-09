namespace TCP_Remote
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtMyIP = new System.Windows.Forms.TextBox();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShareScreen2 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPort2
            // 
            this.txtPort2.BackColor = System.Drawing.Color.White;
            this.txtPort2.Location = new System.Drawing.Point(435, 170);
            this.txtPort2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(179, 20);
            this.txtPort2.TabIndex = 16;
            this.txtPort2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort2_KeyPress);
            // 
            // txtIP2
            // 
            this.txtIP2.BackColor = System.Drawing.Color.White;
            this.txtIP2.Location = new System.Drawing.Point(435, 61);
            this.txtIP2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(179, 20);
            this.txtIP2.TabIndex = 14;
            this.txtIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP2_KeyPress);
            // 
            // txtMyIP
            // 
            this.txtMyIP.BackColor = System.Drawing.Color.White;
            this.txtMyIP.Location = new System.Drawing.Point(145, 61);
            this.txtMyIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMyIP.Name = "txtMyIP";
            this.txtMyIP.ReadOnly = true;
            this.txtMyIP.Size = new System.Drawing.Size(138, 20);
            this.txtMyIP.TabIndex = 1;
            this.txtMyIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMyIP_KeyPress);
            // 
            // txtMyPort
            // 
            this.txtMyPort.BackColor = System.Drawing.Color.White;
            this.txtMyPort.ForeColor = System.Drawing.Color.Black;
            this.txtMyPort.Location = new System.Drawing.Point(145, 167);
            this.txtMyPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(138, 20);
            this.txtMyPort.TabIndex = 4;
            this.txtMyPort.Text = "19900";
            this.txtMyPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMyPort_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(317, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Connect Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(317, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Partner IP:";
            // 
            // btnShareScreen2
            // 
            this.btnShareScreen2.BackColor = System.Drawing.Color.White;
            this.btnShareScreen2.Location = new System.Drawing.Point(452, 325);
            this.btnShareScreen2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShareScreen2.Name = "btnShareScreen2";
            this.btnShareScreen2.Size = new System.Drawing.Size(142, 23);
            this.btnShareScreen2.TabIndex = 11;
            this.btnShareScreen2.Text = "Share your screen";
            this.btnShareScreen2.UseVisualStyleBackColor = false;
            this.btnShareScreen2.Click += new System.EventHandler(this.btnShareScreen2_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.AutoSize = true;
            this.btnConnect2.BackColor = System.Drawing.Color.White;
            this.btnConnect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect2.Location = new System.Drawing.Point(469, 275);
            this.btnConnect2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(111, 42);
            this.btnConnect2.TabIndex = 10;
            this.btnConnect2.Text = "CONNECT";
            this.btnConnect2.UseVisualStyleBackColor = false;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.BackColor = System.Drawing.Color.White;
            this.btnOpenConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenConnect.Location = new System.Drawing.Point(145, 276);
            this.btnOpenConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(137, 41);
            this.btnOpenConnect.TabIndex = 6;
            this.btnOpenConnect.Text = "OPEN CONNECT";
            this.btnOpenConnect.UseVisualStyleBackColor = false;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conenct Port:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(145, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "Open Connect: mở IP để khi người khác nhập IP thì sẽ bị kết nối";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(469, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 51);
            this.label2.TabIndex = 17;
            this.label2.Text = "Connect: nhập IP của người cộng sự gửi để bị kết nối";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShareScreen2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConnect2);
            this.Controls.Add(this.txtPort2);
            this.Controls.Add(this.btnOpenConnect);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMyPort);
            this.Controls.Add(this.txtMyIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "TCP_Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtMyIP;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShareScreen2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Button btnOpenConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}