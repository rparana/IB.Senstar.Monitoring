using IB.SM.Exceptions;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.AlarmView
{
    public static class Instancia
    {
        public static Permissao instanciaP = new Permissao();
        public static Usuario instanciaU = new Usuario();
        public static Excecoes excecoes = new Excecoes();
    }
}
