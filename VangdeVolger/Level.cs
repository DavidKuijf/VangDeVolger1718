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

        object[,] levelLayout;
        int sizeX;
        int sizeY;

        void Read()
        {

        }

        void Generate()
        {

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
