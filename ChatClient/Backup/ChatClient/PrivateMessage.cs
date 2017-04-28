using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChatClient.ChatServices;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Xml.XPath;

namespace ChatClient
{
    public partial class PrivateMessage : Form
    {
        [DllImport("user32.dll")]
        static extern Int32 FlashWindowEx(ref FLASHWINFO pwfi);

        [StructLayout(LayoutKind.Sequential)]
        public struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }

        //Stop flashing. The system restores the window to its original state. 
        public const UInt32 FLASHW_STOP = 0;
        //Flash the window caption. 
        public const UInt32 FLASHW_CAPTION = 1;
        //Flash the taskbar button. 
        public const UInt32 FLASHW_TRAY = 2;
        //Flash both the window caption and taskbar button.
        //This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags. 
        public const UInt32 FLASHW_ALL = 3;
        //Flash continuously, until the FLASHW_STOP flag is set. 
        public const UInt32 FLASHW_TIMER = 4;
        //Flash continuously until the window comes to the foreground. 
        public const UInt32 FLASHW_TIMERNOFG = 12; 

        ChatService chat = new ChatService();        
        private string strUser;
        private Font font;

        public PrivateMessage()
        {
            InitializeComponent();
            //ReadSettings();            
        }

        public PrivateMessage(string strUserName)
        {
            InitializeComponent();
            strUser = strUserName;
            //ReadSettings();
        }

        public PrivateMessage(string strUserName, string strMg)
        {
            try
            {
                InitializeComponent();
                strUser = strUserName;
                string[] strU = Form1.strMess.Split(':');
                string strM = string.Empty;

                for (int i = 1; i < strU.Length; i++)
                {
                    strM = strM + strU[i];
                }
                rtbMessage.SelectedText = strU[0] + ": ";
                rtbMessage.SelectedRtf = strM;
                Form1.strMess = "";
                //ReadSettings();            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in connecting to the chat server. Please try again.");
            }
        }        

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbWriteMsg.Text.Trim().Length > 0 || rtbWriteMsg.Rtf.Trim().Length > 129)
                {
                    chat.SendMessage(Form1.strMe, strUser, rtbWriteMsg.Rtf);
                    rtbMessage.SelectedText = Form1.strMe + ": ";
                    rtbMessage.SelectedRtf = rtbWriteMsg.Rtf;
                    rtbMessage.ScrollToCaret();
                    rtbWriteMsg.Clear();
                    rtbWriteMsg.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connecting to the chat server. Please try again.");
            }
        }

        private void PrivateMessage_Load(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
            Text = strUser;
            panel1.Visible = false;
            chat.Url = "http://" + Form1.strServiceIP + "/ChatService.asmx";
            rtbWriteMsg.Focus();
        }

        private void PrivateMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.arrOUsers.Remove(strUser);
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Form1.strMess.Trim().Length > 0)
                {
                    string[] strU = Form1.strMess.Split(':');
                    string strM = string.Empty;
                    if (strU[0] == strUser)
                    {
                        for (int i = 1; i < strU.Length; i++)
                        {
                            strM = strM + strU[i];
                        }
                        rtbMessage.SelectedText = strU[0] + ": ";
                        rtbMessage.SelectedRtf = strM;
                        Form1.strMess = "";
                        rtbMessage.ScrollToCaret();
                        FlashWindowEx(this);
                    }
                    if (this.WindowState == FormWindowState.Minimized && Form1.bNoAlert == false)
                    {
                        int iRw = 0;
                        int iHt = 0;
                        NotifyWindow nw;
                        RichTextBox rtb = new RichTextBox();
                        rtb.Rtf = strM;
                        if (rtb.Text.Trim().Length == 0)
                        {
                            nw = new NotifyWindow(strU[0].ToString(), "Emotions");
                            nw.SetDimensions(220, 70);
                        }
                        else
                        {
                            iRw = (rtb.Text.Length / 30);
                            iRw = iRw + 1;
                            iHt = (iRw * 25) + 40;
                            nw = new NotifyWindow(strU[0].ToString(), rtb.Text);
                            nw.SetDimensions(220, iHt);
                        }
                        font = new Font("Verdana", 8.25F);
                        nw.Font = font;
                        nw.Notify();
                        rtb.Dispose();
                        //font.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error in connecting to the chat server.");
            }
        }    

        public static bool FlashWindowEx(Form frm)
        {
            IntPtr hWnd = frm.Handle;
            FLASHWINFO fInfo = new FLASHWINFO();

            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;
            fInfo.dwFlags = FLASHW_ALL | FLASHW_TIMERNOFG;
            fInfo.uCount = UInt32.MaxValue;
            fInfo.dwTimeout = 0;

            return (FlashWindowEx(ref fInfo) == 0);
        }

        private void rtbWriteMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (rtbWriteMsg.Text.Trim().Length > 0 || rtbWriteMsg.Rtf.Trim().Length > 129)
                    {
                        chat.SendMessage(Form1.strMe, strUser, rtbWriteMsg.Rtf);
                        rtbMessage.SelectedText = Form1.strMe + ": ";
                        rtbMessage.SelectedRtf = rtbWriteMsg.Rtf;
                        rtbMessage.ScrollToCaret();
                        rtbWriteMsg.Clear();
                        rtbWriteMsg.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connecting to the chat server. Please try again.");
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font = new Font(fontDialog1.Font.Name, fontDialog1.Font.Size, fontDialog1.Font.Style);
            rtbWriteMsg.Font = font;
            rtbWriteMsg.Focus();
            font.Dispose();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtbWriteMsg.ForeColor = colorDialog1.Color;
            rtbWriteMsg.Focus();
        }

        private void btnEmotion_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnSmile.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);             
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnSad.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);            
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void ReadSettings()
        {            
            XPathDocument xpathdoc = new XPathDocument("D:\\Settings\\DDASettings.xml");
            XPathNavigator pathnav = xpathdoc.CreateNavigator();
            XPathNodeIterator iter = pathnav.Select("/Settings/Font");
            while (iter.MoveNext())
            {
                string fName = iter.Current.GetAttribute("Name", "");
                float flSize = (float)Convert.ToInt32(iter.Current.GetAttribute("Size", ""));
                             
                rtbWriteMsg.Font = new Font(fName, flSize, FontStyle.Bold); 
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn3.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn4.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn5.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn6.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn7.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn8.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn9.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn10.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn11.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn12.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn13.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn14.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn15.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn16.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn17.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn18.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn19.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn20.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btn21.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            rtbWriteMsg.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }       
    }
}