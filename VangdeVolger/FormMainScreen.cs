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
        DialogResult loseBox;

        private bool _paused;
        private bool _lost = false;
        private bool _won = true;

        public enum Difficulties { Rogue, Hard, Medium, Easy };
        public Difficulties Difficulty = Difficulties.Rogue;

        public FormMainScreen()
        {

            InitializeComponent();

            _playerOne = new Player();
            _enemy = new Enemy();
            _level = new Level(_playerOne, _enemy);
            
            _level.Generate();
            _level.Draw(pictureBoxMain);


        }

        

        private void Draw(object sender, PaintEventArgs e)
        {
            
            Application.Idle += delegate { Invalidate(); };
        }

       

        private void FormMainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (!_paused)
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
                        //peasant movement
                    case Keys.Up:
                        _playerOne.Move(Movable.Directions.Up);
                        break;
                    case Keys.Down:
                        _playerOne.Move(Movable.Directions.Down);
                        break;
                    case Keys.Left:
                        _playerOne.Move(Movable.Directions.Left);
                        break;
                    case Keys.Right:
                        _playerOne.Move(Movable.Directions.Right);
                        break;
                }


                if (Difficulty == Difficulties.Rogue)
                {
                    _enemy.Decide(out _won,out _lost);
                    _level.Draw(pictureBoxMain);
                    if (_won)
                    {
                        winBox = MessageBox.Show("Winner, winner chicken dinner...", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _paused = true;
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
            _playerOne = new Player();
            _level = new Level(_playerOne, _enemy);
            _level.Generate();
            _time = 0;

        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {
            if (!_paused)
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

        private void OptionpictureBox_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm(_level,this);
            optionForm.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
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
           
            //Console.WriteLine(i);
            if (Difficulty != Difficulties.Rogue)
            {
                if (_time % (int)Difficulty == 0)
                {
                    _enemy.Decide(out _won, out _lost);
                    _level.Draw(pictureBoxMain);
                    if (_won)
                    {                     
                        winBox = MessageBox.Show("Winner, winner chicken dinner...", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _paused = true;
                    }
                    if (_lost)
                    {
                        Lose();
                    }
                }
            }
            
        }

        public void Lose()
        {
            _playerOne = null;
            _paused = true;
            loseBox = MessageBox.Show("You lose...", "You lose!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            if (loseBox == DialogResult.Retry)
            {
                _playerOne = new Player();
                _level = new Level(_playerOne, _enemy);
                _time = 0;
            }
        }

        private void FormMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
