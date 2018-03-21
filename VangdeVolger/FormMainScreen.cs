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

        private int _time;
        DialogResult winBox;

        public enum Difficulties { Rogue, Hard, Medium, Easy };
        Difficulties Difficulty = Difficulties.Rogue;

        public FormMainScreen()
        {

            InitializeComponent();

            _playerOne = new Player();
            _enemy = new Enemy();
            _level = new Level(_playerOne, _enemy);
            _level.Generate(_level);
            _level.Draw(pictureBoxMain);


        }

        

        private void Draw(object sender, PaintEventArgs e)
        {
            
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
            if (Difficulty == Difficulties.Rogue)
            {
                bool win = _enemy.Decide();
                _level.Draw(pictureBoxMain);
                if (win)
                {
                    winBox = MessageBox.Show("Winner, winner chicken dinner...", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           

        }

        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            _level.Generate(_level);
            _level.Draw(pictureBoxMain);
            _time = 0;

        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void OptionpictureBox_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm(_level,this);
            optionForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _time++;
            TimeLabel.Text = _time.ToString();
            if (Difficulty != Difficulties.Rogue)
            {
                if (_time % (int)Difficulty == 0)
                {
                    bool win = _enemy.Decide();
                    _level.Draw(pictureBoxMain);
                    if (win)
                    {
                        winBox = MessageBox.Show("Winner, winner chicken dinner...", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }
    }
}
