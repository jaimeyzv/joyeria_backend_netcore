using Joyeria.Core.Models;
using Joyeria.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly JoyeriaDbContext _dbContext;
        public UserRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public async Task<User> CreateAsync(User createToUser)
        {
            await _dbContext.Users.AddAsync(createToUser);
            return createToUser;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await this._dbContext.Users.ToListAsync();
           
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            return user;
        }
    }
}
