using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Movable : GameObject
    {
        protected GameField location;
        protected int _speed ;
        public enum Directions { Up, Right, Down, Left };
        /*
         *     0
         *  3  2  1
         */
        public void GetLocation(GameField ObjectLocation)
        {
            this.location = ObjectLocation;
        }
        public void Move(int Direction)
        {
            if (!(this.location.neighbor[Direction].contains is Wall))
            {
                this.location.neighbor[Direction].contains = this;
                this.location = this.location.neighbor[Direction];

            }

        }
        
        protected Movable()
        {
            _speed = 1;
        }

        
    }
}
