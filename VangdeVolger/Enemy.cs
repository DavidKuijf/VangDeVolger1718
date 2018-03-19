using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Enemy : Movable
    {
        Random random = new Random();

        private void Decide(GameField[] level)
        {
            Movable.Directions direction = (Movable.Directions)random.Next(5);
            Move(direction);
        }

        public Enemy()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Enemy.png");
        }
    }
}
