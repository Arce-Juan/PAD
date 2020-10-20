using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.Dominio;
using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public class CambioDivisaPresentador
    {
        private ICambioDivisa interfaz;

        public CambioDivisaPresentador(ICambioDivisa _interfaz)
        {
            interfaz = _interfaz;
        }

        public void CrearYObtenerDivisas()
        {
            var listaDivisas = new List<Divisa>();
            listaDivisas.Add(new Divisa() { Id = 1, Mnonimo = "ARS", Nombre = "PESO ARG" });
            listaDivisas.Add(new Divisa() { Id = 2, Mnonimo = "USD", Nombre = "DOLAR EEUU" });
            listaDivisas.Add(new Divisa() { Id = 3, Mnonimo = "EUR", Nombre = "EURO" });
            listaDivisas.Add(new Divisa() { Id = 4, Mnonimo = "JPY", Nombre = "YEN" });
            interfaz.MostrarDivisas(listaDivisas);
        }

        public void ValidarYCalcular(string tipoOperacion, Divisa divisaOrigen, Divisa divisaDestino, string txtMonto)
        {
            txtMonto = txtMonto.Replace(",", ".");
            if (!float.TryParse(txtMonto, out float number))
                interfaz.MostrarMensaje("El valor ingresado en 'Pagas' tiene un formato no valido", true);
            else
            {
                float resultado = 0F;
                if (tipoOperacion == "COMPRA")
                {
                    float resultadoEnPesos = float.Parse(txtMonto) * divisaOrigen.De1PesoArgA1Divisa_Compra(divisaOrigen);
                    resultado = resultadoEnPesos / divisaOrigen.De1PesoArgA1Divisa_Compra(divisaDestino);
                }
                else
                {
                    float resultadoEnPesos = float.Parse(txtMonto) * divisaOrigen.De1PesoArgA1Divisa_Venta(divisaOrigen);
                    resultado = resultadoEnPesos / divisaOrigen.De1PesoArgA1Divisa_Venta(divisaDestino);
                }
                interfaz.MostrarMontoARecibir(resultado.ToString());
            }
        }
    }
}
