using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Personas
{
    class SetDatos : IVisitante
    {
        public void VisitorAceptar(List<IPersona> elementlist)
        {
            foreach (IPersona per in elementlist)
            {
                per.Accept(this);
            }
        }

        public void VisitorDomicilio(Persona persona)
        {
            persona.domicilio = persona.domicilio;
        }
        public void VisitorTelefono(Persona persona)
        {
            persona.telefono = persona.telefono;

        }
        public void VisitorCorreo(Persona persona)
        {
            persona.correo = persona.correo;
        }
    }
}
