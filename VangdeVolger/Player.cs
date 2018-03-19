using System.IO;
using System.Reflection;


namespace VangdeVolger
{
    class Player : Movable
    {
        private int _health;
        private int _speed;
        private int x;
        private int y;

        override public void Move(Directions direction)
        {
            if (!(_location.neighbor[(int)direction] == null))              //are we walking to the edge of the map
            {
                if (_location.neighbor[(int)direction].contains == null) //check if the field in the specified direction is empty
                {

                    _location.neighbor[(int)direction].contains = this;  // set the gametile in the specified direction equal to this object.
                    _location.contains = null;
                    _location = _location.neighbor[(int)direction]; // set the location of this object to the tile in the sepcified direction.


                }
                else if (_location.neighbor[(int)direction].contains is Box)            //if the neigbour in the direction is a Box
                {
                    Push((Box)_location.neighbor[(int)direction].contains, direction);  //push that box
                }

                else if (_location.neighbor[(int)direction].contains is Powerup)        // if the neighbour in that direction 
                {
                    PickUp(direction);                                                           // pick that powerup up
                }
            }
            

        }
        void Push(Box target, Directions direction)                                 
        {
            target.Push(target , direction);                                       //push the specified box
        }

        void PickUp(Directions direction)
        {
            _location.neighbor[(int)direction].contains = null;
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