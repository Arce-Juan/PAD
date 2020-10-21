using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2BD_MDF.AccesoADatos;
using Clase2BD_MDF.Presentacion.Dominio;
using Clase2BD_MDF.Presentacion.Interfaces;

namespace Clase2BD_MDF.Presentacion.Presentadores
{
    public class AltaProductosPresentador
    {
        private IAltaProductos interfaz;
        private ServiciosDB _servicioBD;

        public AltaProductosPresentador(IAltaProductos _interfaz)
        {
            _servicioBD = new ServiciosDB();
            interfaz = _interfaz;
        }

        public void ObtenerUltimoIdDeProduto()
        {
            _servicioBD.AbrirConexion();
            var resultado1 = _servicioBD.EjecutarScript("Select top(1) * from Producto as prod order by prod.Id desc", "Reader") as SqlDataReader;
            int nuevoId = 0;
            if (resultado1.Read())
                nuevoId = int.Parse(resultado1[0].ToString()) + 1;
            _servicioBD.CerrarConexion();
            interfaz.MostrarUltimoId(nuevoId);
        }

        public void ObtenerTodosLosProdutos()
        {
            var listaProductos = new List<Producto>();
            _servicioBD.AbrirConexion();
            var resultado = _servicioBD.EjecutarScript("Select * from Producto", "Reader") as SqlDataReader;
            while (resultado.Read())
            {
                var producto = new Producto()
                {
                    Id = int.Parse(resultado[0].ToString()),
                    Nombre = resultado[1].ToString(),
                    Precio = float.Parse(resultado[2].ToString()),
                };
                listaProductos.Add(producto);
            }
            _servicioBD.CerrarConexion();
            interfaz.MostrarProductos(listaProductos);
        }

        public void AgregarProductoYActualizarPantalla(string txtId, string txtNombre, string txtPrecio)
        {
            txtPrecio = txtPrecio.Replace(",", ".");
            //validaciones
            if (txtNombre == "")
            {
                interfaz.MostrarMensaje("El Nombre no fue ingresado", true);
                return;
            }
            if (txtPrecio == "" || !float.TryParse(txtPrecio, out float number))
            {
                interfaz.MostrarMensaje("El Precio no fue ingresado o tiene un formato no valido ", true);
                return;
            }
            // guardar registros
            var scriptAlta = $"insert into Producto values('{txtNombre}', {txtPrecio})";
            _servicioBD.AbrirConexion();
            var resultado = _servicioBD.EjecutarScript(scriptAlta, "NonQuery");
            _servicioBD.CerrarConexion();
            interfaz.ActualizarFormulario();
        }


    }
}
