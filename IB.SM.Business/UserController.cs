using IB.SM.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Model.Entities;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Exceptions;
using IB.SM.Model.Factory;
using IB.SM.Factory;
using System.Data.SqlClient;

namespace IB.SM.Business
{
    public class UserController : IUserController
    {
        private IRepository<Usuario> userRepository { get; set; }
        private string[] includeUsuario = { "Grupo" };

        public UserController()
        {
            userRepository = new RepositoryFactory<Usuario>().CriarRepositorio();
        }

        public Usuario DefaultUser()
        {
            return new Usuario
            {
                Alterasenha = true,
                Ativo = true,
                Descricao = "Administrador do Sistema.",
                Login = "Admin",
                Nome = "Administrador",
                Senhaexpira = false
            };
        }

        /// <summary>
        /// ValidaLogin -> Verifica se o usuário e senha estão aptos a efetuar o login.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns>Usuario</returns>

        public Usuario ValidaLogin(string login, string senha)
        {
            Usuario retorno = null;
            try
            {

                if (string.IsNullOrEmpty(login.Trim()))
                {
                    throw new InformeLogin();
                }
                if (string.IsNullOrEmpty(senha.Trim()))
                {
                    throw new InformeSenha();
                }

                retorno = userRepository.Query(t => t.Login.ToLower() == login.ToLower() && t.Senha == senha, includeUsuario).FirstOrDefault();
                if (retorno == null)
                {
                    throw new UsuarioeSenhaIncorretos();
                }
                if (!retorno.Ativo)
                {
                    throw new UsuarioContaDesativada();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public Usuario Salvar(Usuario target)
        {
            return Salvar(target, false);
        }

        public Usuario Salvar(Usuario target, bool saveNestedProperties)
        {
            try
            {
                ValidaUsuario(target);
                return this.userRepository.Save(target, saveNestedProperties);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void ValidaUsuario(Usuario obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new ObjetoVazio();
                }
                if (string.IsNullOrEmpty(obj.Login))
                {
                    throw new UsuariosemLogin();
                }
                if (string.IsNullOrEmpty(obj.Senha))
                {
                    throw new UsuariosemSenha();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public Usuario BuscarporID(int ID)
        {
            return BuscarporID(ID, false);
        }

        public Usuario BuscarporID(int ID, bool carregaGrupo)
        {
            List<string> include = new List<string>();
            if (carregaGrupo)
                include.Add(includeUsuario.FirstOrDefault());
            return userRepository.Query(u => u.ID == ID, includeUsuario.ToArray()).FirstOrDefault();
        }

        public Usuario BuscaporNome(string nome)
        {
            return BuscaporNome(nome, false);
        }

        public Usuario BuscaporNome(string nome, bool carregaGrupo)
        {
            List<string> include = new List<string>();
            if (carregaGrupo)
                include.Add(includeUsuario.FirstOrDefault());
            return userRepository.Query(u => u.Nome == nome, includeUsuario.ToArray()).FirstOrDefault();
        }

        public Usuario BuscaporLogin(string login)
        {
            return BuscaporLogin(login, false);
        }

        public Usuario BuscaporLogin(string login, bool carregaGrupo)
        {
            List<string> include = new List<string>();
            if (carregaGrupo)
                include.Add(includeUsuario.FirstOrDefault());
            return userRepository.Query(u => u.Login == login, includeUsuario.ToArray()).FirstOrDefault();
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return ListarTodos(false);
        }

        public IEnumerable<Usuario> ListarTodos(bool carregaGrupo)
        {
            List<string> include = new List<string>();
            if (carregaGrupo)
                include.Add(includeUsuario.FirstOrDefault());
            return userRepository.GetAll(includeUsuario.ToArray());

        }

        public void Excluir(Usuario target)
        {
            userRepository.Delete(target);
        }
    }
}
