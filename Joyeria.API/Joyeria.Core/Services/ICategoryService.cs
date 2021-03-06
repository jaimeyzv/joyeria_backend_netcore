using Joyeria.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Core.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> CreateAsync(Category categoryToCreate);
        Task<Category> UpdateAsync(Category categoryToUpdate);
    }
}
