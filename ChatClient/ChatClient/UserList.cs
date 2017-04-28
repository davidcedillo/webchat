using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChatClient.ChatServices;

namespace ChatClient
{
    public partial class UserList : Form
    {
        // Creating the object of the web service
        ChatService chat = new ChatService();        
        
        public UserList()
        {
            InitializeComponent();
        }        

        private void UserList_Load(object sender, EventArgs e)
        {
            PopulateUsers();            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstAllUser.Text != "")
            {
                Form1.arrConf.Add(lstAllUser.Text);
                PopulateUsers();
            }
        }

        private void PopulateUsers()
        {
            lstAllUser.Items.Clear();
            lstSelectUser.Items.Clear();
            bool bflag = true;
            // Calling the web service for 'GetUsers' for retrieving all the currently logged users. 
            string[] strUsers = chat.GetUsers().Split('|');
            for (int i = 0; i < strUsers.Length - 1; i++)
            {
                if (strUsers[i].ToUpper() != Form1.strMe.ToUpper())
                {
                    bflag = true;
                    for (int j = 0; j < Form1.arrConf.Count - 1; j++)
                    {
                        if (strUsers[i].ToUpper() == Form1.arrConf[j].ToString().ToUpper())
                            bflag = false;
                    }
                    if (bflag == true)
                        lstAllUser.Items.Add(strUsers[i]);
                }                
            }

            for (int i = 0; i < Form1.arrConf.Count - 1; i++)
            {
                lstSelectUser.Items.Add(Form1.arrConf[i]);
            }   
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (lstSelectUser.Text != "")
            {
                Form1.arrConf.Remove(lstSelectUser.Text);
                PopulateUsers();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lstSelectUser.Items.Count < 2)
            {
                Close();
            }
            else
            {
                string strUsers = string.Empty;
                for (int i = 0; i < Form1.arrConf.Count - 1; i++)
                {
                    strUsers = strUsers + Form1.arrConf[i].ToString() + "|";
                }
                strUsers = strUsers + Form1.strMe;

                for (int i = 0; i < Form1.arrConf.Count - 1; i++)
                {
                    chat.SendMessage(Form1.strMe, Form1.arrConf[i].ToString(), "(((CONF)))"+strUsers);                    
                }
                Form f = new Conference();
                f.Show();
            }
        }
    }
}