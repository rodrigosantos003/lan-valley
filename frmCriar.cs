using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmCriar : Form
    {
        public frmCriar()
        {
            InitializeComponent();
        }

        //inserts a new account on BD
        private void createAccount()
        {
            if (txt_insertName.Text != "" && txt_insertUser.Text != "" && txt_insertUser.Text != "")
            {
                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"../..") + "\\BD_Sistema.mdf;Integrated Security=True;Connect Timeout=30";

                new frmContactingBD().ShowDialog();

                SqlConnection sqlcon = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO [tbl_Accounts] ([Nome], [Username], [Password], [Dinheiro Disponivel]) VALUES (@Nome, @User, @Pass, @Dinheiro)", sqlcon);
                SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM [tbl_Accounts] WHERE [Username] LIKE '" + txt_insertUser.Text.Trim() + "'", sqlcon);
                sqlcon.Open();

                int userExists = (int)checkUser.ExecuteScalar();

                if (userExists > 0)
                    MessageBox.Show("Este username já existe!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    cmd.Parameters.AddWithValue("@Nome", txt_insertName.Text);
                    cmd.Parameters.AddWithValue("@User", txt_insertUser.Text);
                    cmd.Parameters.AddWithValue("@Pass", txt_insertPass.Text);
                    cmd.Parameters.AddWithValue("@Dinheiro", 0.00);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //write action on logs file
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("User Criado: " + txt_insertUser.Text + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());

                    sqlcon.Close();

                    frmLogin login = new frmLogin();
                    Hide();
                    login.Show();
                    Close();
                }
            }
            else
                MessageBox.Show("Introduza as informações necessárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //button click event -> execute create account function
        private void btn_Criar_Click(object sender, EventArgs e)
        {
            createAccount();
        }

        //button click event -> change view mode of password
        private void btn_viewPassword_Click(object sender, EventArgs e)
        {
            if (txt_insertPass.UseSystemPasswordChar == true)
                txt_insertPass.UseSystemPasswordChar = false;
            else
                txt_insertPass.UseSystemPasswordChar = true;
        }

        //tool strip button click event -> close current form
        private void tsb_Back_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Hide();
            login.Show();
            Close();
        }

        //tool strip button event -> close app
        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCriar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
