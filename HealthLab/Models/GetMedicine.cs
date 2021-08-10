using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Models
{
    public class GetMedicine
    {
        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Age")]
        public string Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Test Name ")]
        public int TestId { get; set; }

        [Display(Name = "No Of Strip")]
        public string Strips { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
