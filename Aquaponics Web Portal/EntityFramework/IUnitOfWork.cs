using System;
using System.Threading.Tasks;

namespace AquaponicsWebPortal.EntityFramework
{
    public interface IUnitOfWork : IDisposable
    {
        Task Complete();
        void CompleteNonAsync();
        IGenericRepository<T> GetInstance<T>() where T : class;
    }
}
