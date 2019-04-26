using Proyecto_Final.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.SQL
{
    public class ValidacionDatos
    {
        /// <summary>
        /// Valida los campos de la pestaña Padrino
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>true = ningun campo está vacío
        /// false= hay algún campo vacío</returns>
        public bool Validacion_Padrino(Persona persona)
        {
            if (string.IsNullOrWhiteSpace(persona.fecha)
            || string.IsNullOrWhiteSpace(persona.nombre)
            || string.IsNullOrWhiteSpace(persona.primerApellido)
            || string.IsNullOrWhiteSpace(persona.segundoApellido)
            || string.IsNullOrWhiteSpace(persona.telefono)
            || string.IsNullOrWhiteSpace(persona.profesion)
            || string.IsNullOrWhiteSpace(persona.domicilio)
            || string.IsNullOrWhiteSpace(persona.inscripcion)
            || string.IsNullOrWhiteSpace(persona.donacion)
            )
            {
                return false;
            }else{
                return true;
            }
        }

        /// <summary>
        /// Valida los campos de la pestaña Patrocinador
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>true = ningun campo está vacío
        /// false= hay algún campo vacío</returns>
        public bool Validacion_Patrocinador(Persona persona)
        {
            if (string.IsNullOrWhiteSpace(persona.nombreEmpresa)
            || string.IsNullOrWhiteSpace(persona.tipoEmpresa)
            || string.IsNullOrWhiteSpace(persona.tipoPatrocinio)
            || string.IsNullOrWhiteSpace(persona.nombre)
            || string.IsNullOrWhiteSpace(persona.primerApellido)
            || string.IsNullOrWhiteSpace(persona.segundoApellido)
            || string.IsNullOrWhiteSpace(persona.telefono)
            )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Valida los campos de la pestaña Voluntario
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>true = ningun campo está vacío
        /// false= hay algún campo vacío</returns>
        public bool Validacion_Voluntario(Persona persona)
        {
            if (string.IsNullOrWhiteSpace(persona.nombre)
            || string.IsNullOrWhiteSpace(persona.fecha)
            || string.IsNullOrWhiteSpace(persona.primerApellido)
            || string.IsNullOrWhiteSpace(persona.segundoApellido)
            || string.IsNullOrWhiteSpace(persona.telefono)
            || string.IsNullOrWhiteSpace(persona.profesion)
            || string.IsNullOrWhiteSpace(persona.domicilio)
            || string.IsNullOrWhiteSpace(persona.inscripcion)
            || string.IsNullOrWhiteSpace(persona.donacion)
            )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Valida los campos de la pestaña Niño
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>true = ningun campo está vacío
        /// false= hay algún campo vacío</returns>
        public bool Validacion_Nino(Persona persona)
        {
            if (string.IsNullOrWhiteSpace(persona.nombre)
            || string.IsNullOrWhiteSpace(persona.primerApellido)
            || string.IsNullOrWhiteSpace(persona.segundoApellido)
            || string.IsNullOrWhiteSpace(persona.telefono)
            || string.IsNullOrWhiteSpace(persona.domicilio)
            || string.IsNullOrWhiteSpace(persona.fecha)
            )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Valida los campos de la pestaña EncargadoNiño
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>true = ningun campo está vacío
        /// false= hay algún campo vacío</returns>
        public bool Validacion_EncargadoNino(Persona persona)
        {
            if (string.IsNullOrWhiteSpace(persona.fecha)
            || string.IsNullOrWhiteSpace(persona.nombre)
            || string.IsNullOrWhiteSpace(persona.primerApellido)
            || string.IsNullOrWhiteSpace(persona.segundoApellido)
            || string.IsNullOrWhiteSpace(persona.telefono)
            || string.IsNullOrWhiteSpace(persona.profesion)
            || string.IsNullOrWhiteSpace(persona.domicilio)
            )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
