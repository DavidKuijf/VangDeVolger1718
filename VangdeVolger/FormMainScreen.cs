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
        
        Player player1 = new Player();
        Level level1 = new Level();

        public FormMainScreen()
        {
            InitializeComponent();
            level1.Generate();
            level1.Draw(pictureBoxMain);
        }

        

        private void Draw(object sender, PaintEventArgs e)
        {
            _level.gameTimer._gameDuration++;
            lblTime.Text = _level.gameTimer._gameDuration.ToString();

            Application.Idle += delegate { Invalidate(); };
        }

       

        private void FormMainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player1.Move((int)Movable.Directions.Up);
                    break;
                case Keys.A:
                    player1.Move((int)Movable.Directions.Left);
                    break;
                case Keys.S:
                    player1.Move((int)Movable.Directions.Down);
                    break;
                case Keys.D:
                    player1.Move((int)Movable.Directions.Right);
                    break;
            }
            level1.Draw(pictureBoxMain);
            
        }
    }
}
