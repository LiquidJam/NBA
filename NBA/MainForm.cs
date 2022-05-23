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
        String[] imagelist = new String[]
                 {"2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","1.jpg",};
        private int index ;
        country[] countries = new country[5];
        public static player[] players = new player[5];
        position[] positions = new position[5];
        public static team[] teams = new team[5];
        

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

            player.set(7, "Gary Williams", 193, 3, "college", "Argentina", 1300, 1,2, "Miami Heat");
            players[0] = new player();
            players[0].set(11, "Juan Hernan", 206, 5, "college", "Bosnia", 1200, 1, 4, "Orlando Magic");
            players[1] = new player();
            players[1].set(17, "Will Barton", 198, 1, "college", "Congo", 1300, 1, 6, "Atlanta Hawks");
            players[2] = new player();
            players[2].set(20, "Nikola Pekov", 210, 3, "college", "Spain", 1300, 1, 8, "Washington Wizards");
            players[3] = new player();
            players[3].set(27, "Kris Dunn", 193, 3, "college", "France", 1300, 1, 10, "Charlotte Hornets");
            players[4] = new player();

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

            

            teams[0] = new team(); 
            teams[0].set(1, "Miami Heat", "MIA" );

            teams[1] = new team();
            teams[1].set(2,"Orlando Magic", "ORL");
            
            teams[2] = new team(); 
            teams[2].set(3,"Atlanta Hawks", "ATL" );

            teams[3] = new team();
            teams[3].set(4,"Washington Wizards", "WSH");

            teams[4] = new team();
            teams[4].set(5,"Charlotte Hornets", "CHA");

            
            




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
