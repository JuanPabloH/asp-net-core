using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core.Controllers
{
    public class AlumnoController: Controller
    {
        public IActionResult Index()
        {
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {
            ViewBag.Fecha=DateTime.Now;
            return View("MultiAlumno",_context.Alumnos);
        }
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)        
        {
            _context=context;
        }
    }
}