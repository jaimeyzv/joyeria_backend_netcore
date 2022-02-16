using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.API.ViewModels
{
    public class ComplaintsVM
    {
        public int Id { get; set; }
        [Required]
        public DateTime Datec { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Cellphone { get; set; }
        
        public string Repre { get; set; }
        [Required]
        public int Typep { get; set; }
        public Decimal Price { get; set; }
        [Required]
        public int Typc { get; set; }
        [Required]
        public string Descc { get; set; }
        [Required]
        public int StatusC { get; set; }
    }
}
