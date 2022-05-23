using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
    public class player
    { 
        public int number; 
        public String name; 
        public int growth; 
        public int position; 
        public String college;
        public String country; 
        public float price;
        public int teamiD;
        public int PlayerID;
        public String TeamName;
        

        public void set(
            int number,
            String name,
            int growth,
            int position,
            String college,
            String country,
            float price,
            int teamId,
            int PlayerID,
            String TeamName)
        {
            this.number = number;
            this.name = name;
            this.growth = growth;
            this.position = position;
            this.college = college;
            this.country = country;
            this.price = price;
            this.teamiD = teamiD;
            this.PlayerID = PlayerID;
            this.TeamName = TeamName;


           }

        




    }
}
