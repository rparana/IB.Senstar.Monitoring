using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Business
{
    public interface IUtil
    {
        string encrypt(string phrase); //Critografa o conteudo passado
        bool readyStart(); //Verifica se o sistema está OK para operar.
        bool firstConfig(); //Efetua a primeira configuração da Base de dados e do sistema
        bool databaseExist(); //Verifica se existe o database
    }
}
