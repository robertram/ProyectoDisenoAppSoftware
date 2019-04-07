using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_Final.Interfaces;

namespace Proyecto_Final
{
    /// <summary>
    /// esta clase son las personas que especificamente son padrinos. Tiene tres atributos propios que son necesarios manejar en el caso de los padrinos. tiene setters y getters para los atributos. 
    /// </summary>
    class Padrino : AbstractPersona, IPadrino
    {
        
        private string _fecha;
        private string _inscripcion;
        private string _donacion;

        
        public Padrino(string nombreCompleto, string primerApellido, string segundoApellido, string telefono, string profesion, string domicilio, string correo, string inscripcion, string donacion)
        {
            this.Set_nombreCompleto(nombreCompleto);
            this.Set_primerApellido(primerApellido);
            this.Set_segundoApellido(segundoApellido);
            this.Set_telefono(telefono);
            this.Set_profesion(profesion);
            this.Set_domicilio(domicilio);
            this.Set_correo(correo);
            this.Set_inscripcion(inscripcion);
            this.Set_donacion(donacion);
        }

        
        public void Set_fecha(string fecha)
        {
            this._fecha = fecha;
        }
        public string Get_fecha()
        {
            return _fecha;
        }

        public void Set_inscripcion(string inscripcion)
        {
            this._inscripcion = inscripcion;
        }
        public string Get_inscripcion()
        {
            return _inscripcion;
        }

        public void Set_donacion(string donacion)
        {
            this._donacion = donacion;
        }
        public string Get_donacion()
        {
            return _donacion;
        }

        public bool ValidarConObjeto(Padrino padrino)
        {
            if (string.IsNullOrWhiteSpace(padrino.Get_nombreCompleto())
                || string.IsNullOrWhiteSpace(padrino.Get_primerApellido())
                || string.IsNullOrWhiteSpace(padrino.Get_segundoApellido())
                || string.IsNullOrWhiteSpace(padrino.Get_telefono())
                || string.IsNullOrWhiteSpace(padrino.Get_profesion())
                || string.IsNullOrWhiteSpace(padrino.Get_domicilio())
                || string.IsNullOrWhiteSpace(_inscripcion)
                || string.IsNullOrWhiteSpace(_donacion)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AgregarDatosConObjeto(Padrino padrino)
        {
            if (ValidarConObjeto(padrino))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Voluntario (nombre, apellido1, apellido2, telefono, profesion, domicilio, correo,  inscripcion, donacion) VALUES (@nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo, @inscripcion, @donacion)";
                        command.Parameters.AddWithValue("@nombre", padrino.Get_nombreCompleto());
                        command.Parameters.AddWithValue("@apellido1", padrino.Get_primerApellido());
                        command.Parameters.AddWithValue("@apellido2", padrino.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", padrino.Get_telefono());
                        command.Parameters.AddWithValue("@profesion", padrino.Get_profesion());
                        command.Parameters.AddWithValue("@domicilio", padrino.Get_domicilio());
                        command.Parameters.AddWithValue("@correo", padrino.Get_correo());
                        //command.Parameters.AddWithValue("@inscripcion", inscripcion);
                        command.Parameters.AddWithValue("@donacion", _donacion);
                        command.Parameters.AddWithValue("@fecha", _fecha);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            // error here
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
                MessageBox.Show("No se logró guardar los datos en la base de datos");
                return false;
            }
            return true;
        }


    }
}
