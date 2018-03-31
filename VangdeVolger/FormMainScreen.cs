using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace VangdeVolger
{
    public partial class FormMainScreen : Form
    {
        private Timer gameTimer = new Timer();

        private Player _playerOne;
        private Enemy _enemy;
        private Level _level;

        private int _time;

        private DialogResult _winBox;
        private DialogResult _loseBox;

        private bool _paused;
        private bool _lost;
        private bool _won;
        private bool _menuVisible;
        public bool randomStartingPos;

        public enum Difficulties { Rogue, Hard, Medium, Easy };
        public Difficulties Difficulty;
        SoundPlayer simpleSound;

        private void Draw(object sender, PaintEventArgs e)
        {

            Application.Idle += delegate { Invalidate(); };
        }



        private void FormMainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!_paused)
            {
                // Read input and move the player.
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        _playerOne.Move(Movable.Directions.Up);
                        break;

                    case Keys.S:
                    case Keys.Down:
                        _playerOne.Move(Movable.Directions.Down);

                        break;


                    case Keys.A:
                    case Keys.Left:
                        _playerOne.Move(Movable.Directions.Left);
                        break;

                    case Keys.D:
                    case Keys.Right:
                        _playerOne.Move(Movable.Directions.Right);
                        break;
                    
                }
                if (e.KeyCode == Keys.Escape)
                {
                    
                    _menuVisible = !_menuVisible;
                    ResetPictureBox.Visible = _menuVisible;
                    PausePictureBox.Visible = _menuVisible;
                    OptionPictureBox.Visible = _menuVisible;
                    QuitPictureBox.Visible = _menuVisible;
                    
                }
                if (Difficulty == Difficulties.Rogue)
                {
                    // set won, lost and draw the screen.
                    _enemy.Decide(out _won, out _lost);

                    _level.Draw(pictureBoxMain);

                    if (_won)
                    {
                        Win();
                    }

                    if (_lost)
                    {
                        Lose();
                    }
                }

                _level.Draw(pictureBoxMain);
            }
        }

        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void PausePlay(bool pause)
        {
            if (pause)
            {
                Timer.Stop();
                _paused = true;
                
            }

            else
            {
                Timer.Start();
                _paused = false;
               
            }
        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {
            if (!_paused)
            {
                PausePlay(true);
            }

            else
            {
                PausePlay(false);
            }
        }

        private void OptionpictureBox_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm(_level, this, randomStartingPos);
            optionForm.Show();
        }

        private void PictureBoxQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_playerOne != null)
            {
                if (_playerOne.powerDuration <= 0)
                {
                    _playerOne.LoosePowers();
                    Timer.Interval = 10;
                }
                else if (_playerOne.powerDuration > 0)
                {
                    Timer.Interval = 20;
                    _playerOne.TickPowerup();
                }

               
                
                 _time++;
                 TimeLabel.Text = _time.ToString();
                

                for (int i = 0; i < _level.powerupList.Count; i++)
                {
                    if (_level.powerupList[i].Age())
                    {
                        _level.powerupList[i]._location.contains = null;
                        _level.powerupList.Remove(_level.powerupList[i]);
                    }
                }
            }

            if (Difficulty != Difficulties.Rogue)
            {
                if (_time % ((int)Difficulty*33) == 0 && !_paused)
                {
                    _enemy.Decide(out _won, out _lost);

                    _level.Draw(pictureBoxMain);
                    
                    if (_won)
                    {
                        Win();
                    }

                    if (_lost)
                    {
                        Lose();
                    }
                }
            }
        }

        private void Lose()
        {
            _playerOne = null;
            _paused = true;

            _loseBox = MessageBox.Show("You lose...", "You lose!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

            if (_loseBox == DialogResult.Retry)
            {
                Reset();
            }
            else
            {
                Reset();
            }
        }

        private void Win()
        {
            PausePlay(true);
            _winBox = MessageBox.Show("Winner, winner chicken dinner...", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (_winBox == DialogResult.OK)
            {
                Reset();
            }
        }

        private void Reset()
        {
            _playerOne = new Player();
            _level = new Level(_playerOne, _enemy);
            _level.Generate(randomStartingPos);
            _level.Draw(pictureBoxMain);
            PausePlay(false);
            _time = 0;
        }

        public FormMainScreen()
        {
            InitializeComponent();
           
            _playerOne = new Player();
            _enemy = new Enemy();
            _level = new Level(_playerOne, _enemy);

            _level.Generate(randomStartingPos);
            _level.Draw(pictureBoxMain);
            _menuVisible = false;
            _lost = false;
            _won = true;
            randomStartingPos = false;
            Difficulty = Difficulties.Medium;

            //8bit track
            simpleSound = new SoundPlayer(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\track8bit.wav"));
            simpleSound.PlayLooping();

            
        }

       
    }
}
