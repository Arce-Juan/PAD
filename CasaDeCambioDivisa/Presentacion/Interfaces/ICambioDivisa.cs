using Presentacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Interfaces
{
    public interface ICambioDivisa
    {
        void MostrarDivisas(List<Divisa> listaDivisas);
        void MostrarMensaje(string mensaje, bool esError);
        void MostrarMontoARecibir(string montoARecibir);


    }
}
