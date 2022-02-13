using Joyeria.API.ViewModels;
using Joyeria.Core.Models;
using Joyeria.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.API.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        [Route("list")]
        public async   Task<IActionResult> GetUser() 
        {
            try
            {
                var users = await this._userService.GetUserAsync();
                return Ok(users);
            }
            catch(Exception ex) {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost]
        [Route("create")]
        public async  Task<IActionResult> create([FromBody] UserVM user)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest($"Usuario no valido");
                var userToCreate = new User()
                {
                    Name = user.Name,
                    LastName = user.LastName,
                    DocumentNumber = user.DocumentNumber,
                    Email = user.Email,
                    Password = user.Password,
                    Address = user.Address,
                    Cellphone = user.Cellphone,
                    UserTypeId = user.UserTypeId,
                    DocumentTypeId = user.DocumentTypeId
                };
                var userCreated = await _userService.CreateAsync(userToCreate);
                return Ok(userCreated);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }





    }
}
