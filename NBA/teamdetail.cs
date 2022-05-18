using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class teamdetail : Form
    {
        team teamD = new team();
        public int TeamID = 0;
        public teamdetail()
        {
            InitializeComponent();
        }

       

        public void teamdetail_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < mainform.teams.Length; i++)
                if (this.TeamID == mainform.teams[i].TeamID)
                    this.teamD = mainform.teams[i];
            label2.Text = this.teamD.TeamName;


            for (int i = 0; i < mainform.players.Length; i++)
                if (mainform.players[i].TeamID == this.TeamID)
                {
                    dataGridView1.Rows.Add(mainform.players[i].number, mainform.players[i].name, mainform.players[i].growth, mainform.players[i].position, mainform.players[i].college, mainform.players[i].country, mainform.players[i].price, mainform.players[i].TeamID, mainform.players[i].PlayerID, mainform.players[i].TeamName);
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

