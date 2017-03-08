using System;
using System.Collections.Generic;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Usuario sem login.
    /// </summary>

    public class UsuariosemLogin : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Usuario sem login.
        /// </summary>
        public UsuariosemLogin() : base(new Excecoes().UsuariosemLogin) { }
    }

    /// <summary>
    /// Exceção criada Informe o nome do Usuário.
    /// </summary>

    public class InformeLogin : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Informe o nome do Usuário.
        /// </summary>
        public InformeLogin() : base(new Excecoes().InformeLogin) { }
    }

    /// <summary>
    /// Exceção criada Usuario sem senha.
    /// </summary>

    public class UsuariosemSenha : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Usuario sem senha.
        /// </summary>
        public UsuariosemSenha() : base(new Excecoes().UsuariosemSenha) { }
    }

    /// <summary>
    /// Exceção criada Informe a senha.
    /// </summary>

    public class InformeSenha : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Informe a senha.
        /// </summary>
        public InformeSenha() : base(new Excecoes().InformeSenha) { }
    }

    /// <summary>
    /// Exceção criada Usuário e Senha Incorretos.
    /// </summary>

    public class UsuarioeSenhaIncorretos : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Usuário e Senha Incorretos.
        /// </summary>
        public UsuarioeSenhaIncorretos() : base(new Excecoes().UsuarioeSenhaIncorretos) { }
    }

    /// <summary>
    /// Exceção criada Usuário sem acesso ao sistema.
    /// </summary>

    public class UsuariosemAcessoSistema : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Usuário sem acesso ao sistema.
        /// </summary>
        public UsuariosemAcessoSistema() : base(new Excecoes().UsuariosemAcessoSistema) { }
    }

    /// <summary>
    /// Exceção criada Usuário não foi encontrado.
    /// </summary>

    public class UsuarionaoLocalizado : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Usuário não foi encontrado.
        /// </summary>
        public UsuarionaoLocalizado() : base(new Excecoes().UsuarionaoLocalizado) { }
    }

    /// <summary>
    /// Exceção criada Conta Desativada.
    /// </summary>

    public class UsuarioContaDesativada : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Usuário não foi encontrado.
        /// </summary>
        public UsuarioContaDesativada() : base(new Excecoes().UsuarioContaDesativada) { }
    }

}
