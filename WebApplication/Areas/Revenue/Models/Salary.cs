using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Type;

namespace WebApplication.Areas.Revenue.Models
{
    public class Salary
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public string Comment { get; set; }

        public User user { get; set; }
    }
}
