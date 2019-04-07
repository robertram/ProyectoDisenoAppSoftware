using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    /// <summary>
    /// Esta clase son las personas que especificamente son Encargados de Niños. Tiene como atributo el nino que tiene a cargo
    /// </summary>
    class Encargado_Nino : AbstractPersona
    {
        private Nino _nino;

        public void Set_nino(Nino nino)
        {
            this._nino = nino;
        }
        public Nino Get_nino()
        {
            return _nino;
        }
    }
}
