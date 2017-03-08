using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Business
{
    public interface IGroupController
    {
        Grupo DefaultGroup();
        Grupo BuscarporID(int ID);
        Grupo BuscarporID(int ID, bool carregaPermissoes);
        Grupo BuscarporID(int ID, bool carregaPermissoes, bool carregaUsuarios);
        Grupo BuscaporNome(string nome);
        Grupo BuscaporNome(string nome, bool carregaPermissoes);
        Grupo BuscaporNome(string nome, bool carregaPermissoes, bool carregaUsuarios);
        IEnumerable<Grupo> ListarTodos();
        IEnumerable<Grupo> ListarTodos(bool carregaPermissoes);
        IEnumerable<Grupo> ListarTodos(bool carregaPermissoes, bool carregaUsuarios);
        Grupo Salvar(Grupo target);
        void Excluir(Grupo target);
    }
}
