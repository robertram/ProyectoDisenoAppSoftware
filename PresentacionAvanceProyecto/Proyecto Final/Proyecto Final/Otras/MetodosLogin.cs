using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Otras
{
    /// <summary>
    /// Esta clase contiene el metodo utilizado para el Login
    /// </summary>
    public class MetodosLogin
    {
        /// <summary>
        /// Este metodo valida que se ingresen los datos correctamente
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns>Boolean</returns>
        public bool RevisarLogin(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
