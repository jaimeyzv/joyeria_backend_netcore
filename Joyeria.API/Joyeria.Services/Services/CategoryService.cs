using Joyeria.Core;
using Joyeria.Core.Models;
using Joyeria.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await this._unitOfWork.Categories.GetCategoriesAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetCategoryByIdAsync(id);
        }
    }
}
