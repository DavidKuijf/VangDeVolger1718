using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Player : Movable
    {
        private int _health;
        private int _speed;

        private void move(int direction)
        {


            if (direction == (int)Movable.Directions.Up)
            {

            }
        }

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
            _health = 10;
            _speed = 1;
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");

            levelLayout[playerX, playerY].neighbor = new GameField[] { levelLayout[playerX, playerY - 1], levelLayout[playerX + 1, playerY], levelLayout[playerX, playerY + 1], levelLayout[playerX - 1, playerY] };
        }
    }
}