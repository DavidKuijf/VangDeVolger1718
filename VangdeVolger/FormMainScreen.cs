using System;
using System.Windows.Forms;

namespace VangdeVolger
{
    public partial class FormMainScreen : Form
    {
        Timer gameTimer = new Timer();

        private Player _playerOne;
        private Enemy _enemy;
        private Level _level;

        public FormMainScreen()
        {

            InitializeComponent();

            _playerOne = new Player();
            _enemy = new Enemy();
            _level = new Level(_playerOne, _enemy, gameTimer);
            _level.Generate(_level);

            _level.Draw(pictureBoxMain);

        }

        

        private void Draw(object sender, PaintEventArgs e)
        {
            _level.gameTimer.gameDuration++;
            lblTime.Text = _level.gameTimer.gameDuration.ToString();
            
            Application.Idle += delegate { Invalidate(); };
        }

       

        private void FormMainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            

            switch (e.KeyCode)
            {
                case Keys.W:
                    _playerOne.Move(Movable.Directions.Up);
                    break;
                case Keys.A:
                    _playerOne.Move(Movable.Directions.Left);
                    break;
                case Keys.S:
                    _playerOne.Move(Movable.Directions.Down);
                    break;
                case Keys.D:
                    _playerOne.Move(Movable.Directions.Right);
                    break;
            }

            _level.Draw(pictureBoxMain);

        }

        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            _level.Generate(_level);
            _level.Draw(pictureBoxMain);

        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void OptionpictureBox_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm(_level);
            optionForm.Show();
        }
    }
}
