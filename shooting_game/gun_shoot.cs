using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shooting_game
{
    //defining the class
    class gun_shoot

    {
        //declaring the public propeties
        public 
        int b_position;
        public 
        int fire1;
        public 
        int count = 1;
        public 
        int scores = 10;
        public 
        int position;
        public 
        int turns;
        Random f = new Random();
        //constructor
        public gun_shoot()
        {
            turns = 2;
        }
        //returing the bullet postion function
        public int random_bullet_position()
        { 
            position = f.Next()%6;
            return (position);
        }
        //setting the fire value
        public int fire()
        {
            position = f.Next() % 6;
            return (position);  
        }
        //returning boolean value
        public bool compare(int t,int r)
        {
            bool w = false;
            if (t == r)
            {
                w = true;

            }
            else
            {
                w = false;
            }
            return(w);
        }

    }
}
