using System;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Objeto Vazio.
    /// </summary>
    public class ObjetoVazio : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Objeto Vazio.
        /// </summary>
        public ObjetoVazio() : base(new Excecoes().ObjetoVazio) { }

    }
}
