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
        country[] countries = new country[5];
        player[] players = new player[5];
        position[] positions = new position[5];
        team[] teams = new team[5];
        

        public mainform()
        {
            InitializeComponent();

            country country = new country();

            country.set("ARG", "Argentina");
                countries[0] = country;
            country.set("BOS", "Bosnia");
            countries[1] = country;
            country.set("CG", "Congo");
            countries[2] = country;
            country.set("ES", "Spain");
            countries[3] = country;
            country.set("FR", "France");
            countries[4] = country;

            player player = new player();

            player.set(7, "Gary Williams", 193, 3, "college", "Argentina", 1300);
            players[0] = player;
            player.set(11, "Juan Hernan", 206, 5, "college", "Bosnia", 1200);
            players[1] = player;
            player.set(17, "Will Barton", 198, 1, "college", "Congo", 1300);
            players[2] = player;
            player.set(20, "Nikola Pekov", 210, 3, "college", "Spain", 1300);
            players[3] = player;
            player.set(27, "Kris Dunn", 193, 3, "college", "France", 1300);
            players[4] = player;

            position position = new position();

            position.set("1", "SmallForward");
            positions[0] = position;
            position.set("2", "PowerForward");
            positions[1] = position;
            position.set("3", "Center");
            positions[2] = position;
            position.set("4", "ShootinGuard");
            positions[3] = position;
            position.set("5", "PointGuard");
            positions[4] = position;

            team team = new team();

            teams[0] = new team(); 
            teams[0].set("1", "Miami Heat", "MIA", "1.jpg");

            teams[1] = new team();
            teams[1].set("2", "Orlando Magic", "ORL", "2.jpg");
            
            teams[2] = new team(); 
            teams[2].set("3", "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new team();
            teams[3].set("4", "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new team();
            teams[4].set("5", "Charlotte Hornets", "CHA", "5.jpg");

            teams[5] = new team(); 
            teams[5].set("6", "Detroit Pistons", "DET", "6.jpg");

            




        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form visitorform = new visitorform ();
            visitorform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form adminform = new adminform();
            adminform.Show();
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
            if (index > 3) index = 3;
            pictureBox1.Load("../../../imagelist/" + imagelist[index + 0]);
            pictureBox2.Load("../../../imagelist/" + imagelist[index + 1]);
            pictureBox3.Load("../../../imagelist/" + imagelist[index + 2]);

            return;
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("../../../imagelist/" + imagelist[0]);
            pictureBox2.Load("../../../imagelist/" + imagelist[1]);
            pictureBox3.Load("../../../imagelist/" + imagelist[2]);
        }
    }
}
