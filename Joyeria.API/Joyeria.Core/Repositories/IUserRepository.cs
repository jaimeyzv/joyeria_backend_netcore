using Joyeria.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Core.Repositories
{
     public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUserAsync();
        Task<User> CreateAsync(User createToUser);
    }
}
