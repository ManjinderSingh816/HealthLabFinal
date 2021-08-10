using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HealthLab.Data;
using HealthLab.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthLab.Pages.GetMedicineViews
{
    public class CreateModel : PageModel
    {
        private readonly HealthLab.Data.HealthLabContext _context;

        public CreateModel(HealthLab.Data.HealthLabContext context)
        {
            _context = context;
        }


        public IEnumerable<Tests> tests { get; set; }
        public async Task OnGet()
        {
            tests = await _context.Tests.ToListAsync();
        }


        [BindProperty]
        public GetMedicine GetMedicine { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GetMedicine.Add(GetMedicine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
