using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2BD_MDF.AccesoADatos
{
    public class ServiciosDB
    {
        private SqlConnection conexion;
        
        public ServiciosDB()
        {
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GIT\PAD\Clase2BD_MDF\Clase2BD_MDF.AccesoADatos\DBProductos.mdf;Integrated Security=True");
        }

        public void AbrirConexion()
        {
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        public Object EjecutarScript(string script, string tipoEjecucion)
        {
            Object objeto;

            Console.WriteLine(conexion.State); // obtener estado de conexion
            var ejectucion = new SqlCommand(script, conexion);
            switch (tipoEjecucion)
            {
                case "Scalar":
                    objeto = ejectucion.ExecuteScalar();
                    break;
                case "Reader":
                    objeto = ejectucion.ExecuteReader(); // obtiene todas las filas de la tabla
                    break;
                case "NonQuery":
                    objeto = ejectucion.ExecuteNonQuery();
                    break;
                default:
                    objeto = null;
                    break;
            }
            //_conexion.Close();
            return objeto;
        }
    }
}
