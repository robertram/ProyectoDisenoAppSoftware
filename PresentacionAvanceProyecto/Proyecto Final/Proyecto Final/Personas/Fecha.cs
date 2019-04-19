using Proyecto_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Personas
{
    class Fecha
    {
        private string _fecha;

        public Fecha(string fecha)
        {
            _fecha = fecha;
        }

        

        //public bool AgregarDatosConObjeto(Fecha fecha)
        //{
        //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OBB3PNQ;Initial Catalog=Prueba;Integrated Security=True"))
        //    {
        //        using (SqlCommand command = new SqlCommand())
        //        {
        //            command.Connection = connection;            // <== lacking
        //            command.CommandType = CommandType.Text;
        //            command.CommandText = "INSERT into Tbl_SoloFecha (fecha) VALUES (@fecha)";

        //            command.Parameters.AddWithValue("@fecha", fecha.Get_fecha()).Value= 


        //            try
        //            {
        //                connection.Open();
        //                int recordsAffected = command.ExecuteNonQuery();
        //            }
        //            catch (SqlException)
        //            {
        //                MessageBox.Show("Catch Voluntario");
        //            }
        //            finally
        //            {
        //                connection.Close();
        //            }
        //        }
        //    }
        //    return true;
        //}

        public bool ValidarConObjeto(Padrino padrino)
        {
            throw new NotImplementedException();
        }
    }
}
