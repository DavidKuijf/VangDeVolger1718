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

        private Level _level = new Level();

        public FormMainScreen()
        {
            InitializeComponent();
            _level.Generate(_level);
            _level.Draw(pictureBoxMain);
        }

        

        private void Draw(object sender, PaintEventArgs e)
        {
            _level.gameTimer._gameDuration++;
            lblTime.Text = _level.gameTimer._gameDuration.ToString();

            Application.Idle += delegate { Invalidate(); };
        }

       

        private void FormMainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            /*switch (e.KeyCode)
            {
                case Keys.W:
                    player.Move((int)Movable.Directions.Up);
                    break;
                case Keys.A:
                    player.Move((int)Movable.Directions.Left);
                    break;
                case Keys.S:
                    player.Move((int)Movable.Directions.Down);
                    break;
                case Keys.D:
                    player.Move((int)Movable.Directions.Right);
                    break;
            }*/
            _level.Draw(pictureBoxMain);
            
        }
    }
}
