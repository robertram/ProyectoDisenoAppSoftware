using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Interfaces
{
    interface IEncargadoNino
    {
        bool ValidacionDatosEncargadoNino(Encargado_Nino encargado);
        bool AgregarDatosConObjeto(Encargado_Nino encargado);
    }
}
