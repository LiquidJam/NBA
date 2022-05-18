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
            label1.Text = mainform.teams[0].TeamName;
            for (int i = 0; i < 5; i++)
                this.Controls.Find("linkLabel22", true)[0].Text = mainform.teams[0].TeamName;
            this.Controls.Find("linkLabel23", true)[0].Text = mainform.teams[1].TeamName;
            this.Controls.Find("linkLabel73", true)[0].Text = mainform.teams[2].TeamName;
            this.Controls.Find("linkLabel74", true)[0].Text = mainform.teams[3].TeamName;
            this.Controls.Find("linkLabel75", true)[0].Text = mainform.teams[4].TeamName;

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

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        public void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form teamdetail = new teamdetail();
            teamdetail.TeamID = 0;
            teamdetail.Show();

        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form teamdetail = new teamdetail();
            
            teamdetail.Show();
        }

        private void linkLabel73_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form teamdetail = new teamdetail();
            teamdetail.Show();
        }

        private void linkLabel74_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form teamdetail = new teamdetail();
            teamdetail.Show();
        }

        private void linkLabel75_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form teamdetail = new teamdetail();
            teamdetail.Show();
        }

        private void teams_Load(object sender, EventArgs e)
        {

        }

        private void Eastern_Click(object sender, EventArgs e)
        {

        }
    }
}
