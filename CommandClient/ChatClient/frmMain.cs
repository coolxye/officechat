using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Proshot.CommandClient;
using Proshot.UtilityLib.CommonDialogs;


namespace ChatClient
{
    
    public partial class frmMain : Form
    {
        private Proshot.CommandClient.CMDClient client;
        private System.Collections.Generic.List<frmPrivate> privateWindowsList;
        public frmMain()
        {
            InitializeComponent();
            this.privateWindowsList = new List<frmPrivate>();
            this.client = new Proshot.CommandClient.CMDClient(IPAddress.Parse("127.0.0.1") , 8000,"None");
        }
       
        protected override bool ProcessCmdKey(ref Message msg , Keys keyData)
        {
            if ( keyData == Keys.Enter )
                this.SendMessage();
            if ( this.txtMessages.Focused  && !ShareUtils.IsValidKeyForReadOnlyFields(keyData))
                return true;
            return base.ProcessCmdKey(ref msg , keyData);
        }
        private bool IsPrivateWindowOpened(string remoteName)
        {
            foreach ( frmPrivate privateWindow in this.privateWindowsList )
                if ( privateWindow.RemoteName == remoteName )
                    return true;
            return false;
        }
        private frmPrivate FindPrivateWindow(string remoteName)
        {
            foreach ( frmPrivate privateWindow in this.privateWindowsList )
                if ( privateWindow.RemoteName == remoteName )
                    return privateWindow;
            return null;
        }
        void client_CommandReceived(object sender , CommandEventArgs e)
        {
            switch(e.Command.CommandType)
            {
                case(CommandType.Message):
                    if ( e.Command.Target.Equals(IPAddress.Broadcast) )
                        this.txtMessages.Text += e.Command.SenderName + ": " + e.Command.MetaData + Environment.NewLine;
                    else if ( !this.IsPrivateWindowOpened(e.Command.SenderName) )
                    {
                        this.OpenPrivateWindow(e.Command.SenderIP , e.Command.SenderName , e.Command.MetaData);
                        ShareUtils.PlaySound(ShareUtils.SoundType.NewMessageWithPow);
                    }
                    break;

                case(CommandType.FreeCommand):
                    string [] newInfo = e.Command.MetaData.Split(new char [] { ':' });
                    this.AddToList(newInfo [0] , newInfo [1]);
                    ShareUtils.PlaySound(ShareUtils.SoundType.NewClientEntered);
                    break;
                case (CommandType.SendClientList ):
                    string [] clientInfo = e.Command.MetaData.Split(new char[]{':'});
                    this.AddToList(clientInfo [0] , clientInfo [1]);
                    break;
                case(CommandType.ClientLogOffInform):
                    this.RemoveFromList(e.Command.SenderName);
                    break;
            }
        }

        private void RemoveFromList(string name)
        {
            ListViewItem item = this.lstViwUsers.FindItemWithText(name);
            if ( item.Text != this.client.IP.ToString() )
            {
                this.lstViwUsers.Items.Remove(item);
                ShareUtils.PlaySound(ShareUtils.SoundType.ClientExit);
            }

            frmPrivate target = this.FindPrivateWindow(name);
            if ( target != null )
                target.Close();
        }
       
        private void mniEnter_Click(object sender , EventArgs e)
        {
            if ( this.mniEnter.Text == "Login" )
            {
                frmLogin dlg = new frmLogin(IPAddress.Parse("127.0.0.1") , 8000);
                dlg.ShowDialog();
                this.client = dlg.Client;
                
                if ( this.client.Connected )
                {
                    this.client.CommandReceived += new Proshot.CommandClient.CommandReceivedEventHandler(client_CommandReceived);
                    this.client.SendCommand(new Command(CommandType.FreeCommand , IPAddress.Broadcast , this.client.IP + ":" + this.client.NetworkName));
                    this.client.SendCommand(new Proshot.CommandClient.Command(Proshot.CommandClient.CommandType.SendClientList , this.client.ServerIP));
                    this.AddToList(this.client.IP.ToString() , this.client.NetworkName);
                    this.mniEnter.Text = "Log Off";
                }
            }
            else
            {
                this.mniEnter.Text = "Login";
                this.privateWindowsList.Clear();
                this.client.Disconnect();
                this.lstViwUsers.Items.Clear();
                this.txtNewMessage.Clear();
                this.txtNewMessage.Focus();
            }
        }


        private void mniExit_Click(object sender , EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender , EventArgs e)
        {
            this.SendMessage();
        }

        private void SendMessage()
        {
            if ( this.client.Connected && this.txtNewMessage.Text.Trim() != "" )
            {
                this.client.SendCommand(new Proshot.CommandClient.Command(Proshot.CommandClient.CommandType.Message , IPAddress.Broadcast , this.txtNewMessage.Text));
                this.txtMessages.Text += this.client.NetworkName + ": " + this.txtNewMessage.Text.Trim() + Environment.NewLine;
                this.txtNewMessage.Text = "";
                this.txtNewMessage.Focus();
            }
        }

        private void AddToList(string ip,string name)
        {
            ListViewItem newItem = this.lstViwUsers.Items.Add(ip);
            newItem.ImageKey = "Smiely.png";
            newItem.SubItems.Add(name);
        }

        private void OpenPrivateWindow(IPAddress remoteClientIP,string clientName)
        {
            if ( this.client.Connected )
            {
                if ( !this.IsPrivateWindowOpened(clientName) )
                {
                    frmPrivate privateWindow = new frmPrivate(this.client , remoteClientIP , clientName);
                    this.privateWindowsList.Add(privateWindow);
                    privateWindow.FormClosed += new FormClosedEventHandler(privateWindow_FormClosed);
                    privateWindow.StartPosition = FormStartPosition.CenterParent;
                    privateWindow.Show(this);
                }
            }
        }

        private void OpenPrivateWindow(IPAddress remoteClientIP , string clientName , string initialMessage)
        {
            if (this.client.Connected )
            {
                frmPrivate privateWindow = new frmPrivate(this.client , remoteClientIP , clientName , initialMessage);
                this.privateWindowsList.Add(privateWindow);
                privateWindow.FormClosed += new FormClosedEventHandler(privateWindow_FormClosed);
                privateWindow.Show(this);
            }
        }

        void privateWindow_FormClosed(object sender , FormClosedEventArgs e)
        {
            this.privateWindowsList.Remove((frmPrivate)sender);
        }

        private void btnPrivate_Click(object sender , EventArgs e)
        {
            this.StartPrivateChat();
        }

        private void StartPrivateChat()
        {
            if ( this.lstViwUsers.SelectedItems.Count != 0 )
                this.OpenPrivateWindow(IPAddress.Parse(this.lstViwUsers.SelectedItems [0].Text) , this.lstViwUsers.SelectedItems [0].SubItems [1].Text);
        }

        private void frmMain_FormClosing(object sender , FormClosingEventArgs e)
        {
            Proshot.LanguageManager.LanguageActions.ChangeLanguageToEnglish();
            this.client.Disconnect();
        }

        private void mniSave_Click(object sender , EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "HTML Files(*.HTML;*.HTM)|*.html;*.htm";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.CheckPathExists = true;
            saveDlg.OverwritePrompt = true;
            saveDlg.FileName = this.Text;
            if ( saveDlg.ShowDialog() == DialogResult.OK )
                ShareUtils.SaveAsHTML(saveDlg.FileName , this.txtMessages.Lines , this.Text);
        }

        private void mniCopy_Click(object sender , EventArgs e)
        {
            this.txtNewMessage.Copy();
        }

        private void mniPaste_Click(object sender , EventArgs e)
        {
            this.txtNewMessage.Paste();
        }

        private void mniCopyText_Click(object sender , EventArgs e)
        {
            this.txtMessages.Copy();
        }

        private void mniPrivate_Click(object sender , EventArgs e)
        {
            this.StartPrivateChat();
        }

    }
}