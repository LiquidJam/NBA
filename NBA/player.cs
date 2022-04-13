using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
    class player
    { 
        public int number; //номер игрока 
        public String name; //имя игрока 
        public int growth; //рост игрока 
        public int position; //позиция 
        public String college; //образование
        public String country; //страна

        public float price;
        //инициализация класса

        public void set(
            int number,
            String name,
            int growth,
            int position,
            String college,
            String country,
            //DateTime dateofbirth,
            float price)
        {
            this.number = number;
            this.name = name;
            this.growth = growth;
            this.position = position;
            this.college = college;
            this.country = country;
            // this.dateofbirth = date of birth;
            this.price = price;


           }

        




    }
}
