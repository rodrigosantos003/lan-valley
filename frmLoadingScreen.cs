using System;
using System.Drawing;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen()
        {
            InitializeComponent();
            createLabelVersion();
        }

        //defualt values for progress bar
        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            loadingBar.Value = 0;
            loadingBar.Minimum = 0;
            loadingBar.Maximum = 100;
        }

        //build a label with app version
        private void createLabelVersion()
        {
            Label lbl = new Label();
            Controls.Add(lbl);
            lbl.Name = "lbl_Version";
            lbl.Text = "Versao 1.0.0";
            lbl.Font = new Font("ROG Fonts", 14);
            lbl.AutoSize = true;
            lbl.Location = new Point(467, 370);
            lbl.BringToFront();
        }

        //timer to grow progress bar
        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if (loadingBar.Value < 100)
            {
                lbl_Percentage.Text = loadingBar.Value.ToString() + "%"; //show percentage of the progress bar
                loadingBar.Value += 2; //increments 2 to the value of teh progress bar
                loadingBar.Update(); //redesigns the progress bar
            }
            else
            {
                //open the new form - login
                loadingTimer.Enabled = false;
                loadingBar.Enabled = false;
                frmLogin login = new frmLogin();
                Hide();
                login.Show();
            }
        }
    }
}
