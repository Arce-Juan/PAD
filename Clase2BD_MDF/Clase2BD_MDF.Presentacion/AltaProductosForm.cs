using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase2BD_MDF.Presentacion.Dominio;
using Clase2BD_MDF.Presentacion.Interfaces;
using Clase2BD_MDF.Presentacion.Presentadores;

namespace Clase2BD_MDF.Presentacion
{
    public partial class AltaProductosForm : Form, IAltaProductos
    {
        private AltaProductosPresentador presentador;
        public AltaProductosForm()
        {
            presentador = new AltaProductosPresentador(this);
            InitializeComponent();
        }

        private void AltaProductosForm_Load(object sender, EventArgs e)
        {
            presentador.ObtenerUltimoIdDeProduto();
            ActualizarFormulario();
        }
        public void MostrarProductos(List<Producto> listaProductos)
        {
            bsProductos.DataSource = null;
            bsProductos.DataSource = listaProductos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            presentador.AgregarProductoYActualizarPantalla(tbId.Text, tbNombre.Text, tbPrecio.Text);
        }

        public void MostrarMensaje(string mensaje, bool esError)
        {
            if (esError)
                MessageBox.Show(mensaje, "Casa de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(mensaje, "Casa de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarUltimoId(int nuevoId)
        {
            tbId.Text = nuevoId.ToString();
        }

        public void ActualizarFormulario()
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            presentador.ObtenerUltimoIdDeProduto();
            presentador.ObtenerTodosLosProdutos();
        }
    }
}
