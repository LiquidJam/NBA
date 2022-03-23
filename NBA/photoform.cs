using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class photoform : Form
    {
        public photoform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form visitorform = new visitorform();
            visitorform.Show();
        }
    }
}
