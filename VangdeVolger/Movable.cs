using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    abstract class Movable : GameObject
    {
        protected GameField _location;
        protected int _speed ;
        public enum Directions { Up, Right, Down, Left };
        /*
         *     0
         *  3  2  1
         */

         /// <summary>
         /// A way to set the location parameter of the Gameobject 
         /// </summary>
         /// <param name="ObjectLocation"></param>
        public void SetLocation(GameField ObjectLocation)
        {
            this._location = ObjectLocation;
        }

        private void Kill()
        {
            Console.WriteLine("KILL");
        }

        /// <summary>
        /// This function checks what is in the specified neigbouring square and then attempts to move there if possible
        /// </summary>
        /// <param name="direction"></param>
        virtual public void Move(Directions direction)
        {
            //Check if we are trying to move to the edge of the map
            if (!(_location.neighbor[(int)direction] == null))
            {
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains == null)
                {
                    // set the gametile in the specified direction equal to this object.
                    _location.neighbor[(int)direction].contains = this;
                    //Set the square we come from to null
                    _location.contains = null;
                    // set the location of this object to the tile in the sepcified direction.
                    _location = _location.neighbor[(int)direction];
                }
                else if (_location.neighbor[(int)direction].contains is Player)
                {
                    Kill();
                }
            }
        }

        /// <summary>
        /// Check specified direction to see if it is empty or not.
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        protected bool CheckDirection(Directions direction)
        {

            if (!(_location.neighbor[(int)direction] == null))
            {
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains == null || _location.neighbor[(int)direction].contains is Player)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
