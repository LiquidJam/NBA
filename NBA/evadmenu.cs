using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class evadmenu : Form
    {
        public evadmenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form adminform = new adminform();
            adminform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addplayer = new addplayer();
            addplayer.Show();
        }
    }
}
