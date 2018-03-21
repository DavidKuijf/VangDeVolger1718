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
        public OptionForm(Level level, Form Parent)
        {
            InitializeComponent();
            _level = level;

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int sizeX = 0;
            int sizeY = 0;

            Int32.TryParse(LevelSizeTextboxX.Text, out sizeX);
            Int32.TryParse(LevelSizeTextboxY.Text, out sizeY);

            if ((sizeX != 0) && (sizeY)!= 0) 
            {
                _level.SetSize(sizeX,sizeY);
                _level.Generate(_level);
        
            }
            Close();

        }
    }
}
