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
        private int born;
        //is active on player?
        public bool isActive;
        //duration on the player
        public int playerDuration;
        //powerUp duration
        public int activeUntill;

        //private Timer gameDuration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="givenLife">Int that assigns the time that the powerup will be alive</param>
        /// <param name="gameDuration">Timestamp of creation from Timer class</param>
        public Powerup(int givenLife, int timer)
        {
            //gameDuration = Timer;
            //get powerUp image
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Powerup.png");
            isActive = false;
            born = timer;
            activeUntill = givenLife;

            //random number for duration
            Random rnd = new Random();
            activeUntill = rnd.Next(2, 5);

        }

        public void countDown()
        {

        }




    }
}
