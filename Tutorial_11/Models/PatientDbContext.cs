using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_11.Models
{
    public class PatientDbContext : DbContext
    {
        public  DbSet<Patient> Patient { get; set; }

        public PatientDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
