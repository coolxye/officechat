namespace ChatClient
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.txtNewMessage = new System.Windows.Forms.TextBox();
			this.cnxMnuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mniCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.mniPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.lblNewMessage = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnPrivate = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.lstViwUsers = new System.Windows.Forms.ListView();
			this.colIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imgLstViw = new System.Windows.Forms.ImageList(this.components);
			this.txtMessages = new System.Windows.Forms.RichTextBox();
			this.cnxMniCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mniCopyText = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.tsmiChat = new System.Windows.Forms.ToolStripMenuItem();
			this.mniEnter = new System.Windows.Forms.ToolStripMenuItem();
			this.miniPrivate = new System.Windows.Forms.ToolStripMenuItem();
			this.minSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tssOne = new System.Windows.Forms.ToolStripSeparator();
			this.miniExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ntiIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cnxMnuIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.cnxMnuEdit.SuspendLayout();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.cnxMniCopy.SuspendLayout();
			this.mnuMain.SuspendLayout();
			this.cnxMnuIcon.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNewMessage
			// 
			this.txtNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNewMessage.ContextMenuStrip = this.cnxMnuEdit;
			this.txtNewMessage.Location = new System.Drawing.Point(200, 353);
			this.txtNewMessage.Name = "txtNewMessage";
			this.txtNewMessage.Size = new System.Drawing.Size(347, 21);
			this.txtNewMessage.TabIndex = 1;
			// 
			// cnxMnuEdit
			// 
			this.cnxMnuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCopy,
            this.mniPaste});
			this.cnxMnuEdit.Name = "cnxMnuEdit";
			this.cnxMnuEdit.Size = new System.Drawing.Size(101, 48);
			// 
			// mniCopy
			// 
			this.mniCopy.Name = "mniCopy";
			this.mniCopy.Size = new System.Drawing.Size(100, 22);
			this.mniCopy.Text = "Copy";
			this.mniCopy.Click += new System.EventHandler(this.mniCopy_Click);
			// 
			// mniPaste
			// 
			this.mniPaste.Name = "mniPaste";
			this.mniPaste.Size = new System.Drawing.Size(100, 22);
			this.mniPaste.Text = "Paste";
			this.mniPaste.Click += new System.EventHandler(this.mniPaste_Click);
			// 
			// lblNewMessage
			// 
			this.lblNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNewMessage.AutoSize = true;
			this.lblNewMessage.Location = new System.Drawing.Point(141, 357);
			this.lblNewMessage.Name = "lblNewMessage";
			this.lblNewMessage.Size = new System.Drawing.Size(53, 12);
			this.lblNewMessage.TabIndex = 2;
			this.lblNewMessage.Text = "Message:";
			// 
			// btnSend
			// 
			this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSend.Location = new System.Drawing.Point(553, 353);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(67, 21);
			this.btnSend.TabIndex = 3;
			this.btnSend.Text = "Send";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnPrivate
			// 
			this.btnPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrivate.Location = new System.Drawing.Point(12, 353);
			this.btnPrivate.Name = "btnPrivate";
			this.btnPrivate.Size = new System.Drawing.Size(123, 21);
			this.btnPrivate.TabIndex = 6;
			this.btnPrivate.Text = "Private Chat";
			this.btnPrivate.Click += new System.EventHandler(this.btnPrivate_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.splitContainer.Location = new System.Drawing.Point(12, 27);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.lstViwUsers);
			this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer.Panel1MinSize = 130;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.txtMessages);
			this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer.Size = new System.Drawing.Size(608, 320);
			this.splitContainer.SplitterDistance = 130;
			this.splitContainer.TabIndex = 8;
			// 
			// lstViwUsers
			// 
			this.lstViwUsers.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lstViwUsers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.lstViwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIcon,
            this.colUserName});
			this.lstViwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstViwUsers.FullRowSelect = true;
			this.lstViwUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lstViwUsers.HideSelection = false;
			this.lstViwUsers.LabelWrap = false;
			this.lstViwUsers.Location = new System.Drawing.Point(0, 0);
			this.lstViwUsers.MultiSelect = false;
			this.lstViwUsers.Name = "lstViwUsers";
			this.lstViwUsers.Size = new System.Drawing.Size(130, 320);
			this.lstViwUsers.SmallImageList = this.imgLstViw;
			this.lstViwUsers.TabIndex = 8;
			this.lstViwUsers.UseCompatibleStateImageBehavior = false;
			this.lstViwUsers.View = System.Windows.Forms.View.Details;
			this.lstViwUsers.DoubleClick += new System.EventHandler(this.btnPrivate_Click);
			// 
			// colIcon
			// 
			this.colIcon.Text = "";
			this.colIcon.Width = 23;
			// 
			// colUserName
			// 
			this.colUserName.Text = "";
			this.colUserName.Width = 85;
			// 
			// imgLstViw
			// 
			this.imgLstViw.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstViw.ImageStream")));
			this.imgLstViw.TransparentColor = System.Drawing.Color.Transparent;
			this.imgLstViw.Images.SetKeyName(0, "Smiley.png");
			// 
			// txtMessages
			// 
			this.txtMessages.ContextMenuStrip = this.cnxMniCopy;
			this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessages.Location = new System.Drawing.Point(0, 0);
			this.txtMessages.Name = "txtMessages";
			this.txtMessages.Size = new System.Drawing.Size(474, 320);
			this.txtMessages.TabIndex = 9;
			this.txtMessages.Text = "";
			// 
			// cnxMniCopy
			// 
			this.cnxMniCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCopyText});
			this.cnxMniCopy.Name = "cnxMniCopy";
			this.cnxMniCopy.Size = new System.Drawing.Size(95, 26);
			// 
			// mniCopyText
			// 
			this.mniCopyText.Name = "mniCopyText";
			this.mniCopyText.Size = new System.Drawing.Size(94, 22);
			this.mniCopyText.Text = "Copy";
			this.mniCopyText.Click += new System.EventHandler(this.mniCopyText_Click);
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChat});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(632, 24);
			this.mnuMain.TabIndex = 9;
			this.mnuMain.Text = "menuStrip1";
			// 
			// tsmiChat
			// 
			this.tsmiChat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEnter,
            this.miniPrivate,
            this.minSave,
            this.tssOne,
            this.miniExit});
			this.tsmiChat.Name = "tsmiChat";
			this.tsmiChat.Size = new System.Drawing.Size(41, 20);
			this.tsmiChat.Text = "Chat";
			// 
			// mniEnter
			// 
			this.mniEnter.Name = "mniEnter";
			this.mniEnter.Size = new System.Drawing.Size(152, 22);
			this.mniEnter.Text = "Login";
			this.mniEnter.Click += new System.EventHandler(this.mniEnter_Click);
			// 
			// miniPrivate
			// 
			this.miniPrivate.Name = "miniPrivate";
			this.miniPrivate.Size = new System.Drawing.Size(152, 22);
			this.miniPrivate.Text = "Private";
			this.miniPrivate.Click += new System.EventHandler(this.mniPrivate_Click);
			// 
			// minSave
			// 
			this.minSave.Name = "minSave";
			this.minSave.Size = new System.Drawing.Size(152, 22);
			this.minSave.Text = "Save";
			this.minSave.Click += new System.EventHandler(this.mniSave_Click);
			// 
			// tssOne
			// 
			this.tssOne.Name = "tssOne";
			this.tssOne.Size = new System.Drawing.Size(149, 6);
			// 
			// miniExit
			// 
			this.miniExit.Name = "miniExit";
			this.miniExit.Size = new System.Drawing.Size(152, 22);
			this.miniExit.Text = "Exit";
			this.miniExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// ntiIcon
			// 
			this.ntiIcon.ContextMenuStrip = this.cnxMnuIcon;
			this.ntiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiIcon.Icon")));
			this.ntiIcon.Text = "Public Room";
			this.ntiIcon.Visible = true;
			this.ntiIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiIcon_MouseDoubleClick);
			// 
			// cnxMnuIcon
			// 
			this.cnxMnuIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
			this.cnxMnuIcon.Name = "cnxMnuIcon";
			this.cnxMnuIcon.Size = new System.Drawing.Size(95, 26);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(152, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 386);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.txtNewMessage);
			this.Controls.Add(this.mnuMain);
			this.Controls.Add(this.btnPrivate);
			this.Controls.Add(this.lblNewMessage);
			this.Controls.Add(this.btnSend);
			this.MainMenuStrip = this.mnuMain;
			this.Name = "frmMain";
			this.Text = "Public Room";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.cnxMnuEdit.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.cnxMniCopy.ResumeLayout(false);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.cnxMnuIcon.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNewMessage;
		private System.Windows.Forms.Label lblNewMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnPrivate;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListView lstViwUsers;
		private System.Windows.Forms.ColumnHeader colIcon;
		private System.Windows.Forms.ColumnHeader colUserName;
		private System.Windows.Forms.RichTextBox txtMessages;
		private System.Windows.Forms.ContextMenuStrip cnxMnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mniCopy;
		private System.Windows.Forms.ToolStripMenuItem mniPaste;
		private System.Windows.Forms.ContextMenuStrip cnxMniCopy;
		private System.Windows.Forms.ToolStripMenuItem mniCopyText;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem tsmiChat;
		private System.Windows.Forms.ToolStripMenuItem mniEnter;
		private System.Windows.Forms.ToolStripMenuItem miniPrivate;
		private System.Windows.Forms.ToolStripMenuItem minSave;
		private System.Windows.Forms.ToolStripSeparator tssOne;
		private System.Windows.Forms.ToolStripMenuItem miniExit;
		private System.Windows.Forms.ImageList imgLstViw;
		private System.Windows.Forms.NotifyIcon ntiIcon;
		private System.Windows.Forms.ContextMenuStrip cnxMnuIcon;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
	}
}

