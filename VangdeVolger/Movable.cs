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
            switch (Direction)
            {
                case (int)Directions.Up:
                    if (!(false))
                    {
                        this.location.neighbor[0].contains = this;
                        this.location = this.location.neighbor[0];
                    }
                    break;
                case (int)Directions.Left:
                    if (!(false))
                    {
                        this.location.neighbor[3].contains = this;
                        this.location = this.location.neighbor[3];
                    }
                    break;
                case (int)Directions.Down:
                    if (!(false))
                    {
                        this.location.neighbor[2].contains = this;
                        this.location = this.location.neighbor[2];
                    }
                    break;
                case (int)Directions.Right:
                    if (!(false))
                    {
                        this.location.neighbor[1].contains = this;
                        this.location = this.location.neighbor[1];
                    }
                    break;
            }
           
        }
        
        protected Movable()
        {
            _speed = 1;
        }

        
    }
}
