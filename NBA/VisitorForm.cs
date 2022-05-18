using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class visitorform : Form
    {
        public visitorform()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainform = new mainform();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form teamsform = new teams();
            teamsform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form playersform = new PlayerForm();
            playersform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form photoform = new photoform();
            photoform.Show();
        }
    }
}
