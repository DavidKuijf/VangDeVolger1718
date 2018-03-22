using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace VangdeVolger
{
    class Player : Movable
    {
        private int _health;
        protected int _speed;


        /// <summary>
        /// This function checks what is in the specified neigbouring square and then attempts to move there if possible
        /// </summary>
        /// <param name="direction"></param>
        override public void Move(Directions direction)
        {
            //Check if you are walking to the edge of the map
            if (!(_location.neighbor[(int)direction] == null))
            {
                //for all 4 directions around players
                for (int i = 0; i < _location.neighbor.Length; i++)
                {
                   //check if that direction is not NULL && the location is enemy
                   if (_location.neighbor[i] != null && _location.neighbor[i].contains is Enemy)
                    {
                        //player die if direction contains enemy
                        Die();

                    }
                }
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains == null)
                {
                    // set the gametile in the specified direction equal to this object.
                    _location.neighbor[(int)direction].contains = this;
                    //Set contains the square we are coming from to null
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
                // if the neighbour in that direction is a Powerup
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
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\PowerPlayer.png");

        }

        void Die()
        {
            //stop the game
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