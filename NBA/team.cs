using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
   public class team
    {
       public String TeamName;
        String TeamCode;
        public int TeamiD;
        

        //инициализация класса



        public void set(
            int TeamiD,
            string TeamName,
            string TeamCode)
            
        {
            
                this.TeamiD = TeamiD;
                this.TeamName = TeamName;
                this.TeamCode = TeamCode;
                
            
        }
    }





}

