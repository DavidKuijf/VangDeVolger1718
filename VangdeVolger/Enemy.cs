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

        private void Kill(Directions direction)
        {
            _location.neighbor[(int)direction].contains = null;

        }

        private bool CheckPlayer(Directions direction)
        {
            if (_location.neighbor[(int)direction] != null)
            {
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains is Player)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }
        /// <summary>
        /// Decide first checks wheter there is a player in range to kill
        ///if there is it kills that player
        ///else it moves in a random direction
        ///if this is not possible it declares the player has won
        /// </summary>
        /// <param name="won"></param>
        /// <param name="lost"></param>
        /// <returns></returns>
        public bool Decide(out bool won, out bool lost)
        {

            won = false;
            lost = false;
            bool moved = false;

            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (CheckPlayer((Directions)i))
                {
                    Kill((Movable.Directions)i);
                    Move((Movable.Directions)i);
                    moved = true;
                    lost = true;
                    break;
                }
            }


            while (!moved && !CheckWin())
            {
                Directions direction = (Directions)random.Next(4);
                if (CheckDirection(direction) && !CheckWin() && !lost)
                {
                    Move(direction);
                    moved = true;
                    break;
                }


            }


            if (CheckWin())
            {
                won = true;
            }
        

            return CheckWin();
                
        }

        public Enemy()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Enemy.png");
        }
    }
}
