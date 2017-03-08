using IB.SM.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Model.Entities;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Factory;
using IB.SM.Exceptions;

namespace IB.SM.Business
{
    public class GroupController : IGroupController
    {
        private IRepository<Grupo> grRepository { get; set; }
        private IRepository<Permissao> prRepository { get; set; }
        private string permissoes = "Permissao";
        private string usuarios = "Usuarios";



        public GroupController()
        {
            grRepository = new RepositoryFactory<Grupo>().CriarRepositorio();
            prRepository = new RepositoryFactory<Permissao>().CriarRepositorio();
        }

        public Grupo BuscarporID(int ID)
        {
            return BuscarporID(ID, false);
        }

        public Grupo BuscarporID(int ID, bool carregaPermissoes)
        {
            return BuscarporID(ID, carregaPermissoes, false);
        }

        public Grupo BuscarporID(int ID, bool carregaPermissoes, bool carregaUsuarios)
        {
            List<string> includeObj = new List<string>();
            if (carregaPermissoes)
                includeObj.Add(permissoes);
            if (carregaUsuarios)
                includeObj.Add(usuarios);

            return grRepository.Query(g => g.ID == ID, includeObj.ToArray()).FirstOrDefault();
        }

        public Grupo DefaultGroup()
        {
            return new Grupo{ Nome = "Administradores", Descricao="Administradores do Sistema.", Ultimoupdate = DateTime.Now };
        }

        public IEnumerable<Grupo> ListarTodos()
        {
            return ListarTodos(false, false);
        }

        public IEnumerable<Grupo> ListarTodos(bool carregaPermissoes)
        {
            return ListarTodos(carregaPermissoes, false);
        }

        public IEnumerable<Grupo> ListarTodos(bool carregaPermissoes, bool carregaUsuarios)
        {
            List<string> includeObj = new List<string>();
            if (carregaPermissoes)
                includeObj.Add(permissoes);
            if (carregaUsuarios)
                includeObj.Add(usuarios);

            return grRepository.GetAll(includeObj.ToArray());
        }

        public Grupo BuscaporNome(string nome)
        {
            return BuscaporNome(nome, false, false);
        }

        public Grupo BuscaporNome(string nome, bool carregaPermissoes)
        {
            return BuscaporNome(nome, carregaPermissoes, false);
        }

        public Grupo BuscaporNome(string nome, bool carregaPermissoes, bool carregaUsuarios)
        {
            List<string> includeObj = new List<string>();
            if (carregaPermissoes)
                includeObj.Add(permissoes);
            if (carregaUsuarios)
                includeObj.Add(usuarios);

            return grRepository.Query(g => g.Nome.ToUpper().Equals(nome.ToUpper()), includeObj.ToArray()).FirstOrDefault();
        }

        public Grupo Salvar(Grupo target)
        {
            Grupo retorno = new Grupo();
            try
            {
                ValidaGrupo(target);
                retorno = grRepository.Query(g => g.Nome.ToUpper().Equals(target.Nome.ToUpper())).FirstOrDefault();
                if (retorno != null)
                {
                    if (retorno.ID != target.ID)
                    {
                        throw new GrupojaExiste();
                    }
                }
                retorno = grRepository.Save(target,true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return retorno;
        }

        private void ValidaGrupo(Grupo target)
        {
            if (target == null)
                throw new GruponaoInformado();

            if (String.IsNullOrEmpty(target.Nome))
                throw new GruposemNome();
        }

        public void Excluir(Grupo target)
        {
            try
            {
                ValidaGrupo(target);
                Permissao p = prRepository.Query(s => s.ID == target.Permissao.ID).FirstOrDefault();
                grRepository.Delete(target);
                prRepository.Delete(p);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
