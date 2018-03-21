using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangdeVolger
{
    class Enemy : Movable
    {
        Random random = new Random();
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CheckWin()
        {
            int winCount = 0;

            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (!(_location.neighbor[i] == null))
                {
                    //check if the field in the specified direction is empty
                    if (_location.neighbor[i].contains != null && !(_location.neighbor[i].contains is Player))
                    {
                        winCount++;
                    }
                }
                else
                {
                    winCount++;
                }
            }

            if (winCount == _location.neighbor.Length)
                return true;
            else
                return false;
            
        }

        public bool Decide()
        {
            Movable.Directions direction = (Movable.Directions)random.Next(4);

            while (!CheckDirection(direction) && !CheckWin())
            {
                direction = (Movable.Directions)random.Next(4);
                if (_location.neighbor[(int)direction].contains is Player)
                {
                    
                }


            }
            Move(direction);

            return CheckWin();
                
        }

        public Enemy()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Enemy.png");
        }
    }
}
