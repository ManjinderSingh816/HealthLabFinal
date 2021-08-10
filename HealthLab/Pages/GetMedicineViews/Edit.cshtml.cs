using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthLab.Data;
using HealthLab.Models;

namespace HealthLab.Pages.GetMedicineViews
{
    public class EditModel : PageModel
    {
        private readonly HealthLab.Data.HealthLabContext _context;

        public EditModel(HealthLab.Data.HealthLabContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GetMedicine GetMedicine { get; set; }
        public IEnumerable<Tests> tests { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            tests = await _context.Tests.ToListAsync();
            GetMedicine = await _context.GetMedicine.FirstOrDefaultAsync(m => m.id == id);

            if (GetMedicine == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GetMedicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GetMedicineExists(GetMedicine.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GetMedicineExists(int id)
        {
            return _context.GetMedicine.Any(e => e.id == id);
        }
    }
}
