using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmJogos : Form
    {
        #region DB Connection
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"../..") + "\\BD_Sistema.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        DataTable dtbl;
        #endregion

        int Id = 0; //default value for Id
        string gameEXE = "EXE";

        public frmJogos()
        {
            InitializeComponent();
        }

        //displays games on a datagridview
        private void frmJogos_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM tbl_Jogos", sqlcon);
            dtbl = new DataTable();
            adapter.Fill(dtbl);
            dgv_Jogos.DataSource = dtbl;
        }

        //get values when a row is selected on datagridview
        private void dgv_Jogos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgv_Jogos.Rows[e.RowIndex].Cells[0].Value);
            lbl_gameName.Text = dgv_Jogos.Rows[e.RowIndex].Cells[1].Value.ToString();
            gameEXE = dgv_Jogos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //button click event -> play the game selected from datagridview
        private void btn_playSelected_Click(object sender, EventArgs e)
        {
            if (lbl_gameName.Text != "Nome do Jogo" && gameEXE != "EXE")
            {
                try
                {
                    Process.Start(gameEXE);

                    WindowState = FormWindowState.Minimized; //minimize form to use less resources

                    //write action on BD
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("Ação User: " + frmUsers.setUserName + "Jogou " + lbl_gameName.Text + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nO jogo selecionado não está instalado!", "Ocurreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Seleciona um jogo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //button click event -> open default browser with google page
        private void btn_Browser_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com");
        }

        //button click event -> close current form
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            Hide();
            users.Show();
            Close();
        }

        private void frmJogos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
