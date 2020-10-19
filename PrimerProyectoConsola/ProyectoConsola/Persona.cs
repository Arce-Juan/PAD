using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola
{
    public class Persona
    {
        public int Id { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        private int edad;
        public int Edad
        {
            get {
                return edad;
            }
            set {
                if (value < 0)
                    edad = 0;
                else
                    edad = value;
            }
        }
        public string NombreCompleto()
        {
            return this.Apellidos + ", " + this.Nombres;
        }
        public virtual string Saludar()
        {
            return $"Hola! soy una persona y me llamo {this.NombreCompleto()}, tengo {this.Edad} años";
        }
    }
}
