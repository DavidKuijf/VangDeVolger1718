using System;
using System.IO;
using System.Reflection;


namespace VangdeVolger
{
    class Enemy : Movable
    {
        Random random = new Random();

        public void Decide(GameField[] level)
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
