using System;

namespace IB.SM.Exceptions
{
    public class ExcecaoBase : Exception
    {
        // private static ResourceManager _resources = new ResourceManager("Resource.pt-br", Assembly.GetExecutingAssembly());

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public ExcecaoBase()
        {
        }

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="msg">Mensagem da exceção.</param>
        public ExcecaoBase(string msg)
            : base(msg)
        {
        }

    }
}
