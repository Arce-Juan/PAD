using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola
{
    public class Alumno : Persona
    {
        public int Legajo { get; set; }
        public override string Saludar()
        {
            return $"Hola! Soy un alumno, mi Apellido y Nombre son {this.Apellidos + " - " + this.Nombres} y mi legajo es: {this.Legajo}";
        }
    }
}
