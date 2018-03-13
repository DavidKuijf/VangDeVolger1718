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
    class GameObject : Level
    {
        
        public string _image { get; set; }
        protected GameObject()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Box.png");
        }
    }
}
