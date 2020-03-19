using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {   
        [HttpGet("principal/{numero:int?}/{nome}")]
        public IActionResult Index(int numero, string nome)
        {
            return Content("O número é " + numero + " E o nome é " + nome);
        }

        [HttpGet("son")]
        public IActionResult schoolOfNet()
        {
            var nome = Request.Query["nome"];
            return Content("Aprendendo ASP.NET Core na School of net!" + nome);
        }
    }
}
