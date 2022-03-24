using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class techadmenu : Form
    {
        public techadmenu()
        {
            InitializeComponent();
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logform = new logform();
            logform.Show();
        }
    }
}
