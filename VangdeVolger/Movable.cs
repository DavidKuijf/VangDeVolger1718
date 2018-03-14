using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Movable : GameObject
    {
        protected int _speed ;
        public enum Directions { Up, Right, Down, Left };
        /*
         *     0
         *  3  2  1
         */

        public void Move(int Direction)
        {
            switch (Direction)
            {
                case (int)Directions.Up:
                    if (!(false))
                    {
                        // -= _speed;
                    }
                    break;
                case (int)Directions.Left:
                    if (!(false))
                    {
                        // -= _speed;
                    }
                    break;
                case (int)Directions.Down:
                    if (!(false))
                    {
                        //+= _speed;
                    }
                   
                    break;
                case (int)Directions.Right:
                    if (!(false))
                    {
                         //+= _speed;
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
