using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Business
{
    public interface IZonesController
    {
        List<Zone> DefaultZones();
        Zone BuscarporID(int ID);
        Zone BuscarporID(int ID, bool carregaCentral);
        Zone BuscaporNome(string nome);
        Zone BuscaporNome(string nome, bool carregaCentral);
        Zone BuscaporNumeroZona(int num);
        Zone BuscaporNumeroZona(int num, bool carregaCentral);
        Zone BuscaporNumeroZonaCentral(int num);
        Zone BuscaporNumeroZonaCentral(int num, bool carregaCentral);
        IEnumerable<Zone> ListarTodos();
        IEnumerable<Zone> ListarTodos(bool carregaCentral);
        Zone Salvar(Zone target);
        Zone Salvar(Zone target, bool saveNestedProperties);
        void Excluir(Zone target);
    }
}
