using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HolaMundoMVC.Controllers
{
    [Route("[controller]")]
    public class EscuelaController : Controller
    {
        private readonly ILogger<EscuelaController> _logger;

        public EscuelaController(ILogger<EscuelaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Escuela escuela = new Escuela();
            escuela.Nombre = "Platzi Academy";
            escuela.AñoDeCreacion = 2012;
            return View(escuela);
        }

    }
}