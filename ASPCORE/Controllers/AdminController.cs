using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return Content("Olá Mundo  - School of Net");
        }

        public IActionResult schoolOfNet()
        {
            return Content("Aprendendo ASP.NET Core na School of net!");
        }
    }
}
