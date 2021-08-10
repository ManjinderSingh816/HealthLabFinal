using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthLab.Data;
using HealthLab.Models;

namespace HealthLab.Pages.GetMedicineViews
{
    public class DetailsModel : PageModel
    {
        private readonly HealthLab.Data.HealthLabContext _context;

        public DetailsModel(HealthLab.Data.HealthLabContext context)
        {
            _context = context;
        }

        public GetMedicine GetMedicine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GetMedicine = await _context.GetMedicine.FirstOrDefaultAsync(m => m.id == id);

            if (GetMedicine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
