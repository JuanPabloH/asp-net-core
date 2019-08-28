using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace asp_net_core.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {
            
        }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Ciudad = "Sogamoso";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            escuela.Dirección = "Carrera 12";
            escuela.Nombre = "Mi escuela";

            //Cargar cursos de la escuela

            var cursos = CargarCursos(escuela);

            //por cada curso  cargar asignaturas 

            var asignaturas=CargarAsignaturas(cursos);

            //por cada curso  cargar alumnos

            var alumnos= CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());


        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {

            var listaAsig= new List<Asignatura>();
            foreach (var curso in cursos)
            {

                var tmpList= new List<Asignatura>(){
                    new Asignatura { Nombre = "Matematicas", Id = Guid.NewGuid().ToString() , CursoId=curso.Id},
                    new Asignatura { Nombre = "Edu. Fisica", Id = Guid.NewGuid().ToString(), CursoId=curso.Id },
                    new Asignatura { Nombre = "Castellano", Id = Guid.NewGuid().ToString() , CursoId=curso.Id},
                    new Asignatura { Nombre = "Ciencias Naturales", Id = Guid.NewGuid().ToString() , CursoId=curso.Id},
                    new Asignatura { Nombre = "Machine Learning", Id = Guid.NewGuid().ToString(), CursoId=curso.Id }

                };
                listaAsig.AddRange(tmpList);
               // curso.Asignaturas = tmpList;

            }
            return listaAsig;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>(){
                        new Curso() { Id=Guid.NewGuid().ToString(),EscuelaId=escuela.Id,Nombre = "101", Jornada = TiposJornada.Mañana},
                        new Curso() {Id=Guid.NewGuid().ToString(),EscuelaId=escuela.Id,Nombre = "201", Jornada = TiposJornada.Mañana},
                        new Curso() {Id=Guid.NewGuid().ToString(),EscuelaId=escuela.Id,Nombre = "301", Jornada = TiposJornada.Mañana},
                        new Curso() {Id=Guid.NewGuid().ToString(),EscuelaId=escuela.Id, Nombre = "401", Jornada = TiposJornada.Tarde},
                        new Curso() {Id=Guid.NewGuid().ToString(),EscuelaId=escuela.Id,Nombre = "501", Jornada = TiposJornada.Tarde},
            };
        }

        private List<Alumno> GenerarAlumnosAlAzar(
                                Curso curso,
                                int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   CursoId=curso.Id,
                                   Nombre = $"{n1} {n2} {a1}", 
                                   //opcional
                                   Id=Guid.NewGuid().ToString()
                                   };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }



        public List<Alumno> CargarAlumnos(List<Curso> cursos){
            var listaAlumnos=new List<Alumno>();


            Random rnd = new Random();
            foreach (var c in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmpList = GenerarAlumnosAlAzar(c,cantRandom);
                listaAlumnos.AddRange(tmpList);
            }
            return listaAlumnos;
        }
    }
}