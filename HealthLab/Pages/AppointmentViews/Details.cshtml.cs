using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthLab.Data;
using HealthLab.Models;

namespace HealthLab.Pages.AppointmentViews
{
    public class DetailsModel : PageModel
    {
        private readonly HealthLab.Data.HealthLabContext _context;

        public DetailsModel(HealthLab.Data.HealthLabContext context)
        {
            _context = context;
        }

        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment.FirstOrDefaultAsync(m => m.id == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
