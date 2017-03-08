using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Senha Diferente da Confirmação.
    /// </summary>
    /// 
    public class SenhaDiferentedaConfirmacao : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Senha Diferente da Confirmação.
        /// </summary>
        public SenhaDiferentedaConfirmacao() : base(new Excecoes().SenhaDiferentedaConfirmacao) { }
    }

    /// <summary>
    /// Exceção criada Senha em Branco.
    /// </summary>
    /// 
    public class SenhaNaoPodeSerVazio : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Senha em Branco.
        /// </summary>
        public SenhaNaoPodeSerVazio() : base(new Excecoes().SenhaNaoPodeSerVazio) { }
    }

    /// <summary>
    /// Exceção criada Senha não pode ser igual antiga.
    /// </summary>
    /// 
    public class SenhaNaoPodeSerIgualAntiga : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Senha não pode ser igual antiga.
        /// </summary>
        public SenhaNaoPodeSerIgualAntiga() : base(new Excecoes().SenhaNaoPodeSerIgualAntiga) { }
    }

}
