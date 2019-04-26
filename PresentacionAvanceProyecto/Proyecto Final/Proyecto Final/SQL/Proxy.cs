using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.SQL
{
    /// <summary>
    /// Clase del Patrón Proxy que maneja el String de Conexión de la Base de Datos y la instancia de SqlConnection
    /// </summary>
    public class Proxy
    {
        //String de Conexión a la Base de Datos
        static string StringConexion = "Data Source=603-13;Initial Catalog=Prueba;Integrated Security=True";

        //Instancia de SqlConnection
        public SqlConnection conexionSql = new SqlConnection(StringConexion);

        //Instancia de SqlCommand
        public SqlCommand command = new SqlCommand();

    }
}
