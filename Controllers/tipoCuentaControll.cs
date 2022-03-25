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
    public class tipoCuentaControll:Controller
    {
       


        public IActionResult Crear()
        {
            return View();
        }

    
    }
}
