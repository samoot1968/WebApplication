using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Areas.Revenue.Models;
using WebApplication.Type;

namespace WebApplication.Data
{
    public partial class ApplicationDbContext
    {

        public DbSet<Salary> salary { get; set; }

        private static void ConfigureSalary(ModelBuilder builder)
        {
            builder.Entity<Salary>()
                .HasOne<User>(u => u.user)
                .WithMany(s => s.salary);
        }
    }
}
