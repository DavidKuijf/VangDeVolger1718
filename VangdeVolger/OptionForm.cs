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
    partial class OptionForm : Form
    {
        private Level _level;
        private FormMainScreen _parent;

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int sizeX = 0;
            int sizeY = 0;

            int boxChance = 0;
            int wallChance = 0;
            int powerUpChance = 0;

            Int32.TryParse(LevelSizeTextboxX.Text, out sizeX);
            Int32.TryParse(LevelSizeTextboxY.Text, out sizeY);
            Int32.TryParse(tbBoxPercent.Text, out boxChance);
            Int32.TryParse(tbWallPercent.Text, out wallChance);
            Int32.TryParse(tbPowerUpPercent.Text, out powerUpChance);

            _parent.Difficulty = (FormMainScreen.Difficulties)DifficultyListBox.SelectedIndex;

            if ((sizeX != 0) && (sizeY != 0)) 
            {
                _level.SetSize(sizeX,sizeY);
                _level.Generate(_parent._randomStartingPos);
            }

            if ((boxChance != 0) && (wallChance != 0) && (powerUpChance != 0) && (boxChance + wallChance + powerUpChance) < 100)
            {
                _level.SetBoxChance(boxChance);
                _level.SetWallChance(wallChance);
                _level.SetPowerUpChance(powerUpChance);
                _level.Generate(_parent._randomStartingPos);
            }

            Close();

        }

        public OptionForm(Level level, FormMainScreen ParentForm)
        {
            InitializeComponent();
            _level = level;
            _parent = ParentForm;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _parent._randomStartingPos = !_parent._randomStartingPos;
        }
    }
}
