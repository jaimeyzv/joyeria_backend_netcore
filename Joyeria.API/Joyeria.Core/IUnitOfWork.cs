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

        IComplaintsRepository Complaints { get; set; }
        Task<int> SaveChangesAsync();
    }
}
