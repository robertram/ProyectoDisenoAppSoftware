using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Personas
{
    public interface IVisitante
    {
        void VisitorDomicilio(Persona persona);
        void VisitorTelefono(Persona persona);
        void VisitorCorreo(Persona persona);

        void VisitorAceptar(List<IPersona> personalist);
    }

}

