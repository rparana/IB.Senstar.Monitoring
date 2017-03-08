using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Zona não localizada.
    /// </summary>

    public class ZonaNaoLocalizada : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Zona não localizada.
        /// </summary>
        public ZonaNaoLocalizada() : base(new Excecoes().ZonaNaoLocalizada) { }
    }

    /// <summary>
    /// Exceção criada Zona sem nome.
    /// </summary>

    public class ZonasemNome : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Zona sem nome.
        /// </summary>
        public ZonasemNome() : base(new Excecoes().ZonasemNome) { }
    }

    /// <summary>
    /// Exceção criada Zona sem numero.
    /// </summary>

    public class ZonasemNumero : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Zona sem Numero.
        /// </summary>
        public ZonasemNumero() : base(new Excecoes().ZonasemNumero) { }
    }

    /// <summary>
    /// Exceção criada Zona com numero repetido.
    /// </summary>

    public class ZonaNumeroRepetido : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Zona com numero repetido.
        /// </summary>
        public ZonaNumeroRepetido() : base(new Excecoes().ZonaNumeroRepetido) { }
    }

    /// <summary>
    /// Exceção criada Zona com nome repetido.
    /// </summary>

    public class ZonaNomeRepetido : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Zona com nome repetido.
        /// </summary>
        public ZonaNomeRepetido() : base(new Excecoes().ZonaNomeRepetido) { }
    }

}
