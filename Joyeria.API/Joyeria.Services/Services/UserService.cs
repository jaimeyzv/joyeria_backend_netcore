﻿using Joyeria.Core;
using Joyeria.Core.Models;
using Joyeria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<User>> GetUserAsync()
        {
            return await this._unitOfWork.Users.GetUserAsync();
           
        }
    }
}