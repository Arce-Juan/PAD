using System;
using System.Collections.Generic;
using System.Data;
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

        public Object EjecutarScript(string script, TipoEjecucionSql tipoEjecucion)
        {
            conexion.Open();
            Object objeto;
            var ejectucion = new SqlCommand(script, conexion);
            switch (tipoEjecucion)
            {
                case TipoEjecucionSql.Scalar:
                    objeto = ejectucion.ExecuteScalar();
                    break;
                case TipoEjecucionSql.Reader:
                    objeto = ejectucion.ExecuteReader(); // obtiene todas las filas de la tabla
                    break;
                case TipoEjecucionSql.NonQuery:
                    objeto = ejectucion.ExecuteNonQuery();
                    break;
                default:
                    objeto = null;
                    break;
            }
            //conexion.Close();
            return objeto;
        }

        public DataSet ObtenerTodosLosProductos()
        {
            var script = "select * from Producto";
            return RetornarUnDataSetSegunUnScript(script);
        }

        public Object ObtenerProductosPorId(int id)
        {
            var script = "select * from Producto as pro where pro.Id = " + id.ToString();
            return EjecutarScript(script, TipoEjecucionSql.Reader) ;
            
        }

        private DataSet RetornarUnDataSetSegunUnScript(string script)
        {
            AbrirConexion();
            var comando = new SqlCommand(script, conexion);
            var adaptador = new SqlDataAdapter(comando);
            var dataSet = new DataSet();
            adaptador.Fill(dataSet);
            CerrarConexion();
            return dataSet;
        }

        public void AltaDeProducto(string nombre, string precio)
        {
            GestionDeProductos(TipoOperacion.ALTA, nombre, precio);
        }
        public void BajaDeProducto(int idProducto)
        {
            GestionDeProductos(TipoOperacion.BAJA, idProducto: idProducto);
        }

        private DataSet GestionDeProductos(TipoOperacion operacion, string nombre = "", string precio = "", int idProducto = 0)
        {
            CerrarConexion();
            var command = new SqlCommand("select * from producto", conexion);
            var adaptador = new SqlDataAdapter(command);

            var commandbuilder = new SqlCommandBuilder(adaptador);

            adaptador.UpdateCommand = commandbuilder.GetUpdateCommand();
            adaptador.DeleteCommand = commandbuilder.GetDeleteCommand();
            adaptador.InsertCommand = commandbuilder.GetInsertCommand();
            var dataset = new DataSet();

            adaptador.Fill(dataset);

            switch (operacion)
            {
                case TipoOperacion.ALTA:
                    var fila = dataset.Tables[0].NewRow();
                    fila["nombre"] = nombre;
                    fila["precio"] = precio;
                    dataset.Tables[0].Rows.Add(fila);
                    break;
                case TipoOperacion.MODIFICACION:
                     
                    break;
                case TipoOperacion.BAJA:
                    int filaEliminar = BuscarFilaPorIdProducto(idProducto);
                    dataset.Tables[0].Rows[filaEliminar].Delete();
                    break;
                default:
                    return null;
            }
            CerrarConexion();
            adaptador.Update(dataset.Tables[0]);
            return dataset;
        }

        private int BuscarFilaPorIdProducto(int idProducto)
        {
            CerrarConexion();
            var resultado = EjecutarScript("Select * from Producto", TipoEjecucionSql.Reader) as SqlDataReader;
            int fila = 0;
            while (resultado.Read())
            {
                if (int.Parse(resultado[0].ToString()) == idProducto)
                    return fila;
                fila++;
            }
            return fila;
        }

        private enum TipoOperacion
        {
            ALTA,
            BAJA,
            MODIFICACION
        }

    }
}
