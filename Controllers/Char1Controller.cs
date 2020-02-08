using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcChar1.Controllers
{
    public class Char1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}