using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lnkLbl_Click(object sender, EventArgs e)
        {
            lnkLbl.LinkVisited = true;            
            System.Diagnostics.Process.Start(lnkLbl.Text);
        }
    }
}