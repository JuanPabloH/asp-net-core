using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core.Controllers
{
    public class CursoController: Controller
    {
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso= from cur in _context.Cursos
                            where cur.Id == id
                            select cur;

                return View(curso.SingleOrDefault()); 
            }else
            {
                return View("MultiCurso",_context.Cursos);
            }
            
        }
        public IActionResult MultiCurso()
        {
            ViewBag.Fecha=DateTime.Now;
            return View("MultiCurso",_context.Cursos);
        }

        public IActionResult Create()
        {
            ViewBag.Fecha=DateTime.Now;


            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha=DateTime.Now;
            if(ModelState.IsValid)
            {
                var escuela=_context.Escuelas.FirstOrDefault();
                curso.EscuelaId=escuela.Id;

                _context.Cursos.Add(curso);
                _context.SaveChanges();
                return View("Index",curso);
            }
            else
            {
                return View(curso);
            }

            

            
        }


        private EscuelaContext _context;
        public CursoController(EscuelaContext context)        
        {
            _context=context;
        }
    }
}