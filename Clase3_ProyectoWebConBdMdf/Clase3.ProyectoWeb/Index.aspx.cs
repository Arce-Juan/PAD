using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clase2BD_MDF.AccesoADatos;
namespace Clase3.ProyectoWeb
{
    public partial class Index : System.Web.UI.Page
    {
        private ServiciosDB _servicios;
        protected void Page_Load(object sender, EventArgs e)
        {
            _servicios = new ServiciosDB();
            ActualizarGrilla();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            OcultarMensajes();
            if (txtNombre.Text == "" || txtPrecio.Text == "" || !float.TryParse(txtPrecio.Text, out float number))
            {
                MostrarMensaje(labelMensajeAlta, "No se puede agregar el producto. El formato no es valido o vacio", TipoMensajeRetorno.ERROR);
                return;
            }
            _servicios.AltaDeProducto(txtNombre.Text, txtPrecio.Text);
            MostrarMensaje(labelMensajeAlta, "Producto agregado", TipoMensajeRetorno.OK);
            LimpiarFormulario();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            gvProductos.DataSource = null;
            var lista = _servicios.ObtenerTodosLosProductos();
            gvProductos.DataSource = lista;
            gvProductos.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OcultarMensajes();
            if (txtIdEliminar.Text == "" || !int.TryParse(txtIdEliminar.Text, out int number))
            {
                MostrarMensaje(labelMensajeBaja, "No se puede Eliminar el producto. El formato no es valido o vacio", TipoMensajeRetorno.ERROR);
                return;
            }
            var producto = _servicios.ObtenerProductosPorId(int.Parse(txtIdEliminar.Text)) as SqlDataReader;

            if(!producto.Read())
            {
                MostrarMensaje(labelMensajeBaja, "No se puede Eliminar el producto. No se encontro el ID del producto", TipoMensajeRetorno.ERROR);
                _servicios.CerrarConexion();
                return;
            }

            _servicios.BajaDeProducto(int.Parse(txtIdEliminar.Text));
            LimpiarFormulario();
            ActualizarGrilla();
            MostrarMensaje(labelMensajeBaja, "Producto eliminado", TipoMensajeRetorno.OK);
        }

        private void MostrarMensaje(Label label, string mensaje, TipoMensajeRetorno tipo)
        {
            label.Text = mensaje;
            label.Visible = true;
            switch (tipo)
            {
                case TipoMensajeRetorno.ERROR:
                    label.BackColor = Color.Red;
                    break;
                case TipoMensajeRetorno.OK:
                    label.BackColor = Color.Green;
                    break;
                case TipoMensajeRetorno.INFO:
                default:
                    label.BackColor = Color.Yellow;
                    break;
            }
        }

        private void OcultarMensajes()
        {
            labelMensajeAlta.Visible = false;
            labelMensajeBaja.Visible = false;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtIdEliminar.Text = "";
        }

    }
}