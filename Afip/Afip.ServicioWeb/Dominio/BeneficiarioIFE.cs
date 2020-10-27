using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Afip.ServicioWeb.Dominio
{
    public class BeneficiarioIFE
    {
        public int Id { get; set; }
        public int PreCuil { get; set; }
        public int Documento { get; set; }
        public int PostCuil { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

    }
}