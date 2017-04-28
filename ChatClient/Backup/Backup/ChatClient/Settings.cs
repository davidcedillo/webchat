using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Settings : Form
    {
        private string strFontName = string.Empty;
        private string strFontSize = string.Empty;
        private string strFontStyle = string.Empty;
        private string strFontColor = string.Empty;
        private string strHistory = string.Empty;

        public Settings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnFontStyle_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            strFontName = fontDialog1.Font.Name;
            strFontSize = fontDialog1.Font.Size.ToString();
            strFontStyle = fontDialog1.Font.Style.ToString();
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            strFontColor = colorDialog1.Color.ToString();
        }
    }
}