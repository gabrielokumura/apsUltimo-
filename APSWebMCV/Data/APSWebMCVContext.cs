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

        public DbSet<APSWebMCV.Models.Department> Department { get; set; }
    }
}
