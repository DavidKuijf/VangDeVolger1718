using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangdeVolger
{
    class Level
    {
        private Image _image;
        private Bitmap _buffer;
        private Size _bufferSize;
        private Random _random = new Random();

        int sizeX = 50;
        int sizeY = 50;

        Object[,] levelLayout = new Object[50, 50];

        void Read()
        {

        }

        public void Generate()
        {
            // Booleans to track if player and enemy have been placed yet.
            int playerX = _random.Next(1, 50);
            int playerY = _random.Next(1, 50);
            int enemyX = _random.Next(1, 50);
            int enemyY = _random.Next(1, 50);

            levelLayout[playerX, playerY] = new Player();
            levelLayout[enemyX, enemyY] = new Enemy();

            // Iterate over 2D array levelLayout.
            for (int x = 0; x < levelLayout.GetLength(0); x++)
            {
                for (int y = 0; y < levelLayout.GetLength(1); y++)
                {
                    // Assign the Wall object to the borders of the map.
                    if (x == 0 || y == 0 || x == sizeX || y == sizeY)
                    {
                        levelLayout[x, y] = new Wall();
                    }
                    else
                    {
                        // Generate a pseudo-random number to decide object placement.
                        int percentChance = _random.Next(100);

                        if (percentChance < 10 && levelLayout[x, y] == null)
                        {
                            levelLayout[x, y] = new Wall();
                        }
                        if (percentChance > 10 && percentChance < 20 && levelLayout[x, y] == null)
                        {
                            levelLayout[x, y] = new Box();
                        }
                        if (percentChance > 30 && percentChance < 40 && levelLayout[x, y] == null)
                        {
                            levelLayout[x, y] = new Powerup();
                        }
                        if (percentChance > 40 && levelLayout[x, y] == null)
                        {
                            levelLayout[x, y] = null;
                        }
                    }
                }
            }

            // DEBUG ARRAY CHECKING
            int rowLength = levelLayout.GetLength(0);
            int colLength = levelLayout.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", levelLayout[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        //takes an image a place and a place to draw and then draws that image
        public void Draw(Image toBeDrawn, Point location, PictureBox Frame)
        {
                //make a bitmap that we can draw to before displaying
                _buffer = new Bitmap(_bufferSize.Width, _bufferSize.Height);

                
                using (Graphics graphics = Graphics.FromImage(_buffer))
                {
                    //draw the actual image
                    graphics.DrawImage(toBeDrawn, location.X, location.Y, toBeDrawn.Size.Width, toBeDrawn.Size.Height);
                }
                //set the given picture box to the buffer
                Frame.Image = _buffer;
           
            
        }

        public Level()
        {
            //make sure out buffer is equal to the playingfield
            _bufferSize = new Size(500, 500);
        }
    }
}
