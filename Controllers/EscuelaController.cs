using System;
using System.Linq;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core.Controllers
{
    public class EscuelaController: Controller
    {

        
        
        public IActionResult Index()
        {
            
            var escuela=_context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)        
        {
            _context=context;
        }
    }
}