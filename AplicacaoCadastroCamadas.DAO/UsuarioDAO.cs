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
                
                //con.ConnectionString = @"Data Source=DESKTOP-9B1224L\SQLEXPRESS;Initial Catalog=bancoCadastro;User ID=sa;Password=30984312";
                con.ConnectionString = Properties.Settings.Default.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                
                cmd.CommandText = "insert into tb_usuario ([datacadastro_usuario], [nome_usuario], [login_usuario], [senha_usuario], [email_usuario], [cpf_usuario], [status_usuario])" + 
                                    "values (@datacadastro_usuario, @nome_usuario, @login_usuario, @senha_usuario, @email_usuario, @cpf_usuario, @status_usuario)";

                cmd.Parameters.Add("datacadastro_usuario", SqlDbType.DateTime).Value = objUsuarioDTO.DataCadastro;
                cmd.Parameters.Add("nome_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Nome;
                cmd.Parameters.Add("login_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Login;
                cmd.Parameters.Add("senha_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Senha;
                cmd.Parameters.Add("email_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Email;
                cmd.Parameters.Add("cpf_usuario", SqlDbType.VarChar).Value = objUsuarioDTO.Cpf;
                cmd.Parameters.Add("status_usuario", SqlDbType.Char).Value = objUsuarioDTO.Status_usuario;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();
                
                return qtd;

               
            }
        }

        public IList<UsuarioDTO> CargaUsuario()
        {
            using (SqlConnection con = new SqlConnection()) 
            {
                con.ConnectionString = Properties.Settings.Default.ConexaoBanco;
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from tb_usuario";

                com.Connection = con;

                SqlDataReader dr;

                IList<UsuarioDTO> listaUsuarioDto = new List<UsuarioDTO>();
                con.Open();

                dr = com.ExecuteReader();

                if (dr.HasRows) 
                {
                    while (dr.Read()) 
                    {
                        UsuarioDTO usuario = new UsuarioDTO();

                        usuario.Codigo = Convert.ToInt32(dr["codigo_usuario"]);
                        usuario.DataCadastro = Convert.ToDateTime(dr["datacadastro_usuario"]);
                        usuario.Nome = Convert.ToString(dr["nome_usuario"]);
                        usuario.Login = Convert.ToString(dr["login_usuario"]);
                        usuario.Senha = Convert.ToString(dr["senha_usuario"]);
                        usuario.Email = Convert.ToString(dr["email_usuario"]);
                        usuario.Cpf = Convert.ToString(dr["cpf_usuario"]);
                        usuario.Status_usuario = Convert.ToChar(dr["status_usuario"]);

                        listaUsuarioDto.Add(usuario);
                    }
                }

                return listaUsuarioDto;

            }  
        }

        


    }
}
