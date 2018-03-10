using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangdeVolger
{
    public partial class FormMainScreen : Form
    {
        Timer gameTimer = new Timer();
        private Image _image;
        private Bitmap _buffer;
        private int _speed;
        private Size _bufferSize;
        Player player1 = new Player();

        public FormMainScreen()
        {
            InitializeComponent();
            
            
            
            
           
            _bufferSize = new Size(500, 500);
            _buffer = new Bitmap(_bufferSize.Width, _bufferSize.Height);

            Draw();
        }

        private void Draw()

        {
            _buffer = new Bitmap(_bufferSize.Width, _bufferSize.Height);

            using (Graphics graphics = Graphics.FromImage(_buffer))
            {
                _image = Image.FromFile(player1._image);
                graphics.DrawImage(_image, player1._position.X, player1._position.Y, _image.Size.Width, _image.Size.Height);
            }

            pictureBoxMain.Image = _buffer;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            gameTimer._gameDuration++;
            lblTime.Text = gameTimer._gameDuration.ToString();
            Application.Idle += delegate { Invalidate(); };
        }

       

        private void FormMainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player1.Move((int)Dynamic.Directions.Up);
                    break;
                case Keys.A:
                    player1.Move((int)Dynamic.Directions.Left);
                    break;
                case Keys.S:
                    player1.Move((int)Dynamic.Directions.Down);
                    break;
                case Keys.D:
                    player1.Move((int)Dynamic.Directions.Right);
                    break;
            }
            //After handling the input redraw the screen
            Draw();
        }
    }
}
