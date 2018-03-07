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
    public partial class Form1 : Form
    {
        Timer gameTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            gameTimer.gameDuration++;
            lblTime.Text = gameTimer.gameDuration.ToString();
            Application.Idle += delegate { Invalidate(); };
        }
    }
}
