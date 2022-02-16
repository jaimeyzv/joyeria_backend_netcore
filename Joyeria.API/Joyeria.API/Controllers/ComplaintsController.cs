using Joyeria.API.ViewModels;
using Joyeria.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.API.Controllers
{
    [Route("api/[controller]")]
    public class ComplaintsController : Controller
    {
        private readonly IComplaintsService _complaintsService;

        [HttpGet]
        public async Task<IActionResult> GetComplaints()
        {
            try
            {
                var products = await this._complaintsService.GetComplaintsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetComplaintsById([FromRoute] int id)
        {
            try
            {
                var product = await this._complaintsService.GetComplaintstByIdAsync(id);
                if (product == null) return BadRequest($"Hoja de Reclamacion con id {id} no existe");

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ComplaintsVM complaints)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest($"  Hoja de Reclamacion  no es valido");


                var complaintsToCreate = new Complaints()
                {
                    Id = complaints.Id,
                    Datec = complaints.Datec,
                    Name = complaints.Name,
                    Address = complaints.Address,
                    Email = complaints.Email,
                    Cellphone = complaints.Cellphone,
                    Repre = complaints.Repre,
                    Typep = complaints.Typep,
                    Price = complaints.Price,
                    Typc = complaints.Typc,
                    Descc = complaints.Descc,
                    StatusC =1
                };

                var productCreated = await _complaintsService.CreateAsync(complaintsToCreate);

                return Ok(productCreated);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            try
            {
                var product = await this._complaintsService.GetComplaintstByIdAsync(id);
                if (product == null) return BadRequest($"Hoja de Reclamacion  con id {id} no existe");
                await this._complaintsService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }







    }
}
