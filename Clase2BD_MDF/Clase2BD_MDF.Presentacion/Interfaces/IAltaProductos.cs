using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2BD_MDF.Presentacion.Dominio;

namespace Clase2BD_MDF.Presentacion.Interfaces
{
    public interface IAltaProductos
    {
        void MostrarUltimoId(int nuevoId);
        void MostrarProductos(List<Producto> listaProductos);
        void MostrarMensaje(string mensaje, bool esError);
        void ActualizarFormulario();
    }
}
