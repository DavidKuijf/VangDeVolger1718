﻿using System;
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

        private Player _playerOne;
        private Enemy _enemy;
        private Level _level;

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
            //_level.gameTimer._gameDuration++;
            //lblTime.Text = _level.gameTimer._gameDuration.ToString();

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
