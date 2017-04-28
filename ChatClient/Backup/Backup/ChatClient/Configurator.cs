using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Configurator : Form
    {
        public delegate void IPChangeHandler(object sender, IPAddressInfoEventArgs e);
        public event IPChangeHandler IPChange;

        public Configurator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnIPChange(object sender, IPAddressInfoEventArgs e)
        {
            // Check if there are any Subscribers
            if (IPChange != null)
            {
                // Call the Event
                IPChange(sender, e);
            }
        }

        private void Configurator_Load(object sender, EventArgs e)
        {
            try
            {
                System.Reflection.Assembly Asm = System.Reflection.Assembly.GetExecutingAssembly();
                string path = Asm.Location + ".config";
                string strKeyNm = "ChatService";
                string strKeyVal = GetConfigData(path, strKeyNm);
                txtIP.Text = strKeyVal;
                btnApply.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in reading the config file.");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIP.Text.Trim() == "")
                {
                    MessageBox.Show("Please specify the IP Address of the Chat Server.");
                }
                else
                {
                    System.Reflection.Assembly Asm = System.Reflection.Assembly.GetExecutingAssembly();
                    string path = Asm.Location + ".config";
                    string strKeyNm = "ChatService";
                    SaveConfigData(path, strKeyNm, txtIP.Text);
                    btnApply.Enabled = false;

                    IPAddressInfoEventArgs ipInfo = new IPAddressInfoEventArgs(txtIP.Text.Trim());
                    OnIPChange(this, ipInfo);                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to save the data in the config file.");
            }
        }

        public string GetConfigData(string strFileName, string KeyName)
        {
            try
            {
                string strKeyValue = "";
                XmlDocument xdoc = new System.Xml.XmlDocument();
                xdoc.Load(strFileName);

                foreach (XmlNode xNode in xdoc["configuration"]["appSettings"])
                {
                    if (xNode.Name == "add")
                    {
                        if (xNode.Attributes.GetNamedItem("key").Value.ToUpper() == KeyName.ToUpper())
                        {
                            strKeyValue = xNode.Attributes.GetNamedItem("value").Value;
                        }
                    }
                }
                return (strKeyValue);
            }
            catch (Exception ex)
            {
                return (null);
            }
        }

        public void SaveConfigData(string strFileName, string KeyName, string KeyValue)
        {
            XmlDocument xdoc = new System.Xml.XmlDocument();
            xdoc.Load(strFileName);

            foreach (XmlNode xNode in xdoc["configuration"]["appSettings"])
            {
                if (xNode.Name == "add")
                {
                    if (xNode.Attributes.GetNamedItem("key").Value.ToUpper() == KeyName.ToUpper())
                    {
                        xNode.Attributes.GetNamedItem("value").Value = KeyValue;
                    }
                }
            }
            xdoc.Save(strFileName);
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }
    }
}