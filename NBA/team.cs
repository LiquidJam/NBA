using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
   public class team
    {
       public String TeamName;
        String TeamCode;
        int TeamID;
        

        //инициализация класса



        public void set(
            int TeamID,
            string TeamName,
            string TeamCode)
            
        {
            
                this.TeamID = TeamID;
                this.TeamName = TeamName;
                this.TeamCode = TeamCode;
                
            
        }
    }





}

