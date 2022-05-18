using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBA
{
    public partial class addplayer : Form
    {
        public addplayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player player = new player();
            player.number = Convert.ToInt32(textBox1.Text);
            player.name = (textBox2.Text); 
            player.growth = Convert.ToInt32(textBox3.Text);
            player.position = Convert.ToInt32(textBox4.Text);
            player.college = textBox5.Text;
            player.country = textBox6.Text;
            player.price = Convert.ToInt32(textBox7.Text);
            player.TeamID = Convert.ToInt32(textBox8.Text);
            player.TeamName = comboBox1.Text;


            for (int i = 0; i < mainform.teams.Length; i++)
                if (comboBox1.Text == mainform.teams[i].TeamName)
                    player.TeamID = mainform.teams[i].TeamID;

            Array.Resize(
                ref mainform.players, mainform.players.Length + 1);
            mainform.players[mainform.players.Length - 1] = player;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
