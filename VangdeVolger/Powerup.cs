using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Powerup : Unmovable
    {
        //is active on player?
        public bool isActive;
        //duration on the player
        public int playerDuration;
        //powerUp duration
        public int lifespan;
      
        //let the powerup age over time. 
        public bool Age()
        {
            lifespan -= 1;

            if (lifespan <= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Constructor for powerup
        /// </summary>
        public Powerup()
        {
            //get powerUp image
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Powerup.png");
            isActive = false;

            //random duration on field
            Random rnd = new Random();
            lifespan = rnd.Next(1, 13);

            Random rnd2 = new Random();
            playerDuration = rnd2.Next(2, 6);
        }
    }
}
