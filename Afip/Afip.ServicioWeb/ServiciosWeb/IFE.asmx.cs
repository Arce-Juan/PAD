using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
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
