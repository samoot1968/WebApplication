using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Areas.Revenue.Models;

namespace WebApplication.Models
{
    public class User :IdentityUser
    {
        public ICollection<Salary> salary { get; set; }
    }
}
