using System;
using System.Collections.Generic;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Grupo sem nome.
    /// </summary>

    public class GruposemNome : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Grupo sem nome.
        /// </summary>
        public GruposemNome() : base(new Excecoes().GrupoSemNome) { }
    }

    /// <summary>
    /// Exceção criada Grupo não Informado.
    /// </summary>

    /// <summary>
    /// Exceção criada Grupo com nome existente.
    /// </summary>

    public class GrupojaExiste : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Grupo sem nome.
        /// </summary>
        public GrupojaExiste() : base(new Excecoes().GrupojaExiste) { }
    }

    /// <summary>
    /// Exceção criada Grupo não Informado.
    /// </summary>

    public class GruponaoInformado : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Grupo não localizado.
        /// </summary>
        public GruponaoInformado() : base(new Excecoes().GruponaoInformado) { }
    }

    /// <summary>
    /// Exceção criada Grupo não localizado.
    /// </summary>

    public class GruponaoLocalizado : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Grupo não localizado.
        /// </summary>
        public GruponaoLocalizado() : base(new Excecoes().GruponaoLocalizado) { }
    }

}
