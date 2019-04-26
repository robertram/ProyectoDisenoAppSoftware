using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Otras
{
    /// <summary>
    /// Esta clase contiene el metodo utilizado para Validar el Login
    /// </summary>
    public class MetodosLogin
    {
        /// <summary>
        /// Este metodo valida que se ingresen los datos del login correctamente
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns>true= si el usuario y contraseña son correctos
        /// false= si alguno o los dos campos son incorrectos</returns>
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

        /*
          
        Opción Futura para cambiar el usuario  
         
        USE [Prueba]
        GO

        UPDATE [dbo].[tbl_Usuario]
        SET [Usuario] = "usuarioNuevo"
        ,[Contraseña] = "contraseñaNueva"
        GO
         
         
         */
    }
}
