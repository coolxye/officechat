using System;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
//using Proshot.UtilityLib.CommonDialogs;

namespace ChatClient
{
	public partial class frmLogin : Form
	{
		private bool canClose;
		private Proshot.CommandClient.CMDClient client;
		public Proshot.CommandClient.CMDClient Client
		{
			get { return client; }
		}
		//public frmLogin(IPAddress serverIP, int serverPort)
		//{
		//    InitializeComponent();
		//    this.canClose = false;
		//    Control.CheckForIllegalCrossThreadCalls = false;
		//    this.client = new Proshot.CommandClient.CMDClient(serverIP, serverPort, "None");
		//    this.client.CommandReceived += new Proshot.CommandClient.CommandReceivedEventHandler(CommandReceived);
		//    this.client.ConnectingSuccessed += new Proshot.CommandClient.ConnectingSuccessedEventHandler(client_ConnectingSuccessed);
		//    this.client.ConnectingFailed += new Proshot.CommandClient.ConnectingFailedEventHandler(client_ConnectingFailed);
		//}

		public frmLogin()
		{
			InitializeComponent();

			this.cboServer.SelectedIndex = 0;

			this.canClose = false;
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void client_ConnectingFailed(object sender, EventArgs e)
		{
			//frmPopup popup = new frmPopup(PopupSkins.SmallInfoSkin);
			//popup.ShowPopup("Error", "Server Is Not Accessible !", 200, 2000, 2000);
			MessageBox.Show(this, "Server Is Not Accessible !", "Error");
			this.SetEnablity(true);
		}

		private void client_ConnectingSuccessed(object sender, EventArgs e)
		{
			this.client.SendCommand(new Proshot.CommandClient.Command(Proshot.CommandClient.CommandType.IsNameExists, this.client.IP, this.client.NetworkName));
		}

		void CommandReceived(object sender, Proshot.CommandClient.CommandEventArgs e)
		{
			if (e.Command.CommandType == Proshot.CommandClient.CommandType.IsNameExists)
			{
				if (e.Command.MetaData.ToLower() == "true")
				{
					//frmPopup popup = new frmPopup(PopupSkins.SmallInfoSkin);
					//popup.ShowPopup("Error", "The Username is already exists !", 300, 2000, 2000);
					MessageBox.Show(this, "The Username is already exists !", "Error");
					this.client.Disconnect();
					this.SetEnablity(true);
				}
				else
				{
					this.canClose = true;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}

		private void LoginToServer()
		{
			if (!Regex.IsMatch(this.cboServer.Text.Trim(),
				@"^(?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))$"))
			{
				MessageBox.Show(this, "Server isn't exist !", "Error");
				this.SetEnablity(true);
				this.cboServer.Focus();
				return;
			}

			if (this.txtUserName.Text.Trim() == "")
			{
				//frmPopup popup = new frmPopup(PopupSkins.SmallInfoSkin);
				//popup.ShowPopup("Error", "Username is empty !", 1000, 2000, 2000);
				MessageBox.Show(this, "Username is empty !", "Error");
				this.SetEnablity(true);
				this.txtUserName.Focus();
				return;
			}

			IPAddress serverIP = IPAddress.Parse(this.cboServer.Text.Trim());
			//int serverPort = 8000;
			//this.client.CommandReceived -= new Proshot.CommandClient.CommandReceivedEventHandler(CommandReceived);
			this.client = new Proshot.CommandClient.CMDClient(serverIP, 8000, "None");
			this.client.CommandReceived += new Proshot.CommandClient.CommandReceivedEventHandler(CommandReceived);
			this.client.ConnectingSuccessed += new Proshot.CommandClient.ConnectingSuccessedEventHandler(client_ConnectingSuccessed);
			this.client.ConnectingFailed += new Proshot.CommandClient.ConnectingFailedEventHandler(client_ConnectingFailed);
			this.client.NetworkName = this.txtUserName.Text.Trim();
			this.client.ConnectToServer();
		}
		private void btnEnter_Click(object sender, EventArgs e)
		{
			this.SetEnablity(false);
			this.LoginToServer();
		}
		private void SetEnablity(bool enable)
		{
			this.btnEnter.Enabled = enable;
			this.cboServer.Enabled = enable;
			this.txtUserName.Enabled = enable;
			this.btnExit.Enabled = enable;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.canClose = true;
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.canClose)
				e.Cancel = true;
			else
			{
				if (this.client != null)
					this.client.CommandReceived -= new Proshot.CommandClient.CommandReceivedEventHandler(CommandReceived);
			}
		}
	}
}