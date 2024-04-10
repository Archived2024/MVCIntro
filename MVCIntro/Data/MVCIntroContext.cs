using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCIntro.Models;

namespace MVCIntro.Data
{
    public class MVCIntroContext : DbContext
    {
        public MVCIntroContext (DbContextOptions<MVCIntroContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
