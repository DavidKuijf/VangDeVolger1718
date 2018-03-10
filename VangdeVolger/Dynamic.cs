using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Dynamic : Object
    {
        protected int _speed = 10;
        public enum Directions { Up, Right, Down, Left };

        public void Move(int Direction)
        {
            switch (Direction)
            {
                case 0:
                    if (!(_position.Y - _speed < 0))
                    {
                        _position.Y -= _speed;
                    }
                    break;
                case 3:
                    if (!(_position.X - _speed < 0))
                    {
                        _position.X -= _speed;
                    }
                    break;
                case 2:
                    if (!(_position.Y + _speed > 499))
                    {
                        _position.Y += _speed;
                    }
                   
                    break;
                case 1:
                    if (!(_position.X + _speed > 499))
                    {
                        _position.X += _speed;
                    }
                    break;
            }
           
        }
    }
}
