using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Business
{
    public interface IUserController
    {
        Usuario DefaultUser();
        Usuario ValidaLogin(string login, string senha);
        Usuario BuscarporID(int ID);
        Usuario BuscarporID(int ID, bool carregaGrupo);
        Usuario BuscaporNome(string nome);
        Usuario BuscaporNome(string nome, bool carregaGrupo);
        Usuario BuscaporLogin(string login);
        Usuario BuscaporLogin(string login, bool carregaGrupo);
        IEnumerable<Usuario> ListarTodos();
        IEnumerable<Usuario> ListarTodos(bool carregaGrupo);
        Usuario Salvar(Usuario target);
        Usuario Salvar(Usuario target, bool saveNestedProperties);
        void Excluir(Usuario target);
    }
}
