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

        public void SetLocation(GameField ObjectLocation)
        {
            this._location = ObjectLocation;
        }

        virtual public void Move(Directions direction)
        {
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
            }
        }

        protected bool CheckDirection(Directions direction)
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

        protected Movable()
        {
           
        }

        
    }
}
