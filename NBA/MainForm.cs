using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class mainform : Form
    {
        string[] imagelist = new string[]
                 {"2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","1.jpg",};
        int index = 0;
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form visitorform = new visitorform ();
            visitorform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 1) index = 0;
            pictureBox1.Load("../../../imagelist/" + imagelist[index + 0]);
            pictureBox2.Load("../../../imagelist/" + imagelist[index + 1]);
            pictureBox3.Load("../../../imagelist/" + imagelist[index + 2]);

            return;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 1) index = 1;
            pictureBox1.Load("../../../imagelist/" + imagelist[index + 2]);
            pictureBox2.Load("../../../imagelist/" + imagelist[index + 3]);
            pictureBox3.Load("../../../imagelist/" + imagelist[index + 4]);

            return;
        }
    }
}
