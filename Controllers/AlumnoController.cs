using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core.Controllers
{
    public class AlumnoController: Controller
    {
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{alumnoId}")]
        public IActionResult Index(string alumnoId)
        {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {
                var alumno= from alum in _context.Alumnos
                            where alum.Id == alumnoId
                            select alum;

                return View(alumno.SingleOrDefault()); 
            }else
            {
                return View("MultiAlumno",_context.Alumnos);
            }
            
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