using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmSuporte : Form
    {
        public frmSuporte()
        {
            InitializeComponent();
        }

        //button click event -> check which supoort option user clicks
        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            switch (button.Name)
            {
                case "btn_Site":
                    Process.Start("https://fsdevapps.netlify.app");
                    break;

                case "btn_Email":
                    Process.Start("mailto:fs.devapps@gmail.com");
                    break;

                case "btn_Instagram":
                    Process.Start("https://instagram.com/fs_devapps");
                    break;

                case "btn_Facebook":
                    Process.Start("https://facebook.com/fsdevapps");
                    break;
            }
        }

        //tool strip button click event -> close current form
        private void tsb_Back_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Hide();
            login.Show();
            Close();
        }

        private void frmSuporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
