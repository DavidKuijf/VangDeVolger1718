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

        public void Draw(Image toBeDrawn, Point location, PictureBox Frame)
        {
           
                _buffer = new Bitmap(_bufferSize.Width, _bufferSize.Height);

           
                using (Graphics graphics = Graphics.FromImage(_buffer))
                {

                    graphics.DrawImage(toBeDrawn, location.X, location.Y, _image.Size.Width, _image.Size.Height);
                }

                Frame.Image = _buffer;
           
            
        }

        public Level()
        {
            _bufferSize = new Size(500, 500);
            _buffer = new Bitmap(_bufferSize.Width, _bufferSize.Height);
        }
    }
}
