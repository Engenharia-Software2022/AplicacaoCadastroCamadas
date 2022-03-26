using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCadastroCamadas.DTO
{
    public class UsuarioDTO
    {
        private int codigo;
        private String nome;
        private String login;
        private String senha;
        private String email;
        private String cpf;
        private char status_usuario;
        private DateTime dataCadastro;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public char Status_usuario 
        {
            get { return status_usuario; }
            set { status_usuario = value; }
        }

        public DateTime DataCadastro 
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
    }
}
