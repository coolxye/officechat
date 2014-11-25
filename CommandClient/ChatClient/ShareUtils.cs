using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChatClient
{
    internal static class ShareUtils
    {
        internal enum SoundType
        {
            NewClientEntered,
            NewMessageReceived,
            NewMessageWithPow,
            ClientExit
        }
        internal static void SaveAsHTML(string fileName , string [] lines,string titleString)
        {
            string htmlString = "<HTML>"+Environment.NewLine;
            string dateTime = "( " + DateTime.Now.ToLongTimeString()+" )";
            htmlString += "<meta charset=utf-8/>"+Environment.NewLine;
            htmlString += "<Title>" + titleString + "</Title>" + Environment.NewLine;
            htmlString += "<link rel='stylesheet' href='Files/Styles.css' type='Text/Css'" + Environment.NewLine;
            htmlString += "<Body>" + Environment.NewLine;
            htmlString += "<Table align='center'><TR><TD class='Header'>" + titleString + "</TD><TD class='Header'>" + dateTime + "</TD><TD><IMG src='Files/face.gif'/></TD></TR></Table><HR width='60%'>";
            htmlString += Environment.NewLine + "<Table>";
            foreach ( string line in lines )
                if ( line.Trim() != "" ) 
                    htmlString += "<TR><TD><IMG src='Files/arrow.gif'/></TD><TD>"+line + "</TD></TR>" + Environment.NewLine;
            htmlString += "</Table>";
            htmlString += Environment.NewLine+"</Body></HTML>";
            string dirName = fileName.Substring(0,fileName.LastIndexOf('\\'));
            System.IO.Directory.CreateDirectory(dirName + "\\Files");
            Proshot.ResourceManager.Resourcer rc = new Proshot.ResourceManager.Resourcer(Proshot.ResourceManager.LoadMethod.FromCallingCode);
            rc.ExtractAndSaveToFile("face.gif" , dirName + "\\Files\\face.gif");
            rc.ExtractAndSaveToFile("arrow.gif" , dirName + "\\Files\\arrow.gif");
            rc.ExtractAndSaveToFile("Styles.css" , dirName + "\\Files\\Styles.css");
            System.IO.FileStream fs = new System.IO.FileStream(fileName , System.IO.FileMode.Create);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
            sw.Write(htmlString);
            sw.Flush();
            sw.Close();
        }
        internal static void PlaySound(ShareUtils.SoundType soundType)
        {
            Proshot.ResourceManager.Resourcer rcMngr = new Proshot.ResourceManager.Resourcer(Proshot.ResourceManager.LoadMethod.FromCallingCode);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            switch ( soundType )
            {
                case ( ShareUtils.SoundType.NewClientEntered ):
                    player.Stream = rcMngr.GetResourceStream("Knock.wav");
                    player.Play();
                    break;
                case ( ShareUtils.SoundType.ClientExit ):
                    player.Stream = rcMngr.GetResourceStream("Door.wav");
                    player.Play();
                    break;
                case ( ShareUtils.SoundType.NewMessageReceived ):
                    player.Stream = rcMngr.GetResourceStream("Message.wav");
                    player.Play();
                    break;
                case ( ShareUtils.SoundType.NewMessageWithPow ):
                    player.Stream = rcMngr.GetResourceStream("Pow.wav");
                    player.Play();
                    break;
            }
        }
        internal static bool IsValidKeyForReadOnlyFields(Keys key)
        {
            switch ( key )
            {
                case ( Keys.Up ):
                case ( Keys.Down ):
                case ( Keys.Left ):
                case ( Keys.Right ):
                case ( Keys.PageUp ):
                case ( Keys.PageDown ):
                case ( Keys.F1 ):
                case ( Keys.F2 ):
                case ( Keys.F3 ):
                case ( Keys.F4 ):
                case ( Keys.F5 ):
                case ( Keys.F6 ):
                case ( Keys.F7 ):
                case ( Keys.F8 ):
                case ( Keys.F9 ):
                case ( Keys.F10 ):
                case ( Keys.F11 ):
                case ( Keys.F12 ):
                case ( Keys.F13 ):
                case ( Keys.F14 ):
                case ( Keys.F15 ):
                case ( Keys.F16 ):
                case ( Keys.F17 ):
                case ( Keys.F18 ):
                case ( Keys.F19 ):
                case ( Keys.F20 ):
                case ( Keys.F21 ):
                case ( Keys.F22 ):
                case ( Keys.F23 ):
                case ( Keys.F24 ):
                case ( Keys.Shift ):
                case ( Keys.ShiftKey ):
                case ( Keys.Control ):
                case ( Keys.ControlKey ):
                case ( Keys.CapsLock ):
                case ( Keys.Scroll ):
                case ( Keys.Alt ):
                case ( Keys.Apps ):
                case ( Keys.End ):
                case ( Keys.Escape ):
                case ( Keys.Help ):
                case ( Keys.Home ):
                case ( Keys.Insert ):
                case ( Keys.LButton ):
                case ( Keys.LControlKey ):
                case ( Keys.LMenu ):
                case ( Keys.MButton ):
                case ( Keys.Menu ):
                case ( Keys.VolumeDown ):
                case ( Keys.VolumeMute ):
                case ( Keys.VolumeUp ):
                case ( Keys.XButton1 ):
                case ( Keys.XButton2 ):
                case ( Keys.Zoom ):
                    return true;
                default:
                    return false;
            }
        }

    }

}
