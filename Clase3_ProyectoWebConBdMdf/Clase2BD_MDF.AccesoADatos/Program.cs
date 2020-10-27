using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2BD_MDF.AccesoADatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GIT\PAD\Clase2BD_MDF\Clase2BD_MDF.AccesoADatos\DBProductos.mdf;Integrated Security=True");
            conexion.Open();

            var resultado1 = EjecutarScript(conexion, "Select count(*) from Producto", "Scalar");
            Console.WriteLine($"Cantidad de registros en la tabla: {resultado1}");

            SqlDataReader resultado2 = EjecutarScript(conexion, "Select * from Producto", "Reader") as SqlDataReader;
            Console.WriteLine($"Cantidad de registros en la tabla: {resultado2}");
            while (resultado2.Read())
            {
                Console.WriteLine($"Producto Id: {resultado2[0]} || Nombre: {resultado2[1]} || Precio: {resultado2[2]}");
            }
            conexion.Close();

            Console.WriteLine("Hola mundo");
            Console.Read();
        }

        public static Object EjecutarScript(SqlConnection _conexion, string script, string tipoEjecucion)
        {
            Object objeto;
            
            Console.WriteLine(_conexion.State); // obtener estado de conexion
            var ejectucion = new SqlCommand(script, _conexion);
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
