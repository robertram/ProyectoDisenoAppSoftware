using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    interface IVoluntario
    {
        bool ValidarConObjeto(Voluntario voluntario);
        bool AgregarDatosConObjeto(Voluntario voluntario);
    }
}
