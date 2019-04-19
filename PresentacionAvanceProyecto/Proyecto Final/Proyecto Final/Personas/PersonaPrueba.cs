using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final.Personas
{
    class PersonaPrueba : AbstractPersona
    {
        private string _fecha;
        private string _inscripcion;
        private string _donacion;

        public PersonaPrueba(/*string fecha, string identificacion, */string nombre/*, string apellido1, string apellido2, string telefono, string profesion, string domicilio, string correo, string inscripcion, string donacion*/)
        {
            //this.Set_fecha(fecha);
            //this.Set_identificacion(identificacion);
            this.Set_nombre(nombre);
            //this.Set_primerApellido(apellido1);
            //this.Set_segundoApellido(apellido2);
            //this.Set_telefono(telefono);
            //this.Set_profesion(profesion);
            //this.Set_domicilio(domicilio);
            //this.Set_correo(correo);
            //this.Set_inscripcion(inscripcion);
            //this.Set_donacion(donacion);
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

        public bool AgregarDatosConObjeto(PersonaPrueba personaPrueba)
        {
            if (true)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_PersonaPrueba (nombre) VALUES ( @nombre)";

                        
                        /*command.Parameters.AddWithValue("@fecha", personaPrueba.Get_fecha());
                        command.Parameters.AddWithValue("@identificacion", personaPrueba.Get_identificacion());
                        */
                        command.Parameters.AddWithValue("@nombre", personaPrueba.Get_nombre());
                        /*command.Parameters.AddWithValue("@primerApellido", personaPrueba.Get_primerApellido());
                        command.Parameters.AddWithValue("@segundoApellido", personaPrueba.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", personaPrueba.Get_telefono());
                        command.Parameters.AddWithValue("@profesion", personaPrueba.Get_profesion());
                        command.Parameters.AddWithValue("@domicilio", personaPrueba.Get_domicilio());
                        command.Parameters.AddWithValue("@correo", personaPrueba.Get_correo());
                        command.Parameters.AddWithValue("@inscripcion", personaPrueba.Get_inscripcion());
                        command.Parameters.AddWithValue("@donacion", personaPrueba.Get_donacion());
                        */

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Entro a la base de datos pero no agrega");
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

        public bool ValidarConObjeto(Voluntario voluntario)
        {
            throw new NotImplementedException();
        }
    }
}
