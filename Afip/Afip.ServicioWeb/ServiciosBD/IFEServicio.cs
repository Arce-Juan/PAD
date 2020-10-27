using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using Afip.ServicioWeb.Models;
using Afip.ServicioWeb.Models.DataSetAfipTableAdapters;

namespace Afip.ServicioWeb.ServiciosBD
{
    public class IFEServicio
    {
        private DataSetAfip _dataSet;
        private BeneficiarioIFETableAdapter _adaptador;

        public IFEServicio()
        {
            _dataSet = new DataSetAfip();
            _adaptador = new BeneficiarioIFETableAdapter();
        }

        public void AgregarNuevoBeneficiario(int preCuil, int documento, int postCuil, string apellido, string nombre)
        {
            _adaptador.Insert(preCuil, documento, postCuil, apellido, nombre);
        }

        public DataSetAfip ObtenerBeneficiarios()
        {
            _adaptador.Fill(_dataSet.BeneficiarioIFE);
            return _dataSet;
        }

        public DataSetAfip.BeneficiarioIFEDataTable ObtenerBeneficiarioPorDocumento(int documento)
        {
            return _adaptador.GetDataByDocumento(documento);
        }
    }
}