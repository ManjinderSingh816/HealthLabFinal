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
    public class IndexModel : PageModel
    {
        private readonly HealthLab.Data.HealthLabContext _context;

        public IndexModel(HealthLab.Data.HealthLabContext context)
        {
            _context = context;
        }

        public IList<GetMedicine> GetMedicine { get;set; }

        public async Task OnGetAsync()
        {
            GetMedicine = await _context.GetMedicine.ToListAsync();
        }
    }
}
