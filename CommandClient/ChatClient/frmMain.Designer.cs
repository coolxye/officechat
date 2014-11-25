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
            if ( disposing && ( components != null ) )
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
            this.txtNewMessage = new Proshot.UtilityLib.TextBox();
            this.cnxMnuEdit = new Proshot.UtilityLib.ContextMenuStrip();
            this.mniCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNewMessage = new Proshot.UtilityLib.Label();
            this.btnSend = new Proshot.UtilityLib.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnPrivate = new Proshot.UtilityLib.Button();
            this.mnuMain = new Proshot.UtilityLib.MenuStrip();
            this.mniChat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPrivate = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lstViwUsers = new Proshot.UtilityLib.ListView();
            this.colIcon = new System.Windows.Forms.ColumnHeader();
            this.colUserName = new System.Windows.Forms.ColumnHeader();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.cnxMniCopy = new Proshot.UtilityLib.ContextMenuStrip();
            this.mniCopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.cnxMnuEdit.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.cnxMniCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewMessage
            // 
            this.txtNewMessage.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtNewMessage.BorderWidth = 1F;
            this.txtNewMessage.ContextMenuStrip = this.cnxMnuEdit;
            this.txtNewMessage.FloatValue = 0;
            this.txtNewMessage.Location = new System.Drawing.Point(204 , 427);
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.Size = new System.Drawing.Size(353 , 21);
            this.txtNewMessage.TabIndex = 1;
            // 
            // cnxMnuEdit
            // 
            this.cnxMnuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem [] {
            this.mniCopy,
            this.mniPaste});
            this.cnxMnuEdit.Name = "cnxMnuEdit";
            this.cnxMnuEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cnxMnuEdit.Size = new System.Drawing.Size(130 , 48);
            // 
            // mniCopy
            // 
            this.mniCopy.Name = "mniCopy";
            this.mniCopy.Size = new System.Drawing.Size(129 , 22);
            this.mniCopy.Text = "کپی متن";
            this.mniCopy.Click += new System.EventHandler(this.mniCopy_Click);
            // 
            // mniPaste
            // 
            this.mniPaste.Name = "mniPaste";
            this.mniPaste.Size = new System.Drawing.Size(129 , 22);
            this.mniPaste.Text = "انداختن متن";
            this.mniPaste.Click += new System.EventHandler(this.mniPaste_Click);
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.BorderWidth = 1F;
            this.lblNewMessage.Location = new System.Drawing.Point(137 , 430);
            this.lblNewMessage.Name = "lblNewMessage";
            this.lblNewMessage.Size = new System.Drawing.Size(56 , 13);
            this.lblNewMessage.TabIndex = 2;
            this.lblNewMessage.Text = "Message :";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.ImageKey = "SendMessage.ico";
            this.btnSend.ImageList = this.imgList;
            this.btnSend.Location = new System.Drawing.Point(563 , 426);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(67 , 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ( (System.Windows.Forms.ImageListStreamer)( resources.GetObject("imgList.ImageStream") ) );
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0 , "Smiely.png");
            this.imgList.Images.SetKeyName(1 , "Private.ico");
            this.imgList.Images.SetKeyName(2 , "SendMessage.ico");
            this.imgList.Images.SetKeyName(3 , "Enter.ico");
            this.imgList.Images.SetKeyName(4 , "Exit.ico");
            // 
            // btnPrivate
            // 
            this.btnPrivate.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.btnPrivate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrivate.ImageKey = "Private.ico";
            this.btnPrivate.ImageList = this.imgList;
            this.btnPrivate.Location = new System.Drawing.Point(6 , 424);
            this.btnPrivate.Name = "btnPrivate";
            this.btnPrivate.Size = new System.Drawing.Size(123 , 23);
            this.btnPrivate.TabIndex = 6;
            this.btnPrivate.Text = "Private Chat";
            this.btnPrivate.UseVisualStyleBackColor = true;
            this.btnPrivate.Click += new System.EventHandler(this.btnPrivate_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject("mnuMain.BackgroundImage") ) );
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem [] {
            this.mniChat});
            this.mnuMain.Location = new System.Drawing.Point(0 , 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(635 , 24);
            this.mnuMain.TabIndex = 7;
            // 
            // mniChat
            // 
            this.mniChat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem [] {
            this.mniEnter,
            this.mniPrivate,
            this.mniSave,
            this.toolStripMenuItem1,
            this.mniExit});
            this.mniChat.Name = "mniChat";
            this.mniChat.Size = new System.Drawing.Size(42 , 20);
            this.mniChat.Text = "Chat";
            // 
            // mniEnter
            // 
            this.mniEnter.Image = ( (System.Drawing.Image)( resources.GetObject("mniEnter.Image") ) );
            this.mniEnter.Name = "mniEnter";
            this.mniEnter.Size = new System.Drawing.Size(152 , 22);
            this.mniEnter.Text = "Login";
            this.mniEnter.Click += new System.EventHandler(this.mniEnter_Click);
            // 
            // mniPrivate
            // 
            this.mniPrivate.Image = ( (System.Drawing.Image)( resources.GetObject("mniPrivate.Image") ) );
            this.mniPrivate.Name = "mniPrivate";
            this.mniPrivate.Size = new System.Drawing.Size(152 , 22);
            this.mniPrivate.Text = "Private";
            this.mniPrivate.Click += new System.EventHandler(this.mniPrivate_Click);
            // 
            // mniSave
            // 
            this.mniSave.Image = ( (System.Drawing.Image)( resources.GetObject("mniSave.Image") ) );
            this.mniSave.Name = "mniSave";
            this.mniSave.Size = new System.Drawing.Size(152 , 22);
            this.mniSave.Text = "Save";
            this.mniSave.Click += new System.EventHandler(this.mniSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149 , 6);
            // 
            // mniExit
            // 
            this.mniExit.Image = ( (System.Drawing.Image)( resources.GetObject("mniExit.Image") ) );
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152 , 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.splitContainer.Location = new System.Drawing.Point(3 , 24);
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
            this.splitContainer.Size = new System.Drawing.Size(627 , 394);
            this.splitContainer.SplitterDistance = 130;
            this.splitContainer.TabIndex = 8;
            // 
            // lstViwUsers
            // 
            this.lstViwUsers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstViwUsers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstViwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader [] {
            this.colIcon,
            this.colUserName});
            this.lstViwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViwUsers.FullRowSelect = true;
            this.lstViwUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstViwUsers.HideSelection = false;
            this.lstViwUsers.LabelWrap = false;
            this.lstViwUsers.Location = new System.Drawing.Point(0 , 0);
            this.lstViwUsers.MultiSelect = false;
            this.lstViwUsers.Name = "lstViwUsers";
            this.lstViwUsers.RightToLeftLayout = true;
            this.lstViwUsers.Size = new System.Drawing.Size(130 , 394);
            this.lstViwUsers.SmallImageList = this.imgList;
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
            // txtMessages
            // 
            this.txtMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessages.ContextMenuStrip = this.cnxMniCopy;
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(0 , 0);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(493 , 394);
            this.txtMessages.TabIndex = 9;
            this.txtMessages.Text = "";
            // 
            // cnxMniCopy
            // 
            this.cnxMniCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem [] {
            this.mniCopyText});
            this.cnxMniCopy.Name = "cnxMniCopy";
            this.cnxMniCopy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cnxMniCopy.Size = new System.Drawing.Size(116 , 26);
            // 
            // mniCopyText
            // 
            this.mniCopyText.Name = "mniCopyText";
            this.mniCopyText.Size = new System.Drawing.Size(115 , 22);
            this.mniCopyText.Text = "کپی متن";
            this.mniCopyText.Click += new System.EventHandler(this.mniCopyText_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F , 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635 , 459);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnPrivate);
            this.Controls.Add(this.txtNewMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblNewMessage);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte)( 177 ) ));
            this.MinimumSize = new System.Drawing.Size(643 , 493);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Public Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.cnxMnuEdit.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.cnxMniCopy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Proshot.UtilityLib.TextBox txtNewMessage;
        private Proshot.UtilityLib.Label lblNewMessage;
        private Proshot.UtilityLib.Button btnSend;
        private Proshot.UtilityLib.Button btnPrivate;
        private System.Windows.Forms.ImageList imgList;
        private Proshot.UtilityLib.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniChat;
        private System.Windows.Forms.ToolStripMenuItem mniEnter;
        private System.Windows.Forms.ToolStripMenuItem mniSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniPrivate;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Proshot.UtilityLib.ListView lstViwUsers;
        private System.Windows.Forms.ColumnHeader colIcon;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.RichTextBox txtMessages;
        private Proshot.UtilityLib.ContextMenuStrip cnxMnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mniCopy;
        private System.Windows.Forms.ToolStripMenuItem mniPaste;
        private Proshot.UtilityLib.ContextMenuStrip cnxMniCopy;
        private System.Windows.Forms.ToolStripMenuItem mniCopyText;
    }
}

