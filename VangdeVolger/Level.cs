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
