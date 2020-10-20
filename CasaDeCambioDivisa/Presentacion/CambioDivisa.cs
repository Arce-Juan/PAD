using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Presentadores;
using Presentacion.Interfaces;
using Presentacion.Dominio;

namespace Presentacion
{
    public partial class CambioDivisa : Form, ICambioDivisa
    {
        private CambioDivisaPresentador presentador;

        public CambioDivisa()
        {
            presentador = new CambioDivisaPresentador(this);
            InitializeComponent();
        }

        private void CambioDivisa_Load(object sender, EventArgs e)
        {
            presentador.CrearYObtenerDivisas();
        }

        public void MostrarDivisas(List<Divisa> listaDivisas)
        {
            bsDivisaOrigen.DataSource = listaDivisas;
            bsDivisaDestino.DataSource = listaDivisas;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var tipoOperacion = rbCompra.Checked == true ? "COMPRA" : "VENTA";
            var divisaOrigen = (bsDivisaOrigen.Current as Divisa);
            var divisaDestino = (bsDivisaDestino.Current as Divisa);
            presentador.ValidarYCalcular(tipoOperacion, divisaOrigen, divisaDestino, tbEnvias.Text);
        }

        public void MostrarMensaje(string mensaje, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(mensaje, "Casa de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEnvias.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Casa de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarMontoARecibir(string montoARecibir)
        {
            tbRecibes.Text = montoARecibir;
        }
    }
}
