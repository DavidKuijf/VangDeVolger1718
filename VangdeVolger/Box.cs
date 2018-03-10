using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Box : Dynamic
    {
        void Pushed()
        {

        }
        Box()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");
        }
    }
}

