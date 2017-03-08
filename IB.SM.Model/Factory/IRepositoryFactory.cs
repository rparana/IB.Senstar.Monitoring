
using IB.SM.Model.Data.Repositories.Base;

namespace IB.SM.Model.Factory
{
    public interface IRepositoryFactory<T>
        where T : class
    {
        IRepository<T> CriarRepositorio();
    }
}
