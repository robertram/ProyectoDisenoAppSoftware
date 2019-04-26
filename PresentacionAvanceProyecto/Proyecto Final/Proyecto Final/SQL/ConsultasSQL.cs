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
        private DataSet ds;

        /// <summary>
        /// Muestra los datos de una tabla
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <returns>Retrona los datos de la tabla</returns>
        public DataTable MostrarDatos(string tabla, Proxy proxy)
        {
            proxy.conexionSql.Open();//Abre la conexión
            if (tabla != "Niños" && tabla != "Encargados") //Si la tabla es diferente de Niños y diferente de Encargados
            {
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0};", tabla), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else if (tabla == "Niños") //Si tabla es igual a Niños
            {
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_Nino;", tabla), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else //Sino
            {
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_EncargadoNino;", tabla), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }

        }

        /// <summary>
        /// Busca un elemento de la base de datos por nombre
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <param name="nombre">El nombre que se quiere buscar</param>
        /// <returns>Retrona los datos encontrados</returns>
        public DataTable BuscarNombre(string tabla, string nombre, Proxy proxy)
        {
            if (tabla != "Niños" && tabla != "Encargados") //Si la tabla es diferente de Niños y diferente de Encargados
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0} where Nombre = '{1}';", tabla, nombre), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            if (tabla == "Niños") //Si tabla es igual a Niños
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_Nino where Nombre = '{0}';", nombre), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else //Sino
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_EncargadoNino where Nombre = '{0}';", nombre), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }

        }

        /// <summary>
        /// Busca un elemento de la base de datos por Identificación
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <param name="identificacion">La identificación que se quiere buscar</param>
        /// <returns>Retorna los datos encontrados</returns>
        public DataTable BuscarIdentificacion(string tabla, string identificacion, Proxy proxy)
        {
            if (tabla != "Niños" && tabla != "Encargados") //Si la tabla es diferente de Niños y diferente de Encargados
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0} where Identificacion = '{1}';", tabla, identificacion), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else if (tabla == "Niños")
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_Nino where Identificacion = '{0}';", identificacion), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else //Sino
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_EncargadoNino where Identificacion = '{0}';", identificacion), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            
        }

        /// <summary>
        /// Busca un elemento por identificación y nombre al mismo tiempo
        /// </summary>
        /// <param name="tabla">Nombre de la tabla en la que se desea buscar</param>
        /// <param name="identificacion">La identificación que se quiere buscar</param>
        /// <param name="nombre">El nombre que se quiere buscar</param>
        /// <returns>Retorna los datos encontrados</returns>
        public DataTable BuscarAmbos(string tabla, string identificacion, string nombre, Proxy proxy)
        {
            if (tabla != "Niños" && tabla != "Encargados") //Si la tabla es diferente de Niños y diferente de Encargados
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_{0} where Identificacion = '{1}' AND Nombre = '{2}';", tabla, identificacion, nombre), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else if (tabla == "Niños")
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_Nino where Identificacion = '{0}' AND Nombre = '{1}';", identificacion, nombre), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            else //Sino
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_EncargadoNino where Identificacion = '{0}' AND Nombre = '{1}';", identificacion, nombre), proxy.conexionSql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                proxy.conexionSql.Close(); //Se cierra la conexión
                return ds.Tables["tabla"];
            }
            
        }

        /// <summary>
        /// Elimina un elemento de la base de datos
        /// </summary>
        /// <param name="tabla">Nombre de la tabla de donde se quiere eliminar un elemento</param>
        /// <param name="codigo">El código del elemento que se quiere borrar</param>
        /// <returns>Se elimina: true. No elimina: false.</returns>
        public bool Eliminar(string tabla, string codigo, Proxy proxy)
        {
            int filasafectadas = 0;
            if (tabla != "Niños" && tabla != "Encargados")//Si la tabla es diferente de Niños y diferente de Encargados
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("delete from tbl_{0} where Codigo = {1};", tabla, codigo), proxy.conexionSql);
                filasafectadas = cmd.ExecuteNonQuery();
                proxy.conexionSql.Close(); //Se cierra la conexión
            }
            else if (tabla == "Niños")
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("delete from tbl_Nino where Codigo = {0};", codigo), proxy.conexionSql);
                filasafectadas = cmd.ExecuteNonQuery();
                proxy.conexionSql.Close(); //Se cierra la conexión
            }
            else //Sino
            {
                proxy.conexionSql.Open(); //Se abre la conexión
                SqlCommand cmd = new SqlCommand(string.Format("delete from tbl_EncargadoNino where Codigo = {0};", codigo), proxy.conexionSql);
                filasafectadas = cmd.ExecuteNonQuery();
                proxy.conexionSql.Close(); //Se cierra la conexión
            }

            if (filasafectadas > 0) return true;
            else return false;
        }

    }
}