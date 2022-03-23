using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class teamsform : Form
    {
        public teamsform()
        {
            InitializeComponent();
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form visitorform = new visitorform();
            visitorform.Show();
        }

        private void linkLabel65_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel68_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
