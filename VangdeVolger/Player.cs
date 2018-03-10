using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Player : Dynamic
    {
        private int health = 10;

        void Push()
        {

        }

        void PickUp()
        {

        }

        void Die()
        {

        }

        public Player()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");
        }
    }
}
