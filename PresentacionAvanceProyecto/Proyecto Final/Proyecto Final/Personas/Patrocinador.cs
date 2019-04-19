using Proyecto_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        private string _nombreEmpresa;
        private string _tipoEmpresa;
        private string _tipoPatrocinio;

        public void Set_nombreEmpresa(string nombreEmpresa)
        {
            this._nombreEmpresa = nombreEmpresa;
        }
        public string Get_nombreEmpresa()
        {
            return _nombreEmpresa;
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

        public Patrocinador(string identificacion, string nombre_empresa, string tipo_empresa, string tipo_patrocinio, string nombre, string apellido1, string apellido2, string telefono, string correo)
        {
            this.Set_identificacion(identificacion);
            this.Set_nombreEmpresa(nombre_empresa);
            this.Set_tipoEmpresa(tipo_empresa);
            this.Set_tipoPatrocinio(tipo_patrocinio);
            this.Set_nombre(nombre);
            this.Set_primerApellido(apellido1);
            this.Set_segundoApellido(apellido2);
            this.Set_telefono(telefono);
            this.Set_correo(correo);
        }


        public bool ValidarConObjeto(Patrocinador patrocinador)
        {
            if (string.IsNullOrWhiteSpace(patrocinador.Get_identificacion())
                || string.IsNullOrWhiteSpace(patrocinador.Get_nombreEmpresa())
                || string.IsNullOrWhiteSpace(patrocinador.Get_tipoEmpresa())
                || string.IsNullOrWhiteSpace(patrocinador.Get_tipoPatrocinio())
                || string.IsNullOrWhiteSpace(patrocinador.Get_nombre())
                || string.IsNullOrWhiteSpace(patrocinador.Get_primerApellido())
                || string.IsNullOrWhiteSpace(patrocinador.Get_segundoApellido())
                || string.IsNullOrWhiteSpace(patrocinador.Get_telefono())
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        

        public bool AgregarDatosConObjeto(Patrocinador patrocinador)
        {
            if (ValidarConObjeto(patrocinador))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Patrocinadores (identificacion, nombre_empresa, tipo_empresa, tipo_patrocinio, nombre, apellido1, apellido2, telefono, correo) VALUES (@identificacion, @nombre_empresa, @tipo_empresa, @tipo_patrocinio, @nombre, @apellido1, @apellido2, @telefono, @correo)";
                        command.Parameters.AddWithValue("@identificacion", patrocinador.Get_identificacion());
                        command.Parameters.AddWithValue("@nombre_empresa", patrocinador.Get_nombreEmpresa());
                        command.Parameters.AddWithValue("@tipo_empresa", patrocinador.Get_tipoEmpresa());
                        command.Parameters.AddWithValue("@tipo_patrocinio", patrocinador.Get_tipoPatrocinio());
                        command.Parameters.AddWithValue("@nombre", patrocinador.Get_nombre());
                        command.Parameters.AddWithValue("@apellido1", patrocinador.Get_primerApellido());
                        command.Parameters.AddWithValue("@apellido2", patrocinador.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", patrocinador.Get_telefono());
                        command.Parameters.AddWithValue("@correo", patrocinador.Get_correo());


                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Patrocinadores");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos Patrocinador");
                return false;
            }
            return true;
        }
        
    }
}
