using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*** Creamos una nueva persona ***");
            var persona = new Persona()
            {
                Id = 1,
                Apellidos = "Arce",
                Nombres = "Juan Eduardo",
                Edad = 32
            };
            Console.WriteLine("");
            Console.WriteLine($"La persona es: {persona.NombreCompleto()} de Edad: {persona.Edad}" );
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*** Creamos una lista de personas y alumnos ***");
            var listaPersonas = new List<Persona>();
            listaPersonas.Add(persona);
            listaPersonas.Add(new Alumno() { Legajo = 100, Apellidos = "Tarifa", Nombres = "Marcos" });
            listaPersonas.Add(new Persona() { Id = 2, Apellidos = "Gimenez Aguilar", Nombres = "Jessica Paola", Edad = 30 });
            listaPersonas.Add(new Alumno() { Legajo = 101, Apellidos = "Vazquez", Nombres = "Milagros" });
            listaPersonas.Add(new Persona() { Id = 3, Apellidos = "Fernandez", Nombres = "Matias", Edad = 28 });
            listaPersonas.Add(new Alumno() { Legajo = 102, Apellidos = "Aguilar", Nombres = "David" });
            foreach (var _persona in listaPersonas)
                Console.WriteLine("Ejecutar saludo || " + _persona.Saludar());
            Console.ReadKey();
        }
    }
}
