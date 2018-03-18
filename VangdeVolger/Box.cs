using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Box : Movable
    {
        public bool Push(Box Target, Directions direction)
        {
            bool success = false;

            if (Target._location.neighbor[(int)direction].contains is Box)
            {
                success = Target.Push((Box)Target._location.neighbor[(int)direction].contains, direction);
            }
            else if (Target._location.neighbor[(int)direction].contains == null)
            {
                success = true;
            }

            if (success)
            {
                Target.Move(direction);
            }
            return success;
        }

        public Box(GameField location)
        {
            _image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Box.png");
            _location = location;
        }
    }
}

