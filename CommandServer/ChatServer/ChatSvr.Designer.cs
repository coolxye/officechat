namespace ChatServer
{
	partial class ChatSvr
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatSvr));
			this.ntiIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmsIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.rtbServer = new System.Windows.Forms.RichTextBox();
			this.cmsIcon.SuspendLayout();
			this.SuspendLayout();
			// 
			// ntiIcon
			// 
			this.ntiIcon.ContextMenuStrip = this.cmsIcon;
			this.ntiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiIcon.Icon")));
			this.ntiIcon.Text = "Chat Server";
			this.ntiIcon.Visible = true;
			this.ntiIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiIcon_MouseDoubleClick);
			// 
			// cmsIcon
			// 
			this.cmsIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
			this.cmsIcon.Name = "cmsIcon";
			this.cmsIcon.Size = new System.Drawing.Size(95, 26);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(94, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// rtbServer
			// 
			this.rtbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbServer.Location = new System.Drawing.Point(13, 13);
			this.rtbServer.Name = "rtbServer";
			this.rtbServer.Size = new System.Drawing.Size(447, 241);
			this.rtbServer.TabIndex = 1;
			this.rtbServer.Text = "";
			// 
			// ChatSvr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 266);
			this.Controls.Add(this.rtbServer);
			this.Name = "ChatSvr";
			this.Text = "Chat Server";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatSvr_FormClosing);
			this.cmsIcon.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon ntiIcon;
		private System.Windows.Forms.ContextMenuStrip cmsIcon;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.RichTextBox rtbServer;
	}
}

