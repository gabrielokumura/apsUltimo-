using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APSWebMCV.Models;

namespace APSWebMCV.Data
{
    public class APSWebMCVContext : DbContext
    {
        public APSWebMCVContext (DbContextOptions<APSWebMCVContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Assessment> Assessment { get; set; }
    }
}
