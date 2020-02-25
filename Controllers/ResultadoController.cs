using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Numeros_Binarios_ASP.Models;

namespace Numeros_Binarios_ASP.Controllers
{
    public class ResultadoController : Controller
    {

        [HttpPost]
        public IActionResult ResultadoView(Numeros numeros)
        {

            for (int i = 0; i < 10; i++)
            {
                ViewData["Binario " + i] = Convert.ToString(numeros.Numero[i], 2);
            }
            return View(numeros);
        }
    }
}