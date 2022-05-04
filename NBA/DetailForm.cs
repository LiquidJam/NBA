using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class detailform : Form

    {
        team teamD = new team();
        public int TeamID = 0;
        public detailform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void detailform_Load(object sender, EventArgs e)
        {

        }

        private void detailform_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < mainform.teams.Length; i++)
                if (this.TeamID == mainform.teams[i].TeamID) 

                        this.teamD = mainform.teams[i];
            label1.Text = this.teamD.TeamName;

                    

        }
    }
}
