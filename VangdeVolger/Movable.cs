using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    abstract class Movable : GameObject
    {
        
        
        public enum Directions { Up, Right, Down, Left };
        /*
         *     0
         *  3  2  1
         */

        /// <summary>
        /// This function checks what is in the specified neigbouring square and then attempts to move there if possible
        /// </summary>
        /// <param name="direction"></param>
        public virtual void Move(Directions direction)
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
            }
        }

        /// <summary>
        /// Check specified direction to see if it is empty or not.
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        protected virtual bool CheckDirection(Directions direction)
        {
            if (!(_location.neighbor[(int)direction] == null))
            {
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains == null)
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
