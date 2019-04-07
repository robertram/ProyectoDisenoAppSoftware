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
    /// esta clase son las personas que especificamente son voluntarios. Tiene tres atributos propios que son necesarios manejar en el
    /// caso de los voluntarios. Tiene setters y getters para los atributos. 
    /// </summary>
    public class Voluntario : AbstractPersona, IVoluntario
    {
        private string _fecha;
        private string _inscripcion;
        private string _donacion;


        /// <summary>
        /// Constructor de Voluntario 
        /// Sin el constructor no se podría pasar el Objeto Voluntario como parámetro en un método
        /// </summary>
        /// 
        /// <param name="identificacion"></param>
        /// <param name="fecha"></param>
        /// <param name="nombreCompleto"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="telefono"></param>
        /// <param name="profesion"></param>
        /// <param name="domicilio"></param>
        /// <param name="correo"></param>
        /// <param name="inscripcion"></param>
        /// <param name="donacion"></param>
        public Voluntario(string identificacion, string fecha, string nombreCompleto, string primerApellido, string segundoApellido, string telefono, string profesion, string domicilio, string correo, /*string identificacion,*/ string inscripcion, string donacion)
        {
            this.Set_identificacion(identificacion);
            this.Set_fecha(fecha);
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
        
        

        /// <summary>
        /// Agrega datos a la base de datos con el objeto Voluntario como parámetro
        /// </summary>
        /// <param name="voluntario"></param>
        /// <returns>
        /// true si agrega el datos
        /// false si no valida los datos de la ventana o si no logra agregar el dato a la base de datos
        /// </returns>
        public bool AgregarDatosConObjeto(Voluntario voluntario)
        {
            if (ValidarConObjeto(voluntario))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Tbl_Voluntario (identificacion, fecha, nombre, apellido1, apellido2, telefono, profesion, domicilio, correo, inscripcion, donacion) VALUES (@identificacion, @fecha, @nombre, @apellido1, @apellido2, @telefono, @profesion, @domicilio, @correo, @inscripcion, @donacion)";
                        command.Parameters.AddWithValue("@identificacion", voluntario.Get_identificacion());
                        command.Parameters.AddWithValue("@fecha", voluntario.Get_fecha());
                        command.Parameters.AddWithValue("@nombre", voluntario.Get_nombreCompleto());
                        command.Parameters.AddWithValue("@apellido1", voluntario.Get_primerApellido());
                        command.Parameters.AddWithValue("@apellido2", voluntario.Get_segundoApellido());
                        command.Parameters.AddWithValue("@telefono", voluntario.Get_telefono());
                        command.Parameters.AddWithValue("@profesion", voluntario.Get_profesion());
                        command.Parameters.AddWithValue("@domicilio", voluntario.Get_domicilio());
                        command.Parameters.AddWithValue("@correo", voluntario.Get_correo());
                        command.Parameters.AddWithValue("@inscripcion", _inscripcion);
                        command.Parameters.AddWithValue("@donacion", _donacion);
                        

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

        /// <summary>
        /// Valida que los datos estén en los TextBox de la ventana AlimentandoEsperanzas en la pestaña de Voluntario
        /// </summary>
        /// <param name="voluntario"></param>
        /// <returns>
        /// true si valida correctamente
        /// false si hay un campo vacío
        /// </returns>
        public bool ValidarConObjeto(Voluntario voluntario)
        {
            if (string.IsNullOrWhiteSpace(voluntario.Get_nombreCompleto())
                || string.IsNullOrWhiteSpace(voluntario.Get_fecha())
                || string.IsNullOrWhiteSpace(voluntario.Get_primerApellido())
                || string.IsNullOrWhiteSpace(voluntario.Get_segundoApellido())
                || string.IsNullOrWhiteSpace(voluntario.Get_telefono())
                || string.IsNullOrWhiteSpace(voluntario.Get_profesion())
                || string.IsNullOrWhiteSpace(voluntario.Get_domicilio())
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
    }

}