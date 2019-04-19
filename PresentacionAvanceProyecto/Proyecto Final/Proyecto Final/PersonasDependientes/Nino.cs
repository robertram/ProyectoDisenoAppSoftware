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


    class Nino : AbstractPersona, INino
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

        public Nino(string nombre, string apellido1, string apellido2, string telefono, string domicilio, string correo, string fecha)
        {
            this.Set_nombre(nombre);
            this.Set_primerApellido(apellido1);
            this.Set_segundoApellido(apellido2);
            this.Set_telefono(telefono);
            this.Set_domicilio(domicilio);
            this.Set_correo(correo);
            this.Set_fecha(fecha);
        }

       
        public bool ValidacionDatosNino(Nino nino)
        {
            if (string.IsNullOrWhiteSpace(nino.Get_nombre())
                || string.IsNullOrWhiteSpace(nino.Get_primerApellido())
                || string.IsNullOrWhiteSpace(nino.Get_segundoApellido())
                || string.IsNullOrWhiteSpace(nino.Get_telefono())
                || string.IsNullOrWhiteSpace(nino.Get_domicilio())
                || string.IsNullOrWhiteSpace(nino.Get_correo())
                || string.IsNullOrWhiteSpace(nino.Get_fecha())
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        

        public bool AgregarDatosConObjeto(Nino nino)
        {
            if (ValidacionDatosNino(nino))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Voluntario (nombre, apellido1, apellido2, telefono, domicilio, correo, fecha) VALUES (@nombre, @apellido1, @apellido2, @telefono, @domicilio, @correo, @fecha)";
                        command.Parameters.AddWithValue("@nombre", nino.Get_nombre());
                        command.Parameters.AddWithValue("@apellido1", nino.Get_primerApellido());
                        command.Parameters.AddWithValue("@apellido2", nino.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", nino.Get_telefono());
                        command.Parameters.AddWithValue("@domicilio", nino.Get_domicilio());
                        command.Parameters.AddWithValue("@correo", nino.Get_correo());
                        command.Parameters.AddWithValue("@fecha", nino.Get_fecha());
                        
                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Nino");
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
                MessageBox.Show("Faltan datos Nino");
                return false;
            }
            return true;
        }
        
    }

    
}
