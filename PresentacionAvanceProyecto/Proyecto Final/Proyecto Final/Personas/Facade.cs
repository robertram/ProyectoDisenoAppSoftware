using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Personas
{
    /// <summary>
    ///  El cliente usa el patron de diseño facade para disponer de los metodos de las clases, 
    ///  este se utilia como intermediario para asi no tener que pasar directamente a cada clase.
    /// </summary>
    public class Facade
    {
        //Se llaman las dos clases
        private ClienteDePersonas clieClienteDePersonas = new ClienteDePersonas();

        public Facade()
        {
            //Se inicializan ambas clases
            clieClienteDePersonas = new ClienteDePersonas();

        }

    }
}
