using Dapper;
using DBContext;
using Joyeria.Core.Models;
using Joyeria.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Data.Repositories
{
    public class UserRepository :BaseRepository,IUserRepository
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

        public async Task<BaseResponse> GetUserbyEmailAsync(Login login)
        {
            var response = new BaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var loginresp = new LoginResponse();
                    const string sql = "usp_user_login";
                    var p = new DynamicParameters();
                    p.Add(name: "@email", value: login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@pass", value: login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
                    loginresp =  db.Query<LoginResponse>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();
                    if (loginresp != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = loginresp;
                    }
                    else
                    {
                        response.issuccess = false;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = null;
                    }


                 }
   
            }
            catch (Exception ex)
            {
                response.issuccess = false;
                response.errorcode = "0001";
                response.errormessage = ex.Message;
                response.data = null;
            }



            return  response;
        }
    }
}
