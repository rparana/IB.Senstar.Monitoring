using IB.SM.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Model.Entities;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Exceptions;
using IB.SM.Factory;

namespace IB.SM.Business
{
    public class CentralController : ICentralController
    {
        private IRepository<Central> centralRepository { get; set; }
        private string[] includeCentral = { "Zonas" };

        public CentralController()
        {
            centralRepository = new RepositoryFactory<Central>().CriarRepositorio();
        }

        public Central BuscaporEndereco(int end)
        {
            return BuscaporEndereco(end, false);
        }

        public Central BuscaporEndereco(int end, bool carregaZonas)
        {
            List<string> include = new List<string>();
            if (carregaZonas)
                include.Add(includeCentral.FirstOrDefault());
            return centralRepository.Query(u => u.Endereco == end, include.ToArray()).FirstOrDefault();

        }

        public Central BuscaporNome(string nome)
        {
            return BuscaporNome(nome, false);
        }

        public Central BuscaporNome(string nome, bool carregaZonas)
        {
            List<string> include = new List<string>();
            if (carregaZonas)
                include.Add(includeCentral.FirstOrDefault());
            return centralRepository.Query(u => u.Nome == nome, include.ToArray()).FirstOrDefault();
        }

        public Central BuscarporID(int ID)
        {
            return BuscarporID(ID, false);
        }

        public Central BuscarporID(int ID, bool carregaZonas)
        {
            List<string> include = new List<string>();
            if (carregaZonas)
                include.Add(includeCentral.FirstOrDefault());
            return centralRepository.Query(u => u.ID == ID, include.ToArray()).FirstOrDefault();
        }

        public List<Central> DefaultCentrals()
        {

            List<Central> retorno = new List<Central>
                {
                    new Central { Nome="Central01", Endereco=1, Ultimoupdate=DateTime.Now },
                    new Central { Nome="Central02", Endereco=2, Ultimoupdate=DateTime.Now },
                    new Central { Nome="Central03", Endereco=3, Ultimoupdate=DateTime.Now }
                };

            return retorno;
        }

        public void Excluir(Central target)
        {
            try
            {
                if (target==null)
                {
                    throw new CentralNaoLocalizada();
                }

                centralRepository.Delete(target);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public IEnumerable<Central> ListarTodos()
        {
            return ListarTodos(false);
        }

        public IEnumerable<Central> ListarTodos(bool carregaZonas)
        {
            List<string> include = new List<string>();
            if (carregaZonas)
                include.Add(includeCentral.FirstOrDefault());
            return centralRepository.GetAll(include.ToArray());
        }

        public Central Salvar(Central target)
        {
            return Salvar(target, false);
        }

        public Central Salvar(Central target, bool saveNestedProperties)
        {
            try
            {
                Valida(target);
                return this.centralRepository.Save(target, saveNestedProperties);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private bool Valida(Central target)
        {
            bool retorno = true;

            try
            {
                if (target == null)
                {
                    throw new CentralNaoLocalizada();
                }

                if (String.IsNullOrEmpty(target.Nome))
                {
                    throw new CentralsemNome();
                }

                if (target.Endereco==0)
                {
                    throw new CentralsemEndereco();
                }

                Central c = centralRepository.Query(q => q.Nome.ToUpper().Equals(target.Nome.ToUpper())).FirstOrDefault();
                if (c != null)
                {
                    if (c.ID != target.ID)
                    {
                        throw new CentralNomeRepetido();
                    }
                }

                c = centralRepository.Query(q => q.Endereco == target.Endereco).FirstOrDefault();
                if (c != null)
                {
                    if (c.ID != target.ID)
                    {
                        throw new CentralEnderecoRepetido();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return retorno;
        }
    }
}
