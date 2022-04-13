using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
    class team
    {
        String TeamID;
        String Name;
        String Abbr;
        String Logo;

        //инициализация класса



        public void set(
            string TeamID,
            string Name,
            string Abbr,
            string Logo)
        {
            
                this.TeamID = TeamID;
                this.Name = Name;
                this.Abbr = Abbr;
                this.Logo = Logo;
            
        }
    }





}

