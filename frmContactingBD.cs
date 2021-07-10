using System;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmContactingBD : Form
    {
        public frmContactingBD()
        {
            InitializeComponent();
        }

        private void frmContactingBD_Load(object sender, EventArgs e)
        {
            //default values for progress bar
            contactingBar.Value = 0;
            contactingBar.Minimum = 0;
            contactingBar.Maximum = 100;
        }

        //timer that increases progress bar
        private void contactingTimer_Tick(object sender, EventArgs e)
        {
            if (contactingBar.Value < 100)
            {
                contactingBar.Value += 2; //increments 2 to the progress bar value
                contactingBar.Update(); //redesigns progress bar
            }
            else
            {
                Close();
            }
        }
    }
}
