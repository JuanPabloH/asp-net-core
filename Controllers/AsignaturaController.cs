using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core.Controllers
{
    public class AsignaturaController: Controller
    {
        public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura()
        {
            

            ViewBag.Fecha=DateTime.Now;
            
            return View("MultiAsignatura",_context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)        
        {
            _context=context;
        }
    }
}