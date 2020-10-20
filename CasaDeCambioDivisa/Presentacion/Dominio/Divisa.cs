using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Dominio
{
    public class Divisa
    {
        public int Id { get; set; }
        public string Mnonimo { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{this.Mnonimo} - {this.Nombre}";
        }

        public float De1PesoArgA1Divisa_Compra(Divisa _divisa)
        {
            switch (_divisa.Id)
            {
                case 1: //ARS
                    return 1F;
                case 2: //USD
                    return 77.57F;
                case 3: //EUR
                    return 83.72F;
                case 4: //JPY
                    return 0.09F;
                default:
                    return 0F;
            }
        }

        public float De1PesoArgA1Divisa_Venta(Divisa _divisa)
        {
            switch (_divisa.Id)
            {
                case 1: //ARS
                    return 1F;
                case 2: //USD
                    return 83.52F;
                case 3: //EUR
                    return 89.94F;
                case 4: //JPY
                    return 0.05F;
                default:
                    return 0F;
            }
        }
    }
}
