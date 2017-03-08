using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Central não localizada.
    /// </summary>

    public class CentralNaoLocalizada : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Central não localizada.
        /// </summary>
        public CentralNaoLocalizada() : base(new Excecoes().CentralNaoLocalizada) { }
    }

    /// <summary>
    /// Exceção criada Central sem nome.
    /// </summary>

    public class CentralsemNome : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Central sem nome.
        /// </summary>
        public CentralsemNome() : base(new Excecoes().CentralsemNome) { }
    }

    /// <summary>
    /// Exceção criada Central sem endereço.
    /// </summary>

    public class CentralsemEndereco : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Central sem endereço.
        /// </summary>
        public CentralsemEndereco() : base(new Excecoes().CentralsemEndereco) { }
    }

    /// <summary>
    /// Exceção criada Central com endereço repetido.
    /// </summary>

    public class CentralEnderecoRepetido : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Central com endereço repetido.
        /// </summary>
        public CentralEnderecoRepetido() : base(new Excecoes().CentralEnderecoRepetido) { }
    }

    /// <summary>
    /// Exceção criada Central com nome repetido.
    /// </summary>

    public class CentralNomeRepetido : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Central com nome repetido.
        /// </summary>
        public CentralNomeRepetido() : base(new Excecoes().CentralNomeRepetido) { }
    }

}
