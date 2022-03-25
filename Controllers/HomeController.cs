using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyectocontrolar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectocontrolar.Controllers
{
    public class HomeController : Controller
    {
  

      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
