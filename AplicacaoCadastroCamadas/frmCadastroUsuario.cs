using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacaoCadastroCamadas.DTO;
using AplicacaoCadastroCamadas.Model;

namespace AplicacaoCadastroCamadas
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        UsuarioDTO objUsuarioDTO = new UsuarioDTO();
        UsuarioModel objUsuarioModel = new UsuarioModel();


        private string modo = "";

        //Método
        private void InicializarModo() 
        {
            switch (modo) 
            {
                case "Novo":

                    LimparCampos();
                    HabilitarCampos();

                    mtbDataCadastro.Text = Convert.ToString(DateTime.Now);

                    break;

                case "Salvar":

                    try
                    {
                        objUsuarioDTO.DataCadastro = Convert.ToDateTime(mtbDataCadastro.Text);
                        objUsuarioDTO.Nome = txbNome.Text;
                        objUsuarioDTO.Login = txbLogin.Text;
                        objUsuarioDTO.Senha = txbSenha.Text;
                        objUsuarioDTO.Email = txbEmail.Text;
                        objUsuarioDTO.Cpf = mtbCpf.Text;
                       

                        if (rbAtivo.Checked)
                        {
                            objUsuarioDTO.Status_usuario = Convert.ToChar("A");

                        }
                        else 
                        {
                            objUsuarioDTO.Status_usuario = Convert.ToChar("I");
                        }

                        int x = new UsuarioModel().IncluirUsuario(objUsuarioDTO);

                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Usuario {0}, Cadastrado com sucesso .", txbNome.Text));
                        }
                        else 
                        {
                            MessageBox.Show("Não foi possível incluir usuário");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao salvar dados do usuário: " + ex.Message);
                    }

                    break;
            }

        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            modo = "Novo";
            InicializarModo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modo = "Salvar";
            InicializarModo();
        }



        private void HabilitarCampos() 
        {
            txbNome.Enabled = true;
            txbLogin.Enabled = true;
            txbSenha.Enabled = true;
            txbConfirmaSenha.Enabled = true;
            txbEmail.Enabled = true;
            mtbCpf.Enabled = true; 
            gbStatus.Enabled = true;

        }

        private void LimparCampos() 
        {
            txbNome.Text = "";
            txbLogin.Text = "";
            txbSenha.Text = "";
            txbConfirmaSenha.Text = "";
            txbEmail.Text = "";
            mtbDataCadastro.Text = "";
            mtbCpf.Text = "";
        }

        private void DesabilitarCampos() 
        {
            txbNome.Enabled = false;
            txbLogin.Enabled = false;
            txbSenha.Enabled = false;
            txbConfirmaSenha.Enabled = false;
            txbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            gbStatus.Enabled= false;
        }

        private void CarregaGrid() 
        {
            try
            {
                IList<UsuarioDTO> listaUsuario = new List<UsuarioDTO>();

                listaUsuario = new UsuarioModel().CargaUsuario();

                dgvCadastro.AutoGenerateColumns = false;
                dgvCadastro.DataSource = listaUsuario;
 
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados do Usuário!" + ex.Message);
            }

        }


       
    }       
}
