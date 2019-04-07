using Proyecto_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    /// <summary>
    /// esta clase es para las empresas patrocinadoras, se almacena el nombre de la compañia. el tipo de empresa y el tipo de patrocinador.
    /// </summary>
    class Patrocinador : AbstractPersona, IPatrocinador
    {
        
        private string _nombreCompania;
        private string _tipoEmpresa;
        private string _tipoPatrocinio;

        public void Set_nombreCompania(string nombreCompania)
        {
            this._nombreCompania = nombreCompania;
        }
        public string Get_nombreCompania()
        {
            return _nombreCompania;
        }

        public void Set_tipoEmpresa(string tipoEmpresa)
        {
            this._tipoEmpresa = tipoEmpresa;
        }
        public string Get_tipoEmpresa()
        {
            return _tipoEmpresa;
        }

        public void Set_tipoPatrocinio(string tipoPatrocinio)
        {
            this._tipoPatrocinio = tipoPatrocinio;
        }
        public string Get_tipoPatrocinio()
        {
            return _tipoPatrocinio;
        }

        public bool Validacion_DatosPersona(string nombre_compania, string tipo_empresa, string tipo_patrocinio, string nombre, string apellido1, string apellido2, string telefono)
        {
            if (string.IsNullOrWhiteSpace(nombre_compania)
                || string.IsNullOrWhiteSpace(tipo_empresa)
                || string.IsNullOrWhiteSpace(tipo_patrocinio)
                || string.IsNullOrWhiteSpace(nombre)
                || string.IsNullOrWhiteSpace(apellido1)
                || string.IsNullOrWhiteSpace(apellido2)
                || string.IsNullOrWhiteSpace(telefono)
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool ValidarConObjeto(Patrocinador patrocinador)
        {
            throw new NotImplementedException();
        }

        public bool AgregarDatosConObjeto(Patrocinador patrocinador)
        {
            throw new NotImplementedException();
        }
    }
}
