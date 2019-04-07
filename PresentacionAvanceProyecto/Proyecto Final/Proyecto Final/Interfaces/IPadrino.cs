using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Interfaces
{
    interface IPadrino
    {
        bool ValidarConObjeto(Padrino padrino);
        bool AgregarDatosConObjeto(Padrino padrino);
    }
}
