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


namespace AplicacaoCadastroCamadas
{
    public partial class frmTelaLogin : Form
    {
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
                UsuarioDTO objUsuario = new UsuarioDTO();

                objUsuario = new UsuarioModel().AutenticacaoUsuario();

                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.ConexaoBanco;
                    
                    string query = "select * from tb_usuario where login_usuario = '"+txbUsuario.Text +"' And senha_usuario = '"+txbSenha.Text +"' ";
                    SqlDataAdapter ada = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        frmCadastroUsuario tela = new frmCadastroUsuario();
                        this.Hide();
                        tela.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Usuário ou Senha inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao logar" + ex.Message);
            }
            frmCadastroUsuario frm = new frmCadastroUsuario();
            frm.Show();
            this.Hide();
        }
    }
}
