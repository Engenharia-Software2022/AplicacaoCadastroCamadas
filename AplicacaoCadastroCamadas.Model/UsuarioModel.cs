using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacaoCadastroCamadas.DAO;
using AplicacaoCadastroCamadas.DTO;

namespace AplicacaoCadastroCamadas.Model
{
    public class UsuarioModel
    {
        public int IncluirUsuario(UsuarioDTO objUsuarioDTO)
        {
            return new UsuarioDAO().IncluirUsuario(objUsuarioDTO);
        }

        public IList<UsuarioDTO> CargaUsuario()
        {
            return new UsuarioDAO().CargaUsuario();
        }
    }
}
