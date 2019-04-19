using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{


    class Nino : AbstractPersona
    {
        private string _fecha;

        public void Set_fecha(string fecha)
        {
            this._fecha = fecha;
        }
        public string Get_fecha()
        {
            return _fecha;
        }



       
        public bool Validacion_DatosNino(Nino nino)
        {
            if (string.IsNullOrWhiteSpace(nino.Get_nombre())
                || string.IsNullOrWhiteSpace(nino.Get_primerApellido())
                || string.IsNullOrWhiteSpace(nino.Get_segundoApellido())
                || string.IsNullOrWhiteSpace(nino.Get_telefono())
                || string.IsNullOrWhiteSpace(nino.Get_domicilio())
                || string.IsNullOrWhiteSpace(nino.Get_correo()
                ))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
