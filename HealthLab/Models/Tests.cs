using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Models
{
    public class Tests
    {
        public int Id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "TestName ")]
        public string TestName { get; set; }

        [Display(Name = "Age")]
        public string Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }
    }
}
