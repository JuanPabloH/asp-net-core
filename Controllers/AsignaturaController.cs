using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp_net_core.Controllers
{
    public class AsignaturaController: Controller
    {
        public IActionResult Index()
        {
            return View(new Asignatura{Nombre="Machine Learning",
                                    UniqueId=Guid.NewGuid().ToString()
                                    });
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matematicas",
                                    UniqueId=Guid.NewGuid().ToString()
                                    },
                    new Asignatura{Nombre="Edu. Fisica",
                                    UniqueId=Guid.NewGuid().ToString()
                                    },
                    new Asignatura{Nombre="Castellano",
                                    UniqueId=Guid.NewGuid().ToString()
                                    },
                    new Asignatura{Nombre="Ciencias Naturales",
                                    UniqueId=Guid.NewGuid().ToString()
                                    },
                    new Asignatura{Nombre="Machine Learning",
                                    UniqueId=Guid.NewGuid().ToString()
                                    }
                    
                };

            ViewBag.Fecha=DateTime.Now;
            
            return View("MultiAsignatura",listaAsignaturas);
        }
    }
}