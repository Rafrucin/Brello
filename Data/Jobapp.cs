using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Brello.Data
{
    public class Jobapp
    {
        [Required] 
        public string FullName { get; set; }

        [StringLength(500, ErrorMessage = "Too looooong")] 
        public string Description { get; set; }

        [Range(1000,2000, ErrorMessage = "between 1000 and 2000")] 
        public int SalaryExpectation { get; set; }

        [Required]
        public bool DoesOpenSource { get; set; }

        [Required]
        public DateTime Availability { get; set; }

    }
}
