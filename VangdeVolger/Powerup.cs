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
        //born is timer on creation
        private int _born;
        //is active on player?
        public bool isActive;
        //duration on the player
        public int playerDuration;
        //powerUp duration
        public int lifespan;

        //private Timer gameDuration;

      

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
        /// 
        /// </summary>
        /// <param name="givenLife">Int that assigns the time that the powerup will be alive</param>
        public Powerup(int timestamp)
        {
            //gameDuration = Timer;
            //get powerUp image
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Powerup.png");
            isActive = false;
            _born = timestamp;

            //random duration on field
            Random rnd = new Random();
            lifespan = rnd.Next(1, 13);

            Random rnd2 = new Random();
            playerDuration = rnd2.Next(2, 6);


        }

    }
}
