using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace VangdeVolger
{
    class Player : Movable
    {
       
        public int powerDuration;

        /// <summary>
        /// This function checks what is in the specified neigbouring square and then attempts to move there if possible
        /// </summary>
        /// <param name="direction"></param>
        override public void Move(Directions direction)
        {
            //Check if you are walking to the edge of the map
            if (_location.neighbor[(int)direction] != null)
            {
              
                
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
                    Powerup reachedUp = (Powerup)_location.neighbor[(int)direction].contains;
                    // pick that powerup up
                    PickUp(direction, reachedUp.playerDuration);

                }
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="direction"></param>
        private void Push(Box target, Directions direction)
        {
            //push the specified box
            target.Push(target, direction);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="duration"></param>
        void PickUp(Directions direction, int duration)
        {

            Powerup powerup = (Powerup)_location.neighbor[(int)direction].contains;
            _location.neighbor[(int)direction].contains = null;
            powerup.isActive = true;
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\PowerPlayer.png");
            this.powerDuration = duration;
        }

        public void LoosePowers()
        {

            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");

        }

        public void TickPowerup()
        {
            this.powerDuration -= 1;
        }

        public Player()
        {
           
           
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");

          
        }

    }
}