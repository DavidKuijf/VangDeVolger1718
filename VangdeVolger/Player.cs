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
        private GameField location;
        private int health;
        private int speed;
        private int x;
        private int y;

        void Push()
        {

        }

        void PickUp()
        {

        }

        void Die()
        {

        }

        public Player(Level level, GameField playerlocation)
        {
            health = 10;
            speed = 1;
            this.location = playerlocation;
            

            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Player.png");

            /*level.levelLayout[level.playerX, level.playerY].neighbor = new GameField[] { level.levelLayout[level.playerX, level.playerY - 1], level.levelLayout[level.playerX + 1, level.playerY], level.levelLayout[level.playerX, level.playerY + 1], level.levelLayout[level.playerX - 1, level.playerY] };

            // Debug printing
            for (int i = 0; i < level.levelLayout[level.playerX, level.playerY].neighbor.Length; i++)
            {
                if (level.levelLayout[level.playerX, level.playerY].neighbor[i].contains != null) Console.WriteLine(level.levelLayout[level.playerX, level.playerY].neighbor[i].contains.ToString());
            }*/
        }
    }
}