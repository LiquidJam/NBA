using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
    class country
    {
        String countryCode;
        String countryName;

        //инициализация класса 

        public void set(
               String countryName,
               String countryCode)
        {
            this.countryCode = countryCode;
            this.countryName = countryName;
        }
            
     
    }
}
