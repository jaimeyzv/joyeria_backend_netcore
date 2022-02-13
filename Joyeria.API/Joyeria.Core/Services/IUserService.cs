using Joyeria.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Core.Services
{
   public interface IUserService
    {
        Task<IEnumerable<User>> GetUserAsync();
        Task<User> CreateAsync(User createToUser);

    }
}
