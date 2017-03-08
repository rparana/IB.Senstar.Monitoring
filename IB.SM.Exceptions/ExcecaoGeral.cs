using System;
using System.Collections.Generic;


namespace IB.SM.Exceptions
{
        /// <summary>
        /// Exceção criada Sem Permissão.
        /// </summary>

        public class SemPermissao : ExcecaoBase
        {
            /// <summary>
            /// Cria exceção Sem Permissão.
            /// </summary>
            public SemPermissao() : base(new Excecoes().SemPermissao) { }
        }
}
