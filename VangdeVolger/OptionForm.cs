﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangdeVolger
{
    partial class OptionForm : Form
    {
        private Level _level;
        private FormMainScreen _parent;

     
        public OptionForm(Level level, FormMainScreen ParentForm, bool randomPos)
        {

            InitializeComponent();
            
            _level = level;
            _parent = ParentForm;
            RandomStartingPostitionRadioButton.Checked = randomPos;

            //Position the optionScreen in the middle of the parent for aesthetics
            Location = new Point((_parent.Location.X) + (_parent.Width / 2) - (Width/2), (_parent.Location.Y) + (_parent.Height / 2)- (Height/2));


            //Prepare the custom Font
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\8bitfont.TTF"));
            Font bits = new Font(pfc.Families[0], 8);


            //Set all the things to custom font
            LevelSizeLabel.Font = bits;
            lblBoxPercent.Font = bits;
            lblPowerUpPercent.Font = bits;
            lblWallPercent.Font = bits;
            DifficultylevelLabel.Font = bits;
            RandomStartingPostitionRadioButton.Font = bits;
            DifficultyListBox.Font = bits;



        }

        private void RandomStrartingPositionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _parent.randomStartingPos = !_parent.randomStartingPos;
        }

      

        private void ApplyPictureBox_Click(object sender, EventArgs e)
        {
            int size = 0;
            int boxChance = 0;
            int wallChance = 0;
            int powerUpChance = 0;

            Int32.TryParse(LevelSizeTextbox.Text, out size);
            Int32.TryParse(tbBoxPercent.Text, out boxChance);
            Int32.TryParse(tbWallPercent.Text, out wallChance);
            Int32.TryParse(tbPowerUpPercent.Text, out powerUpChance);

            _parent.Difficulty = (FormMainScreen.Difficulties)DifficultyListBox.SelectedIndex;

            // Only set the size if it's been filled in and less than the maximum.
            if (((size != 0)) && ((size <= 50)))
            {
                _level.SetSize(size);
                _level.Generate(_parent.randomStartingPos);
            }

            // Only set the chances if it's been filled in and less than the maximum.
            if ((boxChance + wallChance + powerUpChance) < 100)
            {
                _level.SetGenertionChances(wallChance, boxChance, powerUpChance);
                _level.Generate(_parent.randomStartingPos);
            }
            _parent.PausePlay(false);
            Close();
        }

        private void CancelPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Textbox_Enter(object sender, EventArgs e)
        {
            if (sender == LevelSizeTextbox)
            {
                ToolTip.Show("Any value between 0 and 50 though we reccomend 10-30", LevelSizeTextbox);
            }
            else
            {                 
                ToolTip.Show("These values combined must not be more than 100%", (IWin32Window)sender);
            }
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            ToolTip.Hide((IWin32Window)sender);
        }
    }
}
