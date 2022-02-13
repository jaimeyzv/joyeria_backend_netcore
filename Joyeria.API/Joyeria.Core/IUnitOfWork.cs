using Joyeria.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Joyeria.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IUserRepository Users { get; }
        Task<int> SaveChangesAsync();
    }
}
