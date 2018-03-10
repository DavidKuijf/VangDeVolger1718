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

        object[,] levelLayout = new object[50,50];
        int sizeX = 50;
        int sizeY = 50;

        void Read()
        {

        }

        void Generate()
        {
            // Booleans to track if player and enemy have been placed yet.
            bool _playerPlaced = false; 
            bool _enemyPlaced = false;

            // Iterate over 2D array levelLayout.
            for (int x = 0; x < levelLayout.Length; x++)
            {
                for (int y = 0; y < levelLayout.Length; y++)
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

                        if (percentChance < 10)
                        {
                            levelLayout[x, y] = new Wall();
                        }
                        if (percentChance > 10 && percentChance < 20)
                        {
                            levelLayout[x, y] = new Box();
                        }
                        // Player placement. Needs change to guarantee that the player gets placed.
                        if (percentChance > 20 && percentChance < 30 && !_playerPlaced)
                        {
                            levelLayout[x, y] = new Player();
                            _playerPlaced = true;
                        }
                        // Enemy placement. Needs change to guarantee that the enemy gets placed.
                        if (percentChance > 30 && percentChance < 40 && !_enemyPlaced)
                        {
                            levelLayout[x, y] = new Enemy();
                            _enemyPlaced = false;
                        }
                        if (percentChance > 40 && percentChance < 50)
                        {
                            levelLayout[x, y] = new Powerup();
                        }
                        if (percentChance > 50)
                        {
                            levelLayout[x, y] = 0;
                        }
                    }
                }
            }
        }

        public void Draw(Image toBeDrawn, Point location, PictureBox Frame) //takes an image a place and a place to draw and then draws that image
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
