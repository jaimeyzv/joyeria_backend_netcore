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
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly IComplaintService _complaintService;

        public ComplaintController(IComplaintService complaintService)
        {
            _complaintService = complaintService;
        }


        [HttpGet]
        public async Task<IActionResult> GetComplaints()
        {
            try
            {
                var complaint = await this._complaintService.GetComplaintsAsync();
                return Ok(complaint);
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
                var product = await this._complaintService.GetComplaintstByIdAsync(id);
                if (product == null) return BadRequest($"Hoja de Reclamacion con id {id} no existe");

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ComplaintVM complaint)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest($"  Hoja de Reclamacion  no es valido");


                var complaintsToCreate = new Complaint()
                {
                    Datec = DateTime.Now,
                    Name = complaint.Name,
                    Address = complaint.Address,
                    Ndoc = complaint.Ndoc,
                    Email = complaint.Email,
                    Cellphone = complaint.Cellphone,
                    Repre = complaint.Repre,
                    Typep = complaint.Typep,
                    Price = complaint.Price,
                    Descp = complaint.Descp,
                    Typc = complaint.Typc,
                    Descc = complaint.Descc,
                    Pedic = complaint.Pedic

                };

                var complaintCreated = await _complaintService.CreateAsync(complaintsToCreate);

                return Ok(complaintCreated);
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
                var product = await this._complaintService.GetComplaintstByIdAsync(id);
                if (product == null) return BadRequest($"Hoja de Reclamacion  con id {id} no existe");
                await this._complaintService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }







    }
}
