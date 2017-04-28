using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using ChatClient.ChatServices;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        // Creating the object of the web service
        ChatService chat = new ChatService();
        Configurator conf;
        // Arraylist to hold all the currently opened users.
        static public ArrayList arrOUsers = new ArrayList();
        // Arraylist to hold all the conference users.
        static public ArrayList arrConf = new ArrayList();
        static public bool bNoAlert = false;
        static public string strCacheUser = string.Empty;
        static public int iUserCnt = 0;        
        static public string strMe = string.Empty;
        static public string strMess = string.Empty;
        private bool userFlag = true;
        static public bool bConf = false;
        static public string strServiceIP = string.Empty;

        //SpVoice speech = new SpVoice();
        //SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFDefault;

        public Form1()
        {
            InitializeComponent();
            NewConf();
        }

        private void NewConf()
        {
            conf = new Configurator();
            conf.IPChange += new Configurator.IPChangeHandler(Form1_IPChange);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Retrieving the Windows UserName.
                lblUserName.Text = System.Windows.Forms.SystemInformation.UserName.ToString();
                strMe = lblUserName.Text;
                strServiceIP = (string)ConfigurationManager.AppSettings["ChatService"];
                chat.Url = "http://" + strServiceIP + "/ChatService.asmx";
                // Calling the web service for 'AddUser' for adding himself after logging.
                chat.AddUser(lblUserName.Text);
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connecting to the chat server.\rPlease check the server configuration setting.");
                //notifyIcon1.Visible = false;
                //notifyIcon1.Dispose();
                //Environment.Exit(0);
            }
        }

        private void Form1_IPChange(object sender, IPAddressInfoEventArgs e)
        {
            chat.RemoveUser(lblUserName.Text);
            strServiceIP = e.IPAddress;
            chat.Url = "http://" + strServiceIP + "/ChatService.asmx";
            // Calling the web service for 'AddUser' for adding himself after logging.
            chat.AddUser(lblUserName.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowUsers();
            RecvMessage();
        }

        private void ShowUsers()
        {
            try
            {                
                // Calling the web service for 'GetUsers' for retrieving all the currently logged users. 
                string strUList = chat.GetUsers();
                iUserCnt = String.Compare(strCacheUser, strUList);
                if (iUserCnt != 0)                
                {
                    lstUsers.Items.Clear();                   
                    string[] strUsers = strUList.Split('|');
                    strCacheUser = strUList;
                    for (int i = 0; i < strUsers.Length - 1; i++)
                    {
                        if (strUsers[i].ToUpper() != lblUserName.Text.Trim().ToUpper())
                        {
                            lstUsers.Items.Add(strUsers[i], 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error in connecting to the chat server. Please wait.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            // On closing hide the form that can be re-opened from the icon in the system tray.
            Hide();
        }

        private void lstUsers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                userFlag = true;
                // To check whether the chat window for this user is already open.
                for (int i = 0; i < arrOUsers.Count; i++)
                {
                    if (lstUsers.FocusedItem.Text.ToString() == arrOUsers[i].ToString())
                        userFlag = false;
                }
                if (userFlag == true)
                {
                    arrOUsers.Add(lstUsers.FocusedItem.Text.ToString());
                    Form f = new PrivateMessage(lstUsers.FocusedItem.Text.ToString());
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connecting to the chat server. Please try again.");
            }
        }        

        private void RecvMessage()
        {
            try
            {
                string strTemp = chat.ReceiveMessage(lblUserName.Text);
                if (strTemp.Trim().Length > 0)
                {
                    if (strTemp.Substring(0, 7) == "Ser@ver")
                    {
                        NotifyWindow nw;
                        nw = new NotifyWindow(strTemp.Substring(8, strTemp.Length - 9).ToString());
                        nw.Font = new Font("Verdana", 8.25F);
                        nw.SetDimensions(strTemp.Length + 210, 50);
                        nw.Notify();
                        //if (Form1.bNoAlert == false)                        
                        //    speech.Speak(strTemp.Substring(8, strTemp.Length - 9).ToString(), SpFlags);                        
                    }
                    else
                    {
                        strMess = strTemp;
                        string[] strUser = strMess.Split(':');
                        userFlag = true;
                        for (int i = 0; i < arrOUsers.Count; i++)
                        {
                            if (strUser[0] == arrOUsers[i].ToString())
                                userFlag = false;
                        }
                        if (userFlag == true)
                        {
                            arrOUsers.Add(strUser[0]);
                            Form f = new PrivateMessage(strUser[0], strMess);
                            f.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error in connecting to the chat server.");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chat.RemoveUser(lblUserName.Text);
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
            Environment.Exit(0);           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new About();
            f.Show();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
            }
        }

        private void conferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form f = new UserList();
            //f.Show();
            MessageBox.Show("coming soon...");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chat.RemoveUser(lblUserName.Text);
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
            Environment.Exit(0); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new About();
            f.Show();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form f = new Configurator();
            //if(conf == null)
            NewConf();
            conf.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form f = new Configurator();
            //if (conf == null)
            NewConf();
            conf.Show();
        }

        private void aboutDDATalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new About();
            f.Show();
        }

        private void chkAlert_CheckedChanged(object sender, EventArgs e)
        {            
            if(chkAlert.Checked)
                bNoAlert = true;
            else
                bNoAlert = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
            
    }
}