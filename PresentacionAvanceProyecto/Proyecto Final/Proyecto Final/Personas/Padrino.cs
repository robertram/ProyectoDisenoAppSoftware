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

        
        public Padrino(string identificacion, string fecha, string nombre, string primerApellido, string segundoApellido, string telefono, string profesion, string domicilio, string correo, string inscripcion, string donacion)
        {
            this.Set_identificacion(identificacion);//
            this.Set_fecha(fecha);//
            this.Set_nombre(nombre);//
            this.Set_primerApellido(primerApellido);//
            this.Set_segundoApellido(segundoApellido);//
            this.Set_telefono(telefono);//
            this.Set_profesion(profesion);//
            this.Set_domicilio(domicilio);//
            this.Set_correo(correo);//
            this.Set_inscripcion(inscripcion);//
            this.Set_donacion(donacion);//
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
            if (string.IsNullOrWhiteSpace(padrino.Get_identificacion())
                || string.IsNullOrWhiteSpace(padrino.Get_fecha())
                || string.IsNullOrWhiteSpace(padrino.Get_nombre())
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
                using (SqlConnection connection = new SqlConnection("Data Source=JOSE-DAVID" + @"\JD;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into tbl_Padrinos (identificacion, fecha, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo, inscripcion, donacion) VALUES (@identificacion, @fecha, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo, @inscripcion, @donacion)";
                        command.Parameters.AddWithValue("@identificacion", padrino.Get_identificacion());
                        command.Parameters.AddWithValue("@fecha", _fecha);
                        command.Parameters.AddWithValue("@nombre", padrino.Get_nombre());
                        command.Parameters.AddWithValue("@apellido1", padrino.Get_primerApellido());
                        command.Parameters.AddWithValue("@apellido2", padrino.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", padrino.Get_telefono());
                        command.Parameters.AddWithValue("@profesion", padrino.Get_profesion());
                        command.Parameters.AddWithValue("@domicilio", padrino.Get_domicilio());
                        command.Parameters.AddWithValue("@correo", padrino.Get_correo());
                        command.Parameters.AddWithValue("@inscripcion", _inscripcion);
                        command.Parameters.AddWithValue("@donacion", _donacion);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Entró! Pero no se logró guardar los datos en la base de datos");
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
