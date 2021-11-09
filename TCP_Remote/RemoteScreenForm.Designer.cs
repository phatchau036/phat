namespace TCP_Remote
{
    partial class RemoteScreenForm
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
            this.picShowScreen = new System.Windows.Forms.PictureBox();
            this.cbxMouse = new System.Windows.Forms.CheckBox();
            this.cbxKeyBoard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picShowScreen
            // 
            this.picShowScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShowScreen.Location = new System.Drawing.Point(0, 0);
            this.picShowScreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picShowScreen.Name = "picShowScreen";
            this.picShowScreen.Size = new System.Drawing.Size(519, 354);
            this.picShowScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowScreen.TabIndex = 0;
            this.picShowScreen.TabStop = false;
            this.picShowScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseClick);
            this.picShowScreen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseDoubleClick);
            this.picShowScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseDown);
            this.picShowScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseMove);
            this.picShowScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseUp);
            // 
            // cbxMouse
            // 
            this.cbxMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMouse.AutoSize = true;
            this.cbxMouse.Location = new System.Drawing.Point(303, 337);
            this.cbxMouse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxMouse.Name = "cbxMouse";
            this.cbxMouse.Size = new System.Drawing.Size(93, 17);
            this.cbxMouse.TabIndex = 6;
            this.cbxMouse.Text = "Mouse remote";
            this.cbxMouse.UseVisualStyleBackColor = true;
            this.cbxMouse.CheckedChanged += new System.EventHandler(this.cbxMouse_CheckedChanged);
            // 
            // cbxKeyBoard
            // 
            this.cbxKeyBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxKeyBoard.AutoSize = true;
            this.cbxKeyBoard.Location = new System.Drawing.Point(399, 337);
            this.cbxKeyBoard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxKeyBoard.Name = "cbxKeyBoard";
            this.cbxKeyBoard.Size = new System.Drawing.Size(106, 17);
            this.cbxKeyBoard.TabIndex = 7;
            this.cbxKeyBoard.Text = "Keyboard remote";
            this.cbxKeyBoard.UseVisualStyleBackColor = true;
            this.cbxKeyBoard.CheckedChanged += new System.EventHandler(this.cbxKeyBoard_CheckedChanged);
            // 
            // RemoteScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.cbxKeyBoard);
            this.Controls.Add(this.cbxMouse);
            this.Controls.Add(this.picShowScreen);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RemoteScreenForm";
            this.Text = "RemoteScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteScreenForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteScreenForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemoteScreenForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picShowScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShowScreen;
        private System.Windows.Forms.CheckBox cbxMouse;
        private System.Windows.Forms.CheckBox cbxKeyBoard;
    }
}

