using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Persona
    {
        private string nombreCompleto;
        private string primerApellido;
        private string segundoApellido;
        private string telefono;
        private string profesion;
        private string domicilio;
        private string correo;

        public void SetNombreCompleto (string nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }
        public string GetNombreCompleto()
        {
            return nombreCompleto;
        }

        public void SetPrimerApellido (string primerApellido)
        {
            this.primerApellido = primerApellido;
        }
        public string GetPrimerApellido()
        {
            return primerApellido;
        }

        public void SetSegundoApellido (string segundoApellido)
        {
            this.segundoApellido = segundoApellido;
        }
        public string GetSegundoApellido()
        {
            return segundoApellido;
        }

        public void SetTelefono (string telefono)
        {
            this.telefono = telefono;
        }
        public string GetTelefono()
        {
            return telefono;
        }

        public void SetProfesion (string profesion)
        {
            this.profesion = profesion;
        }
        public string GetProfesion()
        {
            return profesion;
        }

        public void SetDomicilio (string domicilio)
        {
            this.domicilio = domicilio;
        }
        public string GetDomiciio()
        {
            return domicilio;
        }

        public void SetCorreo (string correo)
        {
            this.correo = correo;
        }
        public string GetCorreo()
        {
            return correo;
        }

    }
}
