using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Models
{
    public class Appointment
    {

        public int id { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Contact")]
        public string Contact { get; set; }


        [Display(Name = "Disease")]
        public string Disease { get; set; }

        
        [Display(Name = "Age")]
        public string Age { get; set; }
        
        
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        [Display(Name = "Brief")]
        public string Brief { get; set; }

    }
}
