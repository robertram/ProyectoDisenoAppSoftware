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
    /// Esta clase son las personas que especificamente son Encargados de Niños. Tiene como atributo el nino que tiene a cargo
    /// </summary>
    class Encargado_Nino : AbstractPersona, IEncargadoNino
    {
        private Nino _nino;
        private string _fecha;

        public void Set_nino(Nino nino)
        {
            this._nino = nino;
        }
        public Nino Get_nino()
        {
            return _nino;
        }

        public void Set_fecha(string fecha)
        {
            this._fecha = fecha;
        }
        public string Get_fecha()
        {
            return _fecha;
        }

        public Encargado_Nino(string fecha, string identificacion, string nombre, string apellido1, string apellido2, string telefono, string profesion, string domicilio, string correo)
        {
            this.Set_fecha(fecha);
            this.Set_identificacion(identificacion);
            this.Set_nombre(nombre);
            this.Set_primerApellido(apellido1);
            this.Set_segundoApellido(apellido2);
            this.Set_telefono(telefono);
            this.Set_profesion(profesion);
            this.Set_domicilio(domicilio);
            this.Set_correo(correo);
        }

        public bool ValidacionDatosEncargadoNino(Encargado_Nino encargado)
        {
            if (string.IsNullOrWhiteSpace(encargado.Get_fecha())
                || string.IsNullOrWhiteSpace(encargado.Get_identificacion())
                || string.IsNullOrWhiteSpace(encargado.Get_nombre())
                || string.IsNullOrWhiteSpace(encargado.Get_primerApellido())
                || string.IsNullOrWhiteSpace(encargado.Get_segundoApellido())
                || string.IsNullOrWhiteSpace(encargado.Get_telefono())
                || string.IsNullOrWhiteSpace(encargado.Get_profesion())
                || string.IsNullOrWhiteSpace(encargado.Get_domicilio())
                || string.IsNullOrWhiteSpace(encargado.Get_correo())
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarDatosConObjeto(Encargado_Nino encargado)
        {
            if (ValidacionDatosEncargadoNino(encargado))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Voluntario (fecha, identificacion, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo) VALUES (@fecha, @identificacion, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo)";
                        command.Parameters.AddWithValue("@fecha", encargado.Get_fecha());
                        command.Parameters.AddWithValue("@identificacion", encargado.Get_identificacion());
                        command.Parameters.AddWithValue("@nombre", encargado.Get_nombre());
                        command.Parameters.AddWithValue("@apellido1", encargado.Get_primerApellido());
                        command.Parameters.AddWithValue("@apellido2", encargado.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", encargado.Get_telefono());
                        command.Parameters.AddWithValue("@profesion", encargado.Get_profesion());
                        command.Parameters.AddWithValue("@domicilio", encargado.Get_domicilio());
                        command.Parameters.AddWithValue("@correo", encargado.Get_correo());

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Encargado");
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
                MessageBox.Show("Faltan datos Encargado");
                return false;
            }
            return true;
        }
    }
}
