using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.API.ViewModels
{
    public class ComplaintVM
    {
        public int Id { get; set; }
        [Required]
        public DateTime Datec { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Ndoc { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Cellphone { get; set; }
        
        public string Repre { get; set; }
        [Required]
        public string Typep { get; set; }
        public string Price { get; set; }
        [Required]
        public string Descp { get; set; }
        [Required]
        public string Typc { get; set; }
        [Required]
        public string Descc { get; set; }
        [Required]
        public string Pedic { get; set; }
        
        public int StatusC { get; set; }
    }
}
