using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final.SQL
{
    /// <summary>
    /// En esta clase se manjerán los métodos para buscar, eliminar y actualizar en la base de datos
    /// </summary>
    class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True");
        private DataSet ds;

        /// <summary>
        /// Muestra los datos de una tabla
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <returns>Retrona los datos de la tabla</returns>
        public DataTable MostrarDatos(string tabla)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0};", tabla), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        /// <summary>
        /// Busca un elemento de la base de datos por nombre
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <param name="nombre">El nombre que se quiere buscar</param>
        /// <returns>Retrona los datos encontrados</returns>
        public DataTable BuscarNombre(string tabla, string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0} where Nombre = '{1}';", tabla, nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        /// <summary>
        /// Busca un elemento de la base de datos por Identificación
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <param name="identificacion">La identificación que se quiere buscar</param>
        /// <returns>Retorna los datos encontrados</returns>
        public DataTable BuscarIdentificacion(string tabla, string identificacion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0} where Identificacion = {1};", tabla, identificacion), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        /// <summary>
        /// Busca un elemento por identificación y nombre al mismo tiempo
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <param name="identificacion">La identificación que se quiere buscar</param>
        /// <param name="nombre">El nombre que se quiere buscar</param>
        /// <returns>Retorna los datos encontrados</returns>
        public DataTable BuscarAmbos(string tabla, string identificacion, string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0} where Identificacion = {1} AND Nombre = '{2}';", tabla, identificacion, nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        /// <summary>
        /// Elimina un elemento de la base de datos
        /// </summary>
        /// <param name="tabla">Nombre de la tabla de donde se quiere eliminar un elemento</param>
        /// <param name="codigo">El código del elemento que se quiere borrar</param>
        /// <returns>Se elimina: true. No elimina: false.</returns>
        public bool Eliminar(string tabla, string codigo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from tbl_{0} where Codigo = {1};", tabla, codigo), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

    }
}