using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///Originalmente el proyecto se diseño para que una clase abstracta "persona" que le hereda a los demás 
///tipos de personas involucrados todos los atributos y metodos que todas tengan en comun, 
///para añadirle despues a las clases que heredaban de la abstracta sus atributos unicos.
///El patron Builder fue util en estas circunstancias porque permite una alternativa a crear varios objetos 
///más complejos a partie de un objeto fuente, ya que esto provoca que el programa sea mas complejo de lo que es necesario. 
///
///Aquí el patrón creacional builder se utilzia enfocado a una clase constructora con sintexis fluida 
///en que se pueden omitir parametros según sea necesario. Basicamente la alternativa a crear varios objetos 
///complejos a partir de un objeto fuente es que todos los atributos estén en una sola clase para posteriormente 
///sobrecargar metodos constructores con diferentes parametros para de esta manera tener un metodo constructor 
///para cada combinacion de los atributos que se quiera crear. El problema de simplemente hacer esto directamente 
///es que se vuelve complicado para el usuario saber cual metodo constructor utilziar cuando, sobretodo entre más 
///cantidad de atributos existan, y también es complicado llevar el orden en que deben aparecer los parametros a la 
///hora de utilziar los metodos constructores sobrecargados. Otra opcion que tampoco es recomendada es un solo metodo 
///constructor que incluya todos los parametros posibles, pero esto tambien puede provocar errores con facilidad.
///
///En esta versión del patrón builder no existe un director. Por qué? 
///porque no es necesario definir valores para los atributos de als personas como en un caso en que todos los voluntarios 
///tuvieran una donacion de 50 mil fija o alguna situación similar. 
///El patron tambien permite la flexibilidad de añadir facilmente cualquier parametro que pueda ser necesario a futuro 
///de manera sencilla.
/// </summary>
namespace Proyecto_Final.Personas
{
    public class Persona : IPersona
    {
        //obligatorios
        public string tipoDePersona { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string telefono { get; set; }
        //opcionales
        public string correo { get; set; }
        public string domicilio { get; set; }
        public string profesion { get; set; }
        public string fecha { get; set; }
        public string inscripcion { get; set; }
        public string donacion { get; set; }
        public string nombreEmpresa { get; set; }
        public string tipoEmpresa { get; set; }
        public string tipoPatrocinio { get; set; }
        public string identificacion { get; set; }

        /// <summary>
        /// En esta versión del patrón builder, esta clase tiene un constructor privado
        /// o sea que es solo accesible dentro de si. 
        /// </summary>
        private Persona()
        {
        }

        /// <summary>
        /// este metodo nos muestra que el patron esta funcionando: 
        /// se llaman a todos los atributos posibles aunque solo se definan los que se necesitan para una clase de persona 
        /// y aún así funciona perfectamente.
        /// </summary>
        /// <returns>retorna un string con toda la informacion contenida en los atributos</returns>
        public string MostrarInfo()
        {
            return (this.tipoDePersona + " " + this.nombre + " " + this.primerApellido + " " + this.segundoApellido + " " + this.telefono + " " + this.correo + " " + this.domicilio + " " + this.profesion + " " + this.fecha + " " + this.inscripcion + " " + this.donacion + " " + this.nombreEmpresa + " " + this.tipoPatrocinio + " " + this.identificacion);
        }

        /// <summary>
        /// el builder esta anidado dentro dentro de la clase persona y tiene metodos para poder agregar 
        /// cada uno de los distintos atributos según se desee y en el orden que se desee. 
        /// Así existe la posibilidad de poder seguir cualquier combinación de pasos que sea necesaria. 
        /// Añade la posibilidad de poder enfrentar posibles requerimientos en el futuro.
        /// </summary>

        public class PersonaBuilder
        {
            //los atributos de PersonaBuilder son iguales a los de Persona porque la idea es 
            //guardar lo que se necesita para crear la persona en ellos 
            //para posteriormente tomar la informacion de ahí al momento de crear la persona.

            //obligatorios
            public string tipoDePersona { get; set; }
            public string nombre { get; set; }
            public string primerApellido { get; set; }
            public string segundoApellido { get; set; }
            public string telefono { get; set; }
            public string correo { get; set; }
            //opcionales
            public string domicilio { get; set; }
            public string profesion { get; set; }
            public string fecha { get; set; }
            public string inscripcion { get; set; }
            public string donacion { get; set; }
            public string nombreEmpresa { get; set; }
            public string tipoEmpresa { get; set; }
            public string tipoPatrocinio { get; set; }
            public string identificacion { get; set; }

            //todos estos metodos nos permiten definir un atributo de PersonaBuilder y 
            //despues de agregarlo retorna el PersonaBuilder con la informacion guardada en su atributo.

            public PersonaBuilder AddTipoDePersona(string tipoDePersona)
            {
                this.tipoDePersona = tipoDePersona;
                return this;
            }

            public PersonaBuilder AddNombre(string nombre)
            {
                this.nombre = nombre;
                return this;
            }

            public PersonaBuilder AddPrimerApellido(string primerApellido)
            {
                this.primerApellido = primerApellido;
                return this;
            }

            public PersonaBuilder AddSegundoApellido(string segundoApellido)
            {
                this.segundoApellido = segundoApellido;
                return this;
            }

            public PersonaBuilder AddTelefono(string telefono)
            {
                this.telefono = telefono;
                return this;
            }

            public PersonaBuilder AddCorreo(string correo)
            {
                this.correo = correo;
                return this;
            }

            public PersonaBuilder AddDomicilio(string domicilio)
            {
                this.domicilio = domicilio;
                return this;
            }

            public PersonaBuilder AddProfesion(string profesion)
            {
                this.profesion = profesion;
                return this;
            }

            public PersonaBuilder AddFecha(string fecha)
            {
                this.fecha = fecha;
                return this;
            }

            public PersonaBuilder AddInscripcion(string inscripcion)
            {
                this.inscripcion = inscripcion;
                return this;
            }

            public PersonaBuilder AddDonacion(string donacion)
            {
                this.donacion = donacion;
                return this;
            }

            public PersonaBuilder AddNombreEmpresa(string nombreEmpresa)
            {
                this.nombreEmpresa = nombreEmpresa;
                return this;
            }

            public PersonaBuilder AddTipoEmpresa(string tipoEmpresa)
            {
                this.tipoEmpresa = tipoEmpresa;
                return this;
            }

            public PersonaBuilder AddTipoPatrocinio(string tipoPatrocinio)
            {
                this.tipoPatrocinio = tipoPatrocinio;
                return this;
            }

            public PersonaBuilder AddIdentificacion(string identificacion)
            {
                this.identificacion = identificacion;
                return this;
            }

            /// <summary>
            /// este metodo nos retorna la persona construida. Primero crea una nueva persona y 
            /// luego guarda en sus atributos la informacion contenida en los atributos de PersonaBuilder.
            /// </summary>
            /// <returns>retorna la persona terminada.</returns>

            public Persona GetPersona()
            {
                Persona person = new Persona();
                person.tipoDePersona = this.tipoDePersona;
                person.nombre = this.nombre;
                person.primerApellido = this.primerApellido;
                person.segundoApellido = this.segundoApellido;
                person.telefono = this.telefono;
                person.correo = this.correo;
                person.domicilio = this.domicilio;
                person.profesion = this.profesion;
                person.fecha = this.fecha;
                person.inscripcion = this.inscripcion;
                person.donacion = this.donacion;
                person.nombreEmpresa = this.nombreEmpresa;
                person.tipoEmpresa = this.tipoEmpresa;
                person.tipoPatrocinio = this.tipoPatrocinio;
                person.identificacion = this.identificacion;
                return person;
            }
        }
        //Metodo para aceptar el visitor
        public void Accept(IVisitante visitor)
        {
            visitor.VisitorDomicilio(this);
            visitor.VisitorTelefono(this);
            visitor.VisitorCorreo(this);
        }
    }
}
