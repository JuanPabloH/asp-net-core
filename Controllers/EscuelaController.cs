using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core.Controllers
{
    public class EscuelaController: Controller
    {
        
        public IActionResult Index()
        {
            var escuela= new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.UniqueId=Guid.NewGuid().ToString();
            escuela.Ciudad="Sogamoso";
            escuela.Pais="Colombia";
            escuela.TipoEscuela=TiposEscuela.Primaria;
            escuela.Dirección="Carrera 12";
            escuela.Nombre="Mi escuela";
            return View(escuela);
        }
    }
}