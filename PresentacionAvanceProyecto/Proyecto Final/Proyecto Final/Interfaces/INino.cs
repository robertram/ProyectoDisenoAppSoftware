using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Interfaces
{
    interface INino
    {
        bool ValidacionDatosNino(Nino nino);
        bool AgregarDatosConObjeto(Nino nino);
    }
}
