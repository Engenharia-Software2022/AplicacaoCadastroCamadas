using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacaoCadastroCamadas.DTO;
using System.Data.SqlClient;
using System.Data;




namespace AplicacaoCadastroCamadas.DAO
{
    public class UsuarioDAO
    {
        public int IncluirUsuario(UsuarioDTO objUsuarioDTO)
        {
            using (SqlConnection con = new SqlConnection()) 
            {
                con.Open();

                //con.ConnectionString = @"Data Source=DESKTOP-9B1224L\SQLEXPRESS;Initial Catalog=bancoCadastro;User ID=sa;Password=30984312";
                con.ConnectionString = Properties.Settings.Default.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tb_usuario ([dataCadastro], [nome_usuario], [login_usuario], [senha_usuario]" + 
                                    "[email_usuario], [cpf_usuario], [status_usuario]" +
                                        "Value (@dataCadastro, @nome_usuario, @login_usuario, @senha_usuario, @email_usuario, @cpf_usuario, @status_usuario)";

                cmd.Parameters.Add("dataCadastro", SqlDbType.DateTime).Value = objUsuarioDTO.DataCadastro;
                cmd.Parameters.Add("nome_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Nome;
                cmd.Parameters.Add("login_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Login;
                cmd.Parameters.Add("senha_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Senha;
                cmd.Parameters.Add("email_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Email;
                cmd.Parameters.Add("cpf_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Cpf;
                cmd.Parameters.Add("status_usuario", SqlDbType.Char).Value = objUsuarioDTO.Status_usuario;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();
                con.Close();
                return qtd;

               
            }
        }
    }
}
