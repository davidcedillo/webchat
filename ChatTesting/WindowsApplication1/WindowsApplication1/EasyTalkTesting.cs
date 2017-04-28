using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication1.aspspider;

namespace WindowsApplication1
{
    public partial class EasyTalkTesting : Form
    {
        ChatService chat = new ChatService();

        public EasyTalkTesting()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {   
                // Calling the web service for 'AddUser' for adding the new user.
                chat.AddUser(txtUserName.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Calling the web service for 'GetUsers' for retrieving the list of users.
                string strUList = chat.GetUsers();               
                lstUsers.Items.Clear();
                string[] strUsers = strUList.Split('|');
                for (int i = 0; i < strUsers.Length - 1; i++)
                {
                    lstUsers.Items.Add(strUsers[i]);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EasyTalkTesting_Load(object sender, EventArgs e)
        {          
            chat.Url = txtAddress.Text;
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            // Calling the web service for 'RemoveUsers' for removine the user.
            chat.RemoveUser(txtRemoveUser.Text);
        }
    }
}