using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Exceptions
{
    /// <summary>
    /// Exceção criada Evento sem nota de reconhecimento.
    /// </summary>
    public class EventoNotadeReconhecimentoemBranco : ExcecaoBase
    {
        /// <summary>
        /// Cria exceção Evento sem nota de reconhecimento.
        /// </summary>
        public EventoNotadeReconhecimentoemBranco() : base(new Excecoes().EventoNotadeReconhecimentoemBranco) { }
    }
}
