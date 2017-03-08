using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Config não localizada.
    /// </summary>

    public class ConfigNaoLocalizada : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Config não localizada.
        /// </summary>
        public ConfigNaoLocalizada() : base(new Excecoes().ConfigNaoLocalizada) { }
    }

    /// <summary>
    /// Exceção criada Config sem caminho de log.
    /// </summary>

    public class ConfigSemCaminhoLog : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Config sem caminho de log.
        /// </summary>
        public ConfigSemCaminhoLog() : base(new Excecoes().ConfigSemCaminhoLog) { }
    }

    /// <summary>
    /// Exceção criada Config sem caminho de salvamento de log.
    /// </summary>

    public class ConfigSemCaminhoSalvaLog : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Config sem caminho de salvamento de log.
        /// </summary>
        public ConfigSemCaminhoSalvaLog() : base(new Excecoes().ConfigSemCaminhoSalvaLog) { }
    }
}
