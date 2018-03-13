using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Powerup : Unmovable
    {
        int age = 0;
        bool isActive = false;
        int duration;

        public Powerup()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Powerup.png");
        }
    }
}
