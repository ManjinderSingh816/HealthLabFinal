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
    public class IndexModel : PageModel
    {
        private readonly HealthLab.Data.HealthLabContext _context;

        public IndexModel(HealthLab.Data.HealthLabContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; }

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointment.ToListAsync();
        }
    }
}
