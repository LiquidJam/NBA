using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class logform : Form
    {
        public logform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form evadmenu = new evadmenu();
            evadmenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form techadmenu = new techadmenu();
            techadmenu.Show();
        }
    }
}
