using Joyeria.Core;

using Joyeria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joyeria.Core.Models;

namespace Joyeria.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public  async Task<User> CreateAsync(User createToUser)
        {
            await _unitOfWork.Users.CreateAsync(createToUser);
            await _unitOfWork.SaveChangesAsync();
            return createToUser;
           
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await this._unitOfWork.Users.GetUsersAsync();
           
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _unitOfWork.Users.GetUserByIdAsync(id);
        }

        public async Task<User> UpdateAsync(User userToUpdate)
        {
            await _unitOfWork.Users.UpdateAsync(userToUpdate);
            await _unitOfWork.SaveChangesAsync();
            return userToUpdate;
            
        }
    }
}
