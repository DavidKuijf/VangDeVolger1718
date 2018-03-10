using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Level
    {
        object[,] levelLayout = new object[50,50];
        int sizeX = 50;
        int sizeY = 50;

        void Read()
        {

        }

        void Generate()
        {
            for (int x = 0; x < levelLayout.Length; x++)
            {
                for (int y = 0; y < levelLayout.Length; y++)
                {
                    if (x == 0 || y == 0 || x == sizeX || y == sizeY)
                    {
                        levelLayout[x, y] = new Wall();
                    }
                }
            }
        }

        void Draw()
        {

        }
    }
}
