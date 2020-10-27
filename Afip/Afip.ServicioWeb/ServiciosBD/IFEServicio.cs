using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using Afip.ServicioWeb.Dominio;
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

        public void AgregarNuevoBeneficiario(BeneficiarioIFE beneficiario)
        {
            _adaptador.Insert(beneficiario.PreCuil, beneficiario.Documento, beneficiario.PostCuil, beneficiario.Apellido, beneficiario.Nombre);
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