using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    abstract class GameObject
    {
        public GameField _location;
        public string _image;

        public void SetLocation(GameField ObjectLocation)
        {
            this._location = ObjectLocation;
        }
    }
}
