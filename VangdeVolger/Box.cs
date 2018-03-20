using System.IO;
using System.Reflection;


namespace VangdeVolger
{
    class Box : Movable
    {
        /// <summary>
        /// Push moves this box and calls to move any adjacent boxes in the specified direction it returns a bool depending on wether or not the box was sucessfully pushed
        /// </summary>
        /// <param name="Target"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Push(Box Target, Directions direction)
        {
            bool success = false;
            //check if we are trying to push the box off the map
            if (!(Target._location.neighbor[(int)direction] == null))                                           
            {
                //Check if the field we are trying to push to contains another box
                if (Target._location.neighbor[(int)direction].contains is Box)                                 
                {
                    // if it does push that box
                    success = Target.Push((Box)Target._location.neighbor[(int)direction].contains, direction);  
                }
                //check if the square is empty
                else if (Target._location.neighbor[(int)direction].contains == null)                            
                {
                    //if it is set success to true
                    success = true;                                                                           
                }

                if (success)                                                                                    
                {
                    //move the box in the specified direction
                    Target.Move(direction);                                                                   
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

