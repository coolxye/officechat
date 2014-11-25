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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrivate));
            this.txtNewMessage = new Proshot.UtilityLib.TextBox();
            this.lblNewMessage = new Proshot.UtilityLib.Label();
            this.btnSend = new Proshot.UtilityLib.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.mnuMain = new Proshot.UtilityLib.MenuStrip();
            this.mniChat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewMessage
            // 
            this.txtNewMessage.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtNewMessage.BorderWidth = 1F;
            this.txtNewMessage.FloatValue = 0;
            this.txtNewMessage.Location = new System.Drawing.Point(65 , 223);
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.Size = new System.Drawing.Size(203 , 21);
            this.txtNewMessage.TabIndex = 1;
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.BorderWidth = 1F;
            this.lblNewMessage.Location = new System.Drawing.Point(3 , 226);
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
            this.btnSend.Location = new System.Drawing.Point(276 , 222);
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
            this.imgList.Images.SetKeyName(0 , "Smiely.ico");
            this.imgList.Images.SetKeyName(1 , "Private.ico");
            this.imgList.Images.SetKeyName(2 , "SendMessage.ico");
            this.imgList.Images.SetKeyName(3 , "Enter.ico");
            this.imgList.Images.SetKeyName(4 , "Exit.ico");
            // 
            // mnuMain
            // 
            this.mnuMain.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject("mnuMain.BackgroundImage") ) );
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem [] {
            this.mniChat});
            this.mnuMain.Location = new System.Drawing.Point(0 , 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(346 , 24);
            this.mnuMain.TabIndex = 7;
            // 
            // mniChat
            // 
            this.mniChat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem [] {
            this.mniSave,
            this.mniExit});
            this.mniChat.Name = "mniChat";
            this.mniChat.Size = new System.Drawing.Size(42 , 20);
            this.mniChat.Text = "Chat";
            // 
            // mniSave
            // 
            this.mniSave.Image = ( (System.Drawing.Image)( resources.GetObject("mniSave.Image") ) );
            this.mniSave.Name = "mniSave";
            this.mniSave.Size = new System.Drawing.Size(152 , 22);
            this.mniSave.Text = "Save";
            this.mniSave.Click += new System.EventHandler(this.mniSave_Click);
            // 
            // mniExit
            // 
            this.mniExit.Image = ( (System.Drawing.Image)( resources.GetObject("mniExit.Image") ) );
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152 , 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtMessages.Location = new System.Drawing.Point(2 , 27);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(343 , 185);
            this.txtMessages.TabIndex = 8;
            this.txtMessages.Text = "";
            // 
            // frmPrivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F , 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346 , 258);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblNewMessage);
            this.Controls.Add(this.txtNewMessage);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte)( 177 ) ));
            this.MinimumSize = new System.Drawing.Size(354 , 292);
            this.Name = "frmPrivate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Private Chat";
            this.Deactivate += new System.EventHandler(this.frmPrivate_Deactivate);
            this.Activated += new System.EventHandler(this.frmPrivate_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrivate_FormClosing);
            this.Load += new System.EventHandler(this.frmPrivate_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Proshot.UtilityLib.TextBox txtNewMessage;
        private Proshot.UtilityLib.Label lblNewMessage;
        private Proshot.UtilityLib.Button btnSend;
        private System.Windows.Forms.ImageList imgList;
        private Proshot.UtilityLib.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniChat;
        private System.Windows.Forms.ToolStripMenuItem mniSave;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.RichTextBox txtMessages;
    }
}

