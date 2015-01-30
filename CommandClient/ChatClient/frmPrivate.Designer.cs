namespace ChatClient
{
	partial class frmPrivate
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
			this.txtNewMessage = new System.Windows.Forms.TextBox();
			this.lblNewMessage = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mniChat = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
			this.txtMessages = new System.Windows.Forms.RichTextBox();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNewMessage
			// 
			this.txtNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNewMessage.Location = new System.Drawing.Point(71, 203);
			this.txtNewMessage.Name = "txtNewMessage";
			this.txtNewMessage.Size = new System.Drawing.Size(206, 21);
			this.txtNewMessage.TabIndex = 1;
			// 
			// lblNewMessage
			// 
			this.lblNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNewMessage.AutoSize = true;
			this.lblNewMessage.Location = new System.Drawing.Point(12, 207);
			this.lblNewMessage.Name = "lblNewMessage";
			this.lblNewMessage.Size = new System.Drawing.Size(53, 12);
			this.lblNewMessage.TabIndex = 2;
			this.lblNewMessage.Text = "Message:";
			// 
			// btnSend
			// 
			this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSend.Location = new System.Drawing.Point(283, 203);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(57, 21);
			this.btnSend.TabIndex = 3;
			this.btnSend.Text = "Send";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniChat});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(352, 24);
			this.mnuMain.TabIndex = 7;
			// 
			// mniChat
			// 
			this.mniChat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSave,
            this.mniExit});
			this.mniChat.Name = "mniChat";
			this.mniChat.Size = new System.Drawing.Size(41, 20);
			this.mniChat.Text = "Chat";
			// 
			// mniSave
			// 
			this.mniSave.Name = "mniSave";
			this.mniSave.Size = new System.Drawing.Size(94, 22);
			this.mniSave.Text = "Save";
			this.mniSave.Click += new System.EventHandler(this.mniSave_Click);
			// 
			// mniExit
			// 
			this.mniExit.Name = "mniExit";
			this.mniExit.Size = new System.Drawing.Size(94, 22);
			this.mniExit.Text = "Exit";
			this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
			// 
			// txtMessages
			// 
			this.txtMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMessages.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtMessages.Location = new System.Drawing.Point(0, 27);
			this.txtMessages.Name = "txtMessages";
			this.txtMessages.Size = new System.Drawing.Size(352, 170);
			this.txtMessages.TabIndex = 8;
			this.txtMessages.Text = "";
			// 
			// frmPrivate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 236);
			this.Controls.Add(this.txtMessages);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.lblNewMessage);
			this.Controls.Add(this.txtNewMessage);
			this.Controls.Add(this.mnuMain);
			this.Name = "frmPrivate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Private Chat";
			this.Activated += new System.EventHandler(this.frmPrivate_Activated);
			this.Deactivate += new System.EventHandler(this.frmPrivate_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrivate_FormClosing);
			this.Load += new System.EventHandler(this.frmPrivate_Load);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNewMessage;
		private System.Windows.Forms.Label lblNewMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem mniChat;
		private System.Windows.Forms.ToolStripMenuItem mniSave;
		private System.Windows.Forms.ToolStripMenuItem mniExit;
		private System.Windows.Forms.RichTextBox txtMessages;
	}
}

