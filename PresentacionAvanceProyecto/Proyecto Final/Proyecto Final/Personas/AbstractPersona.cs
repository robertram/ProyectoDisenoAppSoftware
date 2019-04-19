using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public abstract class AbstractPersona
    {

        /// <summary>
        /// esta es la clase que le hereda a las demás clases de persona los atributos y métodos que todos van a necesitar 
        /// para evitar tener que crearlos en cada uno. 
        /// es abstracta, por lo que las clases que heredan tienen acceso opcional a los metodos virtuales que ya están definidos 
        /// pues son los getters y setters
        /// Los atributos son prvados y se accesan por medio de sus setters y getters
        /// </summary>
        private string _identificacion;
        private string _nombre;
        private string _primerApellido;
        private string _segundoApellido;
        private string _telefono;
        private string _profesion;
        private string _domicilio;
        private string _correo;

        public virtual void Set_identificacion(string identificacion)
        {
            this._identificacion = identificacion;
        }
        public virtual string Get_identificacion()
        {
            return _identificacion;
        }
        
        public virtual void Set_nombre (string nombre)
        {
            this._nombre = nombre;
        }
        public virtual string Get_nombre()
        {
            return _nombre;
        }

        public virtual void Set_primerApellido (string primerApellido)
        {
            this._primerApellido = primerApellido;
        }
        public virtual string Get_primerApellido()
        {
            return _primerApellido;
        }

        public virtual void Set_segundoApellido(string segundoApellido)
        {
            this._segundoApellido = segundoApellido;
        }
        public virtual string Get_segundoApellido()
        {
            return _segundoApellido;
        }

        public virtual void Set_telefono (string telefono)
        {
            this._telefono = telefono;
        }
        public virtual string Get_telefono()
        {
            return _telefono;
        }

        public virtual void Set_profesion(string profesion)
        {
            this._profesion = profesion;
        }
        public virtual string Get_profesion()
        {
            return _profesion;
        }

        public virtual void Set_domicilio(string domicilio)
        {
            this._domicilio = domicilio;
        }
        public virtual string Get_domicilio()
        {
            return _domicilio;
        }

        public virtual void Set_correo(string correo)
        {
            this._correo = correo;
        }
        public virtual string Get_correo()
        {
            return _correo;
        }

        /// <summary>
        /// este metodo retorna a que clase pertenece la persona
        /// </summary>
        /// <returns></returns>
        public virtual string Tipo_Persona()
        {
            return "Esta persona es una instancia de la clase : " + this.GetType().ToString();
        }
    }
}
