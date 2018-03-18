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
        public OptionForm(Level level)
        {
            InitializeComponent();
            _level = level;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _level.SetSize(Int32.Parse(LevelSizeTextboxX.Text), Int32.Parse(LevelSizeTextboxY.Text)) ;
        }
    }
}
