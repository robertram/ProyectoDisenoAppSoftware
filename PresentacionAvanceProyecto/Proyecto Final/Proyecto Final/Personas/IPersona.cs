using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Personas
{
    public interface IPersona
    {
        void Accept(IVisitante visitor);
    }
}
