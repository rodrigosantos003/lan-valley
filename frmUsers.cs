using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmUsers : Form
    {
        #region DBConnection
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"../..") + "\\BD_Sistema.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlcon;
        SqlCommand cmd;
        #endregion

        decimal availableMoney, montante, total, convertPrice; //variables to convert data types
        double price = 0.50; //default value for price
        public static string setUserName; //string to pass user to another form

        public frmUsers()
        {
            InitializeComponent();
        }

        //actions on form load
        private void frmUsers_Load(object sender, EventArgs e)
        {
            lbl_User.Text = frmLogin.setTextUser;
            showMoney();
            btn_Depositar.Enabled = false;
        }

        //displays available money on a label
        private void showMoney()
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT [Dinheiro Disponivel] FROM tbl_Accounts WHERE [Username] = '" + lbl_User.Text.Trim() + "'", sqlcon);
            sqlcon.Open();
            lbl_Number.Text = cmd.ExecuteScalar().ToString();
            sqlcon.Close();
        }

        //deposit money on user account
        private void depositMoney()
        {
            if (txt_Montante.Text != "")
            {
                new frmContactingBD().ShowDialog();

                sqlcon = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE tbl_Accounts SET [Dinheiro Disponivel]=@Dinheiro WHERE [Username] ='" + lbl_User.Text.Trim() + "'", sqlcon);
                sqlcon.Open();

                try
                {
                    availableMoney = Convert.ToDecimal(lbl_Number.Text);
                    montante = Convert.ToDecimal(txt_Montante.Text);
                    total = availableMoney + montante;
                    cmd.Parameters.AddWithValue("@Dinheiro", total);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("Dinheiro depositado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //write action in logs file
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("Ação User: " + lbl_User.Text + " depositou dinheiro" + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());

                    insertDeposit();
                    showMoney();

                    timeCounter.Stop();
                    timeCounter.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nColoque vírgula (,) em vez de ponto (.)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Introduza um montante!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txt_Montante.Clear();
        }

        //inserts deposits on BD
        private void insertDeposit()
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO [tbl_Movimentos] ([Descrição], [Montante]) VALUES (@Desc, @Montante)", sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@Desc", "Depósito de: '" + lbl_User.Text + "'");
            cmd.Parameters.AddWithValue("@Montante", txt_Montante.Text);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        //debits money from user account
        private void debitMoney()
        {
            if (lbl_Number.Text == "0.00")
            {
                MessageBox.Show("Deposite dinheiro na sua conta para continuar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                timeCounter.Enabled = true;

                sqlcon = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE tbl_Accounts SET [Dinheiro Disponivel]=@Dinheiro WHERE [Username] = '" + lbl_User.Text.Trim() + "'", sqlcon);
                sqlcon.Open();

                availableMoney = Convert.ToDecimal(lbl_Number.Text);
                convertPrice = Convert.ToDecimal(price);
                availableMoney = availableMoney - convertPrice;

                cmd.Parameters.AddWithValue("@Dinheiro", availableMoney);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                insertDebit();
                showMoney();
            }
        }

        //inserts debit on BD
        private void insertDebit()
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO [tbl_Movimentos] ([Descrição], [Montante]) VALUES (@Desc, @Montante)", sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@Desc", "Débito 1min de: '" + lbl_User.Text + "'");
            cmd.Parameters.AddWithValue("@Montante", price);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        //button click event -> execute deposit money function
        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            depositMoney();
        }

        //timer that debits money from user account
        private void timeCounter_Tick(object sender, EventArgs e)
        {
            debitMoney();
        }

        //change text when user click on teh textbox
        private void txt_Montante_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Montante.Text == "Montante")
                txt_Montante.Text = "";

            btn_Depositar.Enabled = true;
        }

        //change text when user clicks on the form
        private void frmUsers_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Montante.Text = "Montante";
            btn_Depositar.Enabled = false;
            btn_Jogar.Focus();
        }

        //button click event -> open game form
        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            if (lbl_Number.Text != "0.00")
            {
                setUserName = lbl_User.Text;
                new frmJogos().Show();
                Hide();
            }
            else
                MessageBox.Show("Deposite dinheiro na sua conta para continuar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //tool strip button click event -> lock current usage session
        private void tsb_Lock_Click(object sender, EventArgs e)
        {
            timeCounter.Enabled = false;
            frmLogin login = new frmLogin();
            Hide();
            login.Show();
            Close();
        }

        //tool strip button click event -> close app
        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            timeCounter.Enabled = false;
            Application.Exit();
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
