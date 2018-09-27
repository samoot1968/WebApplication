using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Type;
namespace WebApplication.Data
{
    public partial class ApplicationDbContext
    {
        private static void ConfigureUserTable(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users");
        }
    }
}
