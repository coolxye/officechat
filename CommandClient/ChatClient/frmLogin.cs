using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Proshot.UtilityLib.CommonDialogs;

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
        public frmLogin(IPAddress serverIP,int serverPort)
        {
            InitializeComponent();
            this.canClose = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            this.client = new Proshot.CommandClient.CMDClient(serverIP , serverPort , "None");
            this.client.CommandReceived += new Proshot.CommandClient.CommandReceivedEventHandler(CommandReceived);
            this.client.ConnectingSuccessed += new Proshot.CommandClient.ConnectingSuccessedEventHandler(client_ConnectingSuccessed);
            this.client.ConnectingFailed += new Proshot.CommandClient.ConnectingFailedEventHandler(client_ConnectingFailed);
        }

        private void client_ConnectingFailed(object sender , EventArgs e)
        {
            frmPopup popup = new frmPopup(PopupSkins.SmallInfoSkin);
            popup.ShowPopup("Error" , "Server Is Not Accessible !" , 200 , 2000 , 2000);
            this.SetEnablity(true);
        }

        private void client_ConnectingSuccessed(object sender , EventArgs e)
        {
           this.client.SendCommand(new Proshot.CommandClient.Command(Proshot.CommandClient.CommandType.IsNameExists,this.client.IP,this.client.NetworkName));
        }

        void CommandReceived(object sender , Proshot.CommandClient.CommandEventArgs e)
        {
            if ( e.Command.CommandType == Proshot.CommandClient.CommandType.IsNameExists )
            {
                if ( e.Command.MetaData.ToLower() == "true" )
                {
                    frmPopup popup = new frmPopup(PopupSkins.SmallInfoSkin);
                    popup.ShowPopup("Error" , "The Username is already exists !" , 300 , 2000 , 2000);
                    this.client.Disconnect();
                    this.SetEnablity(true);
                }
                else
                {
                    this.canClose = true;
                    this.Close();
                }
            }
        }

        private void LoginToServer()
        {
            if ( this.txtUsetName.Text.Trim() == "" )
            {
                frmPopup popup = new frmPopup(PopupSkins.SmallInfoSkin);
                popup.ShowPopup("Error" , "Username is empty !" , 1000 , 2000 , 2000);
                this.SetEnablity(true);
            }
            else
            {
                this.client.NetworkName = this.txtUsetName.Text.Trim();
                this.client.ConnectToServer();
            }
        }
        private void btnEnter_Click(object sender , EventArgs e)
        {
            this.SetEnablity(false);
            this.LoginToServer();
        }
        private void SetEnablity(bool enable)
        {
            this.btnEnter.Enabled = enable;
            this.txtUsetName.Enabled = enable;
            this.btnExit.Enabled = enable;
        }

        private void btnExit_Click(object sender , EventArgs e)
        {
            this.canClose = true;
        }

        private void frmLogin_FormClosing(object sender , FormClosingEventArgs e)
        {
            if ( !this.canClose )
                e.Cancel = true;
            else
                this.client.CommandReceived -= new Proshot.CommandClient.CommandReceivedEventHandler(CommandReceived);
        }
    }
}