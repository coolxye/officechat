namespace ChatClient
{
	partial class frmLogin
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
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblServer = new System.Windows.Forms.Label();
			this.txtServerIp = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(12, 40);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(71, 12);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.Text = "User Name :";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(83, 37);
			this.txtUserName.MaxLength = 10;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(103, 21);
			this.txtUserName.TabIndex = 3;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(103, 64);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(50, 20);
			this.btnEnter.TabIndex = 4;
			this.btnEnter.Text = "Enter";
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(47, 64);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(50, 20);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Location = new System.Drawing.Point(12, 13);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(65, 12);
			this.lblServer.TabIndex = 0;
			this.lblServer.Text = "Sever IP :";
			// 
			// txtServerIp
			// 
			this.txtServerIp.Location = new System.Drawing.Point(83, 10);
			this.txtServerIp.MaxLength = 15;
			this.txtServerIp.Name = "txtServerIp";
			this.txtServerIp.Size = new System.Drawing.Size(103, 21);
			this.txtServerIp.TabIndex = 1;
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnEnter;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(198, 96);
			this.ControlBox = false;
			this.Controls.Add(this.txtServerIp);
			this.Controls.Add(this.lblServer);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblUserName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmLogin";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.TextBox txtServerIp;

	}
}