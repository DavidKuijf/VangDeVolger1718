using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Player : Movable
    {
        private int _health;
        protected int _speed;
        private int x;
        private int y;

        override public void Move(Directions direction)
        {
            //are we walking to the edge of the map
            if (!(_location.neighbor[(int)direction] == null))
            {
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains == null)
                {
                    // set the gametile in the specified direction equal to this object.
                    _location.neighbor[(int)direction].contains = this;
                    _location.contains = null;
                    // set the location of this object to the tile in the sepcified direction.
                    _location = _location.neighbor[(int)direction];


                }
                //if the neigbour in the direction is a Box
                else if (_location.neighbor[(int)direction].contains is Box)
                {
                    //push that box
                    Push((Box)_location.neighbor[(int)direction].contains, direction);
                }
                // if the neighbour in that direction 
                else if (_location.neighbor[(int)direction].contains is Powerup)
                {
                    // pick that powerup up
                    PickUp(direction);
                }
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="direction"></param>
        void Push(Box target, Directions direction)
        {
            //push the specified box
            target.Push(target, direction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        void PickUp(Directions direction)
        {
            Powerup powerup = (Powerup)_location.neighbor[(int)direction].contains;
            _location.neighbor[(int)direction].contains = null;
            powerup.isActive = true;

            //while (powerup.countDown())
            //{
            //    this._speed = this._speed * 2;
            //}
            //this._speed = 1;

        }

        void Die()
        {

        }


        public Player()
        {
            _health = 10;
            _speed = 1;

            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");

            /*level.levelLayout[level.playerX, level.playerY].neighbor = new GameField[] { level.levelLayout[level.playerX, level.playerY - 1], level.levelLayout[level.playerX + 1, level.playerY], level.levelLayout[level.playerX, level.playerY + 1], level.levelLayout[level.playerX - 1, level.playerY] };

            // Debug printing
            for (int i = 0; i < level.levelLayout[level.playerX, level.playerY].neighbor.Length; i++)
            {
                if (level.levelLayout[level.playerX, level.playerY].neighbor[i].contains != null) Console.WriteLine(level.levelLayout[level.playerX, level.playerY].neighbor[i].contains.ToString());
            }*/
        }

    }
}