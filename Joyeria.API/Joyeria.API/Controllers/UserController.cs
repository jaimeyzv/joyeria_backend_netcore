﻿using Joyeria.API.ViewModels;
using Joyeria.Core.Models;
using Joyeria.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async   Task<IActionResult> GetUsers() 
        {
            try
            {
                var users = await this._userService.GetUsersAsync();
                return Ok(users);
            }
            catch(Exception ex) {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUserById([FromRoute]int id)
        {
            try
            {
                var user = await this._userService.GetUserByIdAsync(id);
                if (user == null) return BadRequest($"Usuario con id{id} no existe");
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }



        [HttpPost]
        public async  Task<IActionResult> Create([FromBody] UserVM user)
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
