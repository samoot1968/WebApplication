using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Areas.Revenue.Models;
using WebApplication.Data;

namespace WebApplication.Areas.Revenue.Controllers
{
    [Area("Revenue")]
    public class RevenueController : Controller
    {
        private ApplicationDbContext _context;
        public RevenueController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var getList = (from list in _context.salary orderby list.Id descending select list).ToList();

            return View(getList);
        }

    }
}