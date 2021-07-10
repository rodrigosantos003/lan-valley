using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmLogin : Form
    {
        public static string setTextUser; //string to pass user to another form

        public frmLogin()
        {
            InitializeComponent();
        }

        //verifies login info on BD
        private void Login()
        {
            if (txt_User.Text != "" && txt_Pass.Text != "")
            {
                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"../..") + "\\BD_Sistema.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection sqlcon = new SqlConnection(cs);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Accounts WHERE Username = '" + txt_User.Text.Trim() + "' AND Password = '" + txt_Pass.Text.Trim() + "'", sqlcon);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                new frmContactingBD().ShowDialog();

                if (dtbl.Rows.Count == 1)
                {
                    string user = txt_User.Text.ToUpper();

                    if (user == "ADMIN")
                    {
                        frmAdmin admin = new frmAdmin();
                        Hide();
                        admin.Show();
                        Close();
                    }
                    else
                    {
                        setTextUser = user;
                        frmUsers users = new frmUsers();
                        Hide();
                        users.Show();
                        Close();
                    }

                    MessageBox.Show("Olá " + user + "!", "Bem-Vindo");

                    //write action in logs file
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("Login: " + user + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());
                }
                else
                {
                    MessageBox.Show("Introduza as informações corretas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_User.Clear();
                    txt_Pass.Clear();
                }
            }
            else
                MessageBox.Show("Introduza as informações necessárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if the user presses Enter key on the Password field
            the Login function is executed
            */
            if (e.KeyChar == 13)
                Login();
        }

        //button click event -> execute login function
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        //button click event -> close app
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //link label click event -> open create account form
        private void lnk_lblCriar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCriar criarConta = new frmCriar();
            Hide();
            criarConta.Show();
            Close();
        }

        //link label click event -> open support form
        private void lnk_lblSuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSuporte suporte = new frmSuporte();
            Hide();
            suporte.Show();
            Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
