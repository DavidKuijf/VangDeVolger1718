using System.IO;
using System.Reflection;


namespace VangdeVolger
{
    class Box : Movable
    {
        public bool Push(Box Target, Directions direction)
        {
            bool success = false;
            if (!(Target._location.neighbor[(int)direction] == null))                                           //check if we are trying to push the box off the map
            {

                if (Target._location.neighbor[(int)direction].contains is Box)                                  //Check if the field we are trying to push to contains another box
                {
                    success = Target.Push((Box)Target._location.neighbor[(int)direction].contains, direction);  // if it does push that box
                }
                else if (Target._location.neighbor[(int)direction].contains == null)                            //check if the square is empty
                {
                    success = true;                                                                             //if it is set success to true
                }

                if (success)                                                                                    
                {
                    Target.Move(direction);                                                                     //move the box in the specified direction
                }
                return success;                                                                                 
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

