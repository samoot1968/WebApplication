using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Areas.Revenue.Models
{
    public class Salary
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
        public User user { get; set; }
    }
}
