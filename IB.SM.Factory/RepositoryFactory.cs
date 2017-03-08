using IB.SM.Data.Context;
using IB.SM.Data.Repositories.Base;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Factory
{
    public class RepositoryFactory<T> : IRepositoryFactory<T>
        where T : class
    {

        public IRepository<T> CriarRepositorio()
        {

            return new Repository<T, DataContext>();
        }

        public static IRepository<T> Criar()
        {

            var rep = new RepositoryFactory<T>();

            return rep.CriarRepositorio();
        }
    }
}
