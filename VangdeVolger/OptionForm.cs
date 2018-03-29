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
            if (((size !=  0)) && ((size <= 50))) 
            {
                _level.SetSize(size);
                _level.Generate(_parent._randomStartingPos);
            }

            // Only set the chances if it's been filled in and less than the maximum.
            if ((boxChance != 0) && (wallChance != 0) && (powerUpChance != 0) && (boxChance + wallChance + powerUpChance) < 100)
            {
                _level.SetBoxChance(boxChance);
                _level.SetWallChance(wallChance);
                _level.SetPowerUpChance(powerUpChance);
                _level.Generate(_parent._randomStartingPos);
            }

            Close();
        }

        public OptionForm(Level level, FormMainScreen ParentForm, bool randomPos)
        {
            InitializeComponent();
            
            _level = level;
            _parent = ParentForm;
            radioButton1.Checked = randomPos;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _parent._randomStartingPos = !_parent._randomStartingPos;
        }
    }
}
