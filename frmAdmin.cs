using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LanValley
{
    public partial class frmAdmin : Form
    {
        #region DB Connection
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"../..") + "\\BD_Sistema.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlcon;
        SqlCommand cmd, checkUser;
        SqlDataAdapter adapter;
        DataTable dtbl;
        #endregion

        int Id = 0; //default value for Id

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            totalUsers();
            totalPC();
            showUsers();
            showPC();
            showMovimentos();
            showJogos();
        }

        //displays total number of users on a label
        private void totalUsers()
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT COUNT (*) FROM tbl_Accounts", sqlcon);
            sqlcon.Open();
            lbl_totalUsers.Text = cmd.ExecuteScalar().ToString();
            sqlcon.Close();
        }

        //displays total number of PC's on a label
        private void totalPC()
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT COUNT (*) FROM tbl_PC", sqlcon);
            sqlcon.Open();
            lbl_totalPC.Text = cmd.ExecuteScalar().ToString();
            sqlcon.Close();
        }

        //displays regisered users on a datagridview
        private void showUsers()
        {
            sqlcon = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM tbl_Accounts", sqlcon);
            dtbl = new DataTable();
            adapter.Fill(dtbl);
            dgv_Users.DataSource = dtbl;
        }

        //displays registered pc's on a datagridview
        private void showPC()
        {
            sqlcon = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM tbl_PC", sqlcon);
            dtbl = new DataTable();
            adapter.Fill(dtbl);
            dgv_PC.DataSource = dtbl;
        }

        //displays registered movements on a datagridview
        private void showMovimentos()
        {
            sqlcon = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM tbl_Movimentos", sqlcon);
            dtbl = new DataTable();
            adapter.Fill(dtbl);
            dgv_Movimentos.DataSource = dtbl;
        }

        //button click event -> export datagridview records
        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (dgv_Movimentos.Rows.Count > 0)
            {
                SaveFileDialog exportMovements = new SaveFileDialog();
                exportMovements.Filter = "CSV (*.csv)|*.csv";
                exportMovements.FileName = "Movimentos.csv";
                bool fileError = false;
                if (exportMovements.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(exportMovements.FileName))
                    {
                        try
                        {
                            File.Delete(exportMovements.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possível escrever os dados no disco" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgv_Movimentos.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgv_Movimentos.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgv_Movimentos.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgv_Movimentos.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgv_Movimentos.Rows[i - 1].Cells[j].Value + ",";
                                }
                            }

                            File.WriteAllLines(exportMovements.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Dados exportados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        //displays registered games on a datagridview
        private void showJogos()
        {
            sqlcon = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM tbl_Jogos", sqlcon);
            dtbl = new DataTable();
            adapter.Fill(dtbl);
            dgv_Jogos.DataSource = dtbl;
        }

        //change datagridview when a user is searched
        private void txt_searchUser_TextChanged(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            sqlcon.Open();
            adapter = new SqlDataAdapter("SELECT * FROM tbl_Accounts WHERE Username LIKE '" + txt_searchUser.Text + "%'", sqlcon);
            dtbl = new DataTable();
            adapter.Fill(dtbl);
            dgv_Users.DataSource = dtbl;
            sqlcon.Close();
        }

        //get values when a row is selected on datagridview
        private void dgv_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgv_Users.Rows[e.RowIndex].Cells[0].Value);
            txt_Nome.Text = dgv_Users.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_User.Text = dgv_Users.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Pass.Text = dgv_Users.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //button click event -> insert users on BD
        private void btn_insertUser_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" && txt_User.Text != "" && txt_Pass.Text != "")
            {
                new frmContactingBD().ShowDialog();

                sqlcon = new SqlConnection(cs);
                cmd = new SqlCommand("INSERT INTO [tbl_Accounts] ([Nome], [Username], [Password], [Dinheiro Disponivel]) VALUES (@Nome, @User, @Pass, @Dinheiro)", sqlcon);
                checkUser = new SqlCommand("SELECT COUNT(*) FROM [tbl_Accounts] WHERE [Username] LIKE '" + txt_User.Text.Trim() + "'", sqlcon);
                sqlcon.Open();

                int userExists = (int)checkUser.ExecuteScalar();

                if (userExists > 0)
                    MessageBox.Show("Este utilizador já existe!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    cmd.Parameters.AddWithValue("@Nome", txt_Nome.Text);
                    cmd.Parameters.AddWithValue("@User", txt_User.Text);
                    cmd.Parameters.AddWithValue("@Pass", txt_Pass.Text);
                    cmd.Parameters.AddWithValue("@Dinheiro", 0.00);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("User introduzido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //write action in logs file
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("User Criado: " + txt_User.Text + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());
                }

                showUsers();
                totalUsers();

                txt_Nome.Clear();
                txt_User.Clear();
                txt_Pass.Clear();
            }
            else
                MessageBox.Show("Preencha os campos necessários", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //button click event -> update user on BD
        private void btn_upgradeUser_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" && txt_User.Text != "" && txt_Pass.Text != "")
            {
                new frmContactingBD().ShowDialog();

                sqlcon = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE tbl_Accounts SET Nome=@Nome, Username=@User, Password=@Pass WHERE Id=@Id", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nome", txt_Nome.Text);
                cmd.Parameters.AddWithValue("@User", txt_User.Text);
                cmd.Parameters.AddWithValue("@Pass", txt_Pass.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("User atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //write action in logs file
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("User Modificado: " + txt_User.Text + "\t" + DateTime.Now.ToString() + "\n");
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());

                showUsers();

                txt_Nome.Clear();
                txt_User.Clear();
                txt_Pass.Clear();
            }
            else
                MessageBox.Show("Selecione um utilizador para atualizar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //button click event -> delete users from BD
        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                if (MessageBox.Show("Deseja mesmo apagar este user?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new frmContactingBD().ShowDialog();

                    sqlcon = new SqlConnection(cs);
                    cmd = new SqlCommand("DELETE tbl_Accounts WHERE Id=@Id", sqlcon);
                    sqlcon.Open();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("User eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("User Eliminado: " + txt_User.Text + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());

                    showUsers();
                    totalUsers();

                    txt_Nome.Clear();
                    txt_User.Clear();
                    txt_Pass.Clear();
                }
                else
                {
                    txt_Nome.Clear();
                    txt_User.Clear();
                    txt_Pass.Clear();
                }
            }
            else
                MessageBox.Show("Selecione um utilizador para eliminar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //get values when a row is selected on datagridview
        private void dgv_PC_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgv_PC.Rows[e.RowIndex].Cells[0].Value);
            txt_Marca.Text = dgv_PC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Modelo.Text = dgv_PC.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //button click event -> insert PC on BD
        private void btn_insertPC_Click(object sender, EventArgs e)
        {
            if (txt_Marca.Text != "" && txt_Modelo.Text != "")
            {
                new frmContactingBD().ShowDialog();

                sqlcon = new SqlConnection(cs);
                cmd = new SqlCommand("INSERT INTO tbl_PC ([Marca], [Modelo]) VALUES (@Marca, @Modelo)", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("@Marca", txt_Marca.Text);
                cmd.Parameters.AddWithValue("Modelo", txt_Modelo.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("PC inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //write action in logs file
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("PC Inserido: " + txt_Marca.Text + " " + txt_Modelo.Text + "\t" + DateTime.Now.ToString() + "\n");
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());

                showPC();
                totalPC();

                txt_Marca.Clear();
                txt_Modelo.Clear();
            }
            else
                MessageBox.Show("Preencha os campos necessários!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //button click event -> delete PC from BD
        private void btn_deletePC_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                if (MessageBox.Show("Deseja mesmo apagar este PC?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    new frmContactingBD().ShowDialog();

                    sqlcon = new SqlConnection(cs);
                    cmd = new SqlCommand("DELETE tbl_PC WHERE Id=@Id", sqlcon);
                    sqlcon.Open();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("PC eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //write action on BD
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("PC Eliminado: " + txt_Marca.Text + " " + txt_Modelo.Text + "\t" + DateTime.Now.ToString() + "\n");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", stringBuilder.ToString());

                    showPC();
                    totalPC();

                    txt_Marca.Clear();
                    txt_Modelo.Clear();
                }
                else
                {
                    txt_Marca.Clear();
                    txt_Modelo.Clear();
                }
            }
            else
                MessageBox.Show("Selecione um PC para eliminar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //button click event -> search game exe file
        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            if (searchGame.ShowDialog() == DialogResult.OK)
                txt_exeName.Text = Path.GetFullPath(searchGame.FileName);
        }

        //button click event -> add game to BD
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_exeName.Text != "" && txt_gameName.Text != "")
            {
                new frmContactingBD().ShowDialog();

                sqlcon = new SqlConnection(cs);
                cmd = new SqlCommand("INSERT INTO [tbl_Jogos] ([Nome], [EXE]) VALUES (@Nome, @Exe)", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("@Nome", txt_gameName.Text);
                cmd.Parameters.AddWithValue("@Exe", txt_exeName.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Jogo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                showJogos();

                txt_gameName.Clear();
                txt_exeName.Clear();
            }
            else
                MessageBox.Show("Preencha os campos necessários!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //tool strip button click event -> lock current usage session
        private void tsb_Lock_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Hide();
            login.Show();
            Close();
        }

        //tool strip button click event -> close app
        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
