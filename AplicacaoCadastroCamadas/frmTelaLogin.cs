using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacaoCadastroCamadas.DTO;
using AplicacaoCadastroCamadas.Model;
using AplicacaoCadastroCamadas.DAO;



namespace AplicacaoCadastroCamadas
{
    public partial class frmTelaLogin : Form
    {
        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-MKQEMBT\SQLEXPRESS;Initial Catalog=banco_cadastro;Integrated Security=True");
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                    Conexao.Open();
                    string query = "select * from tb_usuario where login_usuario = '" + txbUsuario.Text + "' And senha_usuario = '" + txbSenha.Text + "'";
                    SqlDataAdapter ada = new SqlDataAdapter(query, Conexao);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    frmCadastroUsuario frm = new frmCadastroUsuario();
                    this.Hide();
                    frm.Show();
                    Conexao.Close();
                }
                else 
                {
                    MessageBox.Show("Usuario ou Senha Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar." + ex.Message);
            }
            
        }


       
    }
}
