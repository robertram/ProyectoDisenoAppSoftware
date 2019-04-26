using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// esta clase nos ayuda a administrar las personas, 
/// aquí definimos de todos los atributos que tiene persona, los que vamos a necesitar en cada tipo de persona. 
/// Si se recuerda que los metodos que nombramos en PersonaBuilder que comienzan con Add retornan un PersonaBuilder al terminar,
/// se puede entender más facilmente el contenido de los metodos. 
/// Reciben los parametros se crea un nuevo Persona.PersonaBuilder() 
/// y luego se llaman los metodos add para agregar la info, que retorne el PersonaBuilder con la info guardada 
/// y al final se ejecuta GetPersona() para crear una nueva persona y guardar la informacion necesaria en la persona.
/// </summary>
namespace Proyecto_Final.Personas
{
    public class ClienteDePersonas
    {

        /// <summary>
        /// Crear Voluntario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="fecha"></param>
        /// <param name="inscripcion"></param>
        /// <param name="donacion"></param>
        /// <param name="identificacion"></param>
        /// <returns></returns>
        public Persona CrearVoluntario(string identificacion, string fecha, string nombre, string primerApellido, string segundoApellido, string telefono, string profesion, string domicilio, string inscripcion, string donacion, string correo)
        {
            Persona voluntario = new Persona.PersonaBuilder().AddTipoDePersona("Voluntario").AddNombre(nombre).AddPrimerApellido(primerApellido).AddSegundoApellido(segundoApellido).AddTelefono(telefono).AddProfesion(profesion).AddDomicilio(domicilio).AddCorreo(correo).AddFecha(fecha).AddInscripcion(inscripcion).AddDonacion(donacion).AddIdentificacion(identificacion).GetPersona();
            return voluntario;
        }

        /// <summary>
        /// Crear Padrino
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="fecha"></param>
        /// <param name="inscripcion"></param>
        /// <param name="donacion"></param>
        /// <returns></returns>
        public Persona CrearPadrino(string identificacion, string fecha, string nombre, string primerApellido, string segundoApellido, string telefono, string profesion, string domicilio, string correo, string inscripcion, string donacion)
        {
            Persona padrino = new Persona.PersonaBuilder().AddTipoDePersona("Padrinos").AddIdentificacion(identificacion).AddFecha(fecha).AddNombre(nombre).AddPrimerApellido(primerApellido).AddSegundoApellido(segundoApellido).AddTelefono(telefono).AddProfesion(profesion).AddDomicilio(domicilio).AddCorreo(correo).AddInscripcion(inscripcion).AddDonacion(donacion).GetPersona();
            return padrino;
        }

        /// <summary>
        /// Crear Representante Empresarial
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="nombreEmpresa"></param>
        /// <param name="tipoEmpresa"></param>
        /// <param name="tipoPatrocinio"></param>66
        /// <returns></returns>
        public Persona CrearPatrocinador(string fecha, string nombreEmpresa, string tipoEmpresa, string tipoPatrocinio, string identificacion, string nombre, string primerApellido, string segundoApellido, string telefono, string correo)
        {
            Persona patrocinador = new Persona.PersonaBuilder().AddTipoDePersona("Patrocinadores").AddFecha(fecha).AddNombreEmpresa(nombreEmpresa).AddTipoEmpresa(tipoEmpresa).AddTipoPatrocinio(tipoPatrocinio).AddIdentificacion(identificacion).AddNombre(nombre).AddPrimerApellido(primerApellido).AddSegundoApellido(segundoApellido).AddTelefono(telefono).AddCorreo(correo).GetPersona();
            return patrocinador;
        }
    
        /// <summary>
        ///  Crear Encargado Niño
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="identificacion"></param>
        /// <returns></returns>
        public Persona CrearEncargadoNino(string fecha, string identificacion, string nombre, string primerApellido, string segundoApellido, string telefono, string profesion, string domicilio, string correo)
        {
            Persona representanteEmpresarial = new Persona.PersonaBuilder().AddTipoDePersona("Encargado de Niño").AddFecha(fecha).AddIdentificacion(identificacion).AddNombre(nombre).AddPrimerApellido(primerApellido).AddSegundoApellido(segundoApellido).AddTelefono(telefono).AddProfesion(profesion).AddDomicilio(domicilio).AddCorreo(correo).GetPersona();
            return representanteEmpresarial;
        }


        /// <summary>
        /// Crear  Niño
        /// la identificacion que se provee debe ser la del encargado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="fecha"></param>
        /// <param name="identificacion"></param>
        /// <returns></returns>
        public Persona CrearNino(string identificacion, string nombre, string primerApellido, string segundoApellido, string telefono, string domicilio, string correo, string fecha)
        {
            Persona representanteEmpresarial = new Persona.PersonaBuilder().AddTipoDePersona("Nino").AddIdentificacion(identificacion).AddNombre(nombre).AddPrimerApellido(primerApellido).AddSegundoApellido(segundoApellido).AddTelefono(telefono).AddDomicilio(domicilio).AddCorreo(correo).AddFecha(fecha).GetPersona();
            return representanteEmpresarial;
        }

    }
}
