
using System;
using System.Collections.Generic;
using Joyeria.Core.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Core.Repositories
{
     public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
      
        Task<User> CreateAsync(User createToUser);
        Task<User> UpdateAsync(User userToUpdate);
    }
}
