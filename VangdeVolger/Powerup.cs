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
        bool isActive;
        //duration on the player
        int playerDuration;
        //powerUp duration
        int activeUntill;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="givenLife">Int that assigns the time that the powerup will be alive</param>
        public Powerup(int givenLife, int gameDuration)
        {
            //get powerUp image
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Powerup.png");
            isActive = false;
            born = gameDuration;
            activeUntill = givenLife;
            
        }
    }
}
