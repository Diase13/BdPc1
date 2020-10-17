using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pc1.Models;
using Pc1.Data;

namespace Pc1.Controllers
{
    public class PracticaController : Controller
    {

       private readonly ILogger<PracticaController> _logger;
       private readonly DatabaseContext _context;
        public PracticaController(ILogger<PracticaController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Practica objPractica){
            if (ModelState.IsValid)
            {
                
                //grabar
                _context.Add(objPractica);
                _context.SaveChanges();
                objPractica.Response = "Gracias estamos en contacto";
            }
            return View("index", objPractica);
        }

    }
}