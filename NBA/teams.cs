using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class teams : Form
    {
        public teams()
        {
            InitializeComponent();
            lab1.Text mainform.Teams[0].TeamName;
            for (int i = 0; i < 5; i++)
                Controls["panel" + (1 + 1)].Controls["label" + (1 + 1) ].Text = mainform.Teams[1].TeamName;

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
