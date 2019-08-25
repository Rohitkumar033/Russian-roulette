using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_roulette
{
    public class Bullet
    {
        //creating the object of the random class that is used to generate the random no to fire 
        Random rd = new Random();
        // this is user define method that is used to generate the no of trigger to fire
        public int generateFire() {
            // this is the method that is used to fire 
            return rd.Next(1, 6);
        }
        //reset the trigger to generate the fire again
        public int reset() {
            return 0;
        }
        public int winner() {
            return rd.Next(1, 6);
        }
    }
}
