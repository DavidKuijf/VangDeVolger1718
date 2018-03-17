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

        public void Move(Directions direction)
        {
            //check if the field in the specified direction is a wall.
            if (!(_location.neighbor[(int)direction].contains is Wall)) 
            {
                // set the gametile in the specified direction equal to this object.
                _location.neighbor[(int)direction].contains = this;  
                _location.contains = null;
                // set the location of this object to the tile in the specified direction.
                _location = this._location.neighbor[(int)direction]; 


            }

        }
        
        protected Movable()
        {
           
        }

        
    }
}
