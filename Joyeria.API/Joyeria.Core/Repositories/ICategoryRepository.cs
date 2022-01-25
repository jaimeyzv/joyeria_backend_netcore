using Joyeria.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Core.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
