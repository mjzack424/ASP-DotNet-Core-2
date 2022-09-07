using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Salam Farmande");
        }
    }
}
