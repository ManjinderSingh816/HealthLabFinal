using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthLab.Models;

namespace HealthLab.Data
{
    public class HealthLabContext : DbContext
    {
        public HealthLabContext (DbContextOptions<HealthLabContext> options)
            : base(options)
        {
        }


        public DbSet<HealthLab.Models.Appointment> Appointment { get; set; }
        public DbSet<HealthLab.Models.Tests> Tests { get; set; }

        public DbSet<HealthLab.Models.GetMedicine> GetMedicine { get; set; }
    }
}
