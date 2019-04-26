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
    /// <summary>
    /// Clase que tiene los métodos para agregar los datos de cada persona a su respectiva tabla. 
    /// Se utiliza Sql Server como Base de Datos. Con su lenguaje se logra introducir los datos en un comando. 
    /// </summary>
    public class AgregarPersona
    {
        
        //Instancia ValidacionDatos 
        ValidacionDatos validacion = new ValidacionDatos();

        /// <summary>
        /// Método que agrega la respectiva persona a su respectiva tabla
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="proxy"></param>
        /// <returns>true= si logró intropducir los datos
        /// false= si no logró introducir los datos</returns>
        public bool AgregarVoluntario(Persona persona, Proxy proxy)
        {
            
            if (validacion.Validacion_Voluntario(persona)) //Si no falta ningún dato, entra 
            {
                using (proxy.conexionSql) //Llama a la instancia SqlConnection que está en la clase Proxy 
                {
                    using (proxy.command)
                    {
                        proxy.command.Connection = proxy.conexionSql;
                        proxy.command.CommandType = CommandType.Text; //Se le asigna a Texto el tipo de comando 
                        proxy.command.CommandText = "INSERT into Tbl_Voluntario (identificacion, fecha, nombre, apellido1, apellido2, telefono, profesion, domicilio, inscripcion, donacion, correo) VALUES (@identificacion, @fecha, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @inscripcion, @donacion, @correo)";
                        proxy.command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        proxy.command.Parameters.AddWithValue("@fecha", persona.fecha);
                        proxy.command.Parameters.AddWithValue("@nombre", persona.nombre);
                        proxy.command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        proxy.command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        proxy.command.Parameters.AddWithValue("@telefono", persona.telefono);
                        proxy.command.Parameters.AddWithValue("@profesion", persona.profesion);
                        proxy.command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        proxy.command.Parameters.AddWithValue("@inscripcion", persona.inscripcion);
                        proxy.command.Parameters.AddWithValue("@donacion", persona.donacion);
                        proxy.command.Parameters.AddWithValue("@correo", persona.correo);
                        //Se añaden los valores al comando

                        try
                        {
                            proxy.conexionSql.Open(); //Abre la conexión
                            int recordsAffected = proxy.command.ExecuteNonQuery(); //Ejecuta el comando
                            MessageBox.Show("Datos de Voluntario Agregado");   //Imprime
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al Agregar Voluntario"); //Imprime
                        }
                        finally
                        {
                            //MessageBox.Show("Se cerró la conexión"); //Imprime
                            proxy.conexionSql.Close();  //Cierra la conexión
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos Voluntario"); //Imprime
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que agrega la respectiva persona a su respectiva tabla
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="proxy"></param>
        /// <returns>true= si logró intropducir los datos
        /// false= si no logró introducir los datos</returns>
        public bool AgregarNino(Persona persona, Proxy proxy)
        {
            if (validacion.Validacion_Nino(persona)) //Si no falta ningún dato, entra 
            {
                using (proxy.conexionSql) //Llama a la instancia SqlConnection que está en la clase Proxy 
                {
                    using (proxy.command)
                    {
                        proxy.command.Connection = proxy.conexionSql;
                        proxy.command.CommandType = CommandType.Text; //Se le asigna a Texto el tipo de comando 
                        proxy.command.CommandText = "INSERT into Tbl_Nino (identificacion, nombre, apellido1, apellido2, telefono, domicilio, correo, fecha) VALUES (@identificacion, @nombre, @apellido1, @apellido2, @telefono, @domicilio, @correo, @fecha)";
                        proxy.command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        proxy.command.Parameters.AddWithValue("@nombre", persona.nombre);
                        proxy.command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        proxy.command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        proxy.command.Parameters.AddWithValue("@telefono", persona.telefono);
                        proxy.command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        proxy.command.Parameters.AddWithValue("@correo", persona.correo);
                        proxy.command.Parameters.AddWithValue("@fecha", persona.fecha);
                        //Se añaden los valores al comando
                        try
                        {
                            proxy.conexionSql.Open(); //Abre la conexión
                            int recordsAffected = proxy.command.ExecuteNonQuery();
                            MessageBox.Show("Datos de Niño Agregado");   //Imprime
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error al Agregar Niño"); //Imprime
                        }
                        finally
                        {
                            //MessageBox.Show("Se cerró la conexión"); //Imprime
                            proxy.conexionSql.Close(); //Cierra la conexión
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos Niño"); //Imprime
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que agrega la respectiva persona a su respectiva tabla
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="proxy"></param>
        /// <returns>true= si logró intropducir los datos
        /// false= si no logró introducir los datos</returns>
        public bool AgregarEncargadoNino(Persona persona, Proxy proxy)
        {
            if (validacion.Validacion_EncargadoNino(persona)) //Si no falta ningún dato, entra 
            {
                using (proxy.conexionSql) //Llama a la instancia SqlConnection que está en la clase Proxy 
                {
                    using (proxy.command)
                    {
                        proxy.command.Connection = proxy.conexionSql;
                        proxy.command.CommandType = CommandType.Text; //Se le asigna a Texto el tipo de comando 
                        proxy.command.CommandText = "INSERT into Tbl_EncargadoNino (fecha, identificacion, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo) VALUES (@fecha, @identificacion, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo)";
                        proxy.command.Parameters.AddWithValue("@fecha", persona.fecha);
                        proxy.command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        proxy.command.Parameters.AddWithValue("@nombre", persona.nombre);
                        proxy.command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        proxy.command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        proxy.command.Parameters.AddWithValue("@telefono", persona.telefono);
                        proxy.command.Parameters.AddWithValue("@profesion", persona.profesion);
                        proxy.command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        proxy.command.Parameters.AddWithValue("@correo", persona.correo);
                        //Se añaden los valores al comando
                        try
                        {
                            proxy.conexionSql.Open(); //Abre la conexión
                            int recordsAffected = proxy.command.ExecuteNonQuery();
                            MessageBox.Show("Datos de Encargado Agregado");   //Imprime
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error al Agregar Encargado"); //Imprime
                        }
                        finally
                        {
                            proxy.conexionSql.Close(); //Cierra la conexión
                            //MessageBox.Show("Se cerró la conexión"); //Imprime
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos Encargado"); //Imprime
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que agrega la respectiva persona a su respectiva tabla
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="proxy"></param>
        /// <returns>true= si logró intropducir los datos
        /// false= si no logró introducir los datos</returns>
        public bool AgregarPatrocinador(Persona persona, Proxy proxy)
        {
            if (validacion.Validacion_Patrocinador(persona)) //Si no falta ningún dato, entra 
            {
                using (proxy.conexionSql) //Llama a la instancia SqlConnection que está en la clase Proxy 
                {
                    using (proxy.command)
                    {
                        proxy.command.Connection = proxy.conexionSql;
                        proxy.command.CommandType = CommandType.Text; //Se le asigna a Texto el tipo de comando 
                        proxy.command.CommandText = "INSERT into Tbl_Patrocinadores (fecha, nombre_empresa, tipo_empresa, tipo_patrocinio, identificacion, nombre, apellido1, apellido2, telefono, correo) VALUES (@fecha, @nombre_empresa, @tipo_empresa, @tipo_patrocinio, @identificacion, @nombre, @apellido1, @apellido2, @telefono, @correo)";
                        proxy.command.Parameters.AddWithValue("@fecha", persona.fecha);
                        proxy.command.Parameters.AddWithValue("@nombre_empresa", persona.nombreEmpresa);
                        proxy.command.Parameters.AddWithValue("@tipo_empresa", persona.tipoEmpresa);
                        proxy.command.Parameters.AddWithValue("@tipo_patrocinio", persona.tipoPatrocinio);
                        proxy.command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        proxy.command.Parameters.AddWithValue("@nombre", persona.nombre);
                        proxy.command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        proxy.command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        proxy.command.Parameters.AddWithValue("@telefono", persona.telefono);
                        proxy.command.Parameters.AddWithValue("@correo", persona.correo);
                        //Se añaden los valores al comando

                        try
                        {
                            proxy.conexionSql.Open(); //Abre la conexión
                            int recordsAffected = proxy.command.ExecuteNonQuery();
                            MessageBox.Show("Datos de Patrocinador Agregado");   //Imprime
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error al Agregar Patrocinadores"); //Imprime
                        }
                        finally
                        {
                            proxy.conexionSql.Close(); //Cierra la conexión
                            //MessageBox.Show("Se cerró la conexión"); //Imprime
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos Patrocinador"); //Imprime
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que agrega la respectiva persona a su respectiva tabla
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="proxy"></param>
        /// <returns>true= si logró intropducir los datos
        /// false= si no logró introducir los datos</returns>
        public bool AgregarPadrino(Persona persona, Proxy proxy)
        {
            if (validacion.Validacion_Padrino(persona)) //Si no falta ningún dato, entra 
            {
                using (proxy.conexionSql) //Llama a la instancia SqlConnection que está en la clase Proxy 
                {
                    using (proxy.command)
                    {
                        proxy.command.Connection = proxy.conexionSql;
                        proxy.command.CommandType = CommandType.Text; //Se le asigna a Texto el tipo de comando 
                        proxy.command.CommandText = "INSERT into tbl_Padrinos (identificacion, fecha, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo, inscripcion, donacion) VALUES (@identificacion, @fecha, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo, @inscripcion, @donacion)";
                        proxy.command.Parameters.AddWithValue("@identificacion", persona.identificacion);
                        proxy.command.Parameters.AddWithValue("@fecha", persona.fecha);
                        proxy.command.Parameters.AddWithValue("@nombre", persona.nombre);
                        proxy.command.Parameters.AddWithValue("@apellido1", persona.primerApellido);
                        proxy.command.Parameters.AddWithValue("@apellido2", persona.segundoApellido);
                        proxy.command.Parameters.AddWithValue("@telefono", persona.telefono);
                        proxy.command.Parameters.AddWithValue("@profesion", persona.profesion);
                        proxy.command.Parameters.AddWithValue("@domicilio", persona.domicilio);
                        proxy.command.Parameters.AddWithValue("@correo", persona.correo);
                        proxy.command.Parameters.AddWithValue("@inscripcion", persona.inscripcion);
                        proxy.command.Parameters.AddWithValue("@donacion", persona.donacion);
                        //Se añaden los valores al comando
                        try
                        {
                            proxy.conexionSql.Open(); //Abre la conexión
                            int recordsAffected = proxy.command.ExecuteNonQuery();
                            MessageBox.Show("Datos de Padrino Agregado");   //Imprime
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error al Agregar Padrinos"); //Imprime
                        }
                        finally
                        {
                            //MessageBox.Show("Se cerró la conexión"); //Imprime
                            proxy.conexionSql.Close(); //Cierra la conexión
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos de Padrino"); //Imprime
                return false;
            }
            return true;
        }
    }
}



