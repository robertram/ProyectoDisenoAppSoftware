using Proyecto_Final.Personas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.SQL
{
    class AgregarPersona
    {
        public bool AgregarVoluntario(Persona persona)
        {
            if (true/*ValidarConObjeto(voluntario)*/)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Voluntario (identificacion, fecha, nombre, apellido1, apellido2, telefono, profesion, domicilio, inscripcion, donacion, correo) VALUES (@identificacion, @fecha, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @inscripcion, @donacion, @correo)";
                        command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        command.Parameters.AddWithValue("@fecha", persona.fecha);
                        command.Parameters.AddWithValue("@nombre", persona.nombre);
                        command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        command.Parameters.AddWithValue("@telefono", persona.telefono);
                        command.Parameters.AddWithValue("@profesion", persona.profesion);
                        command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        command.Parameters.AddWithValue("@inscripcion", persona.inscripcion);
                        command.Parameters.AddWithValue("@donacion", persona.donacion);
                        command.Parameters.AddWithValue("@correo", persona.correo);


                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Se abrió la conexión");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Voluntario");
                        }
                        finally
                        {
                            MessageBox.Show("Se cerró la conexión");
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos Voluntario");
                return false;
            }
            return true;
        }

        public bool AgregarNino(Persona persona)
        {
            if (true/*ValidacionDatosNino(nino)*/)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Nino (identificacion, nombre, apellido1, apellido2, telefono, domicilio, correo, fecha) VALUES (@identificacion, @nombre, @apellido1, @apellido2, @telefono, @domicilio, @correo, @fecha)";
                        command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        command.Parameters.AddWithValue("@nombre", persona.nombre);
                        command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        command.Parameters.AddWithValue("@telefono", persona.telefono);
                        command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        command.Parameters.AddWithValue("@correo", persona.correo);
                        command.Parameters.AddWithValue("@fecha", persona.fecha);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Se abrió la conexión");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Nino");
                        }
                        finally
                        {
                            MessageBox.Show("Se cerró la conexión");
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

        public bool AgregarEncargadoNino(Persona persona)
        {
            if (true/*ValidacionDatosEncargadoNino(encargado)*/)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_EncargadoNino (fecha, identificacion, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo) VALUES (@fecha, @identificacion, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo)";
                        command.Parameters.AddWithValue("@fecha", persona.fecha);
                        command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        command.Parameters.AddWithValue("@nombre", persona.nombre);
                        command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        command.Parameters.AddWithValue("@telefono", persona.telefono);
                        command.Parameters.AddWithValue("@profesion", persona.profesion);
                        command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        command.Parameters.AddWithValue("@correo", persona.correo);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Se abrió la conexión");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Encargado");
                        }
                        finally
                        {
                            connection.Close();
                            MessageBox.Show("Se cerró la conexión");
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

        public bool AgregarPatrocinador(Persona persona)
        {
            if (true/*ValidarConObjeto(patrocinador)*/)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Patrocinadores (fecha, nombre_empresa, tipo_empresa, tipo_patrocinio, identificacion, nombre, apellido1, apellido2, telefono, correo) VALUES (@fecha, @nombre_empresa, @tipo_empresa, @tipo_patrocinio, @identificacion, @nombre, @apellido1, @apellido2, @telefono, @correo)";
                        command.Parameters.AddWithValue("@fecha", persona.fecha);
                        command.Parameters.AddWithValue("@nombre_empresa", persona.nombreEmpresa);
                        command.Parameters.AddWithValue("@tipo_empresa", persona.tipoEmpresa);
                        command.Parameters.AddWithValue("@tipo_patrocinio", persona.tipoPatrocinio);
                        command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        command.Parameters.AddWithValue("@nombre", persona.nombre);
                        command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        command.Parameters.AddWithValue("@telefono", persona.telefono);
                        command.Parameters.AddWithValue("@correo", persona.correo);


                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Se abrió la conexión");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Patrocinadores");
                        }
                        finally
                        {
                            connection.Close();
                            MessageBox.Show("Se cerró la conexión");
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

        public bool AgregarPadrino(Persona persona)
        {
            if (true/*ValidarConObjeto(padrino)*/)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into tbl_Padrinos (identificacion, fecha, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo, inscripcion, donacion) VALUES (@identificacion, @fecha, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo, @inscripcion, @donacion)";
                        command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        command.Parameters.AddWithValue("@fecha", persona.fecha);
                        command.Parameters.AddWithValue("@nombre", persona.nombre);
                        command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        command.Parameters.AddWithValue("@telefono", persona.telefono);
                        command.Parameters.AddWithValue("@profesion", persona.profesion);
                        command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        command.Parameters.AddWithValue("@correo", persona.correo);
                        command.Parameters.AddWithValue("@inscripcion", persona.inscripcion);
                        command.Parameters.AddWithValue("@donacion", persona.donacion);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Se abrió la conexión");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Catch Padrino");
                        }
                        finally
                        {
                            MessageBox.Show("Se cerró la conexión");
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



