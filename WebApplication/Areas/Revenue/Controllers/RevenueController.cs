using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.Revenue.Controllers
{
    [Area("Revenue")]
    public class RevenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}