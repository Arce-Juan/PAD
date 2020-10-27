using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Afip.ServicioWeb.Dominio;
using Afip.ServicioWeb.Models;
using Afip.ServicioWeb.ServiciosBD;

namespace Afip.ServicioWeb.ServiciosWeb
{
    /// <summary>
    /// Descripción breve de IFE
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class IFE : System.Web.Services.WebService
    {
        private IFEServicio _IfeServicio = new IFEServicio();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSetAfip ObtenerBeneficiarios()
        {
            return _IfeServicio.ObtenerBeneficiarios();
        }

        [WebMethod]
        public string AgregarUnBeneficiaroConParametros(string preCuil, string documento, string postCuil, string apellido, string nombre)
        {
            if (preCuil == "" || documento == "" || postCuil == "" || apellido == "" || nombre == "")
                return "Alguno de los datos para el Alta no fueron proporcionados";
            
            int number;
            if (!int.TryParse(preCuil, out number) || !int.TryParse(documento, out number) || !int.TryParse(postCuil, out number))
                return "El formato de uno de los datos ingresados no es valido";

            var beneficiario = new BeneficiarioIFE()
            {
                PreCuil = int.Parse(preCuil),
                Documento = int.Parse(documento),
                PostCuil = int.Parse(postCuil),
                Apellido = apellido,
                Nombre = nombre
            };
            _IfeServicio.AgregarNuevoBeneficiario(beneficiario);
            return "Exito!.";
        }

        [WebMethod]
        public string AgregarUnBeneficiaroConClase(BeneficiarioIFE beneficiario)
        {
            return "succes";
        }

        [WebMethod]
        public string VerificarIFEPorDocumento(string documento)
        {
            if (!int.TryParse(documento, out int number))
                return "El documento es vacio o no tiene el formato valido";

            var resultado = _IfeServicio.ObtenerBeneficiarioPorDocumento(int.Parse(documento));
            if (resultado.Count() == 0)
                return "La persona NO cobra IFE";
            return "La persona SI cobra IFE";
        }
    }
}
