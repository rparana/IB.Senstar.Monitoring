using IB.SM.Model.Entities;
using System.Collections.Generic;

namespace IB.SM.Model.Business
{
    public interface ICentralController
    {
        List<Central> DefaultCentrals();
        Central BuscarporID(int ID);
        Central BuscarporID(int ID, bool carregaZonas);
        Central BuscaporNome(string nome);
        Central BuscaporNome(string nome, bool carregaZonas);
        Central BuscaporEndereco(int end);
        Central BuscaporEndereco(int end, bool carregaZonas);
        IEnumerable<Central> ListarTodos();
        IEnumerable<Central> ListarTodos(bool carregaZonas);
        Central Salvar(Central target);
        Central Salvar(Central target, bool saveNestedProperties);
        void Excluir(Central target);

    }
}
