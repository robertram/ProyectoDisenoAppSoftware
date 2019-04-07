using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public partial class AlimentandoEsperanzas : Form
    {
        public AlimentandoEsperanzas()
        {
            InitializeComponent();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            ////Esta parte valida que ni los TextBox ni comboBox estén vacios.

            //if (string.IsNullOrWhiteSpace(txt_NombreCompleto.Text)
            //    || string.IsNullOrWhiteSpace(txt_PrimerApellido.Text)
            //    || string.IsNullOrWhiteSpace(txt_SegundoApellido.Text)
            //    || string.IsNullOrWhiteSpace(txt_Telefono.Text)
            //    || string.IsNullOrWhiteSpace(txt_Profesion.Text)
            //    || string.IsNullOrWhiteSpace(txt_Domicilio.Text)
            //    || string.IsNullOrWhiteSpace(txt_Correo.Text)
            //    || string.IsNullOrWhiteSpace(cmb_Inscripcion.Text)
            //    || string.IsNullOrWhiteSpace(cmb_Donacion.Text)
            //    )
            //{
            //    //Si están vacías le avisa al usuario que debe de llenar los campos correctamente. 
            //    MessageBox.Show("Llene todas las casillas."); 
            //}
            //else {
            //    //Si los datos están correctamente llenados, agrega cada dato con un Append al StringBuilder. 

            //    StringBuilder datosString = new StringBuilder();
            //    //datosString.Append(dtp_FechaInscripcion.Text + ",");
            //    datosString.Append(txt_NombreCompleto.Text + ",");
            //    datosString.Append(txt_PrimerApellido.Text + ",");
            //    datosString.Append(txt_SegundoApellido.Text + ",");
            //    datosString.Append(txt_Telefono.Text + ",");
            //    datosString.Append(txt_Profesion.Text + ",");
            //    datosString.Append(txt_Domicilio.Text + ",");
            //    datosString.Append(txt_Correo.Text + ",");
            //    datosString.Append(cmb_Inscripcion.Text + ",");
            //    datosString.Append(cmb_Donacion.Text);

            //    //Creamos un array llamado parametros 
            //    string[] parametros;

            //    //dividimos los paramentros con comas
            //    parametros = datosString.ToString().Split(',');
            //    Padrino PadrinoEjemplo = new Padrino();

            //    //Se envía la información al objeto para que se guarde, luego de esto la información se enviará a la base de datos
            //    //Esta misma información la muestra en un MessageBox
            //    PadrinoEjemplo.AgregarDato(parametros);

                
            //    //salida
            //    StringBuilder mensaje = new StringBuilder();
            //    //mensaje.AppendLine("Fecha de inscripción: " + PadrinoEjemplo.GetFecha() + ".");
            //    mensaje.AppendLine("Nombre completo: " + PadrinoEjemplo.GetNombreCompleto() + ".");
            //    mensaje.AppendLine("Primer apellido: " + PadrinoEjemplo.GetPrimerApellido() + ".");
            //    mensaje.AppendLine("Segundo apellido: " + PadrinoEjemplo.GetSegundoApellido() + ".");
            //    mensaje.AppendLine("Teléfono: " + PadrinoEjemplo.GetTelefono() + ".");
            //    mensaje.AppendLine("Profesión: " + PadrinoEjemplo.GetProfesion() + ".");
            //    mensaje.AppendLine("Domicilio: " + PadrinoEjemplo.GetDomicilio() + ".");
            //    mensaje.AppendLine("Correo: " + PadrinoEjemplo.GetCorreo() + ".");
            //    mensaje.AppendLine("Inscripción: " + PadrinoEjemplo.GetInscripcion() + ".");
            //    mensaje.AppendLine("Donación: " + PadrinoEjemplo.GetDonacion() + ".");
            //    MessageBox.Show(PadrinoEjemplo.Tipo_Persona() + "\n" + mensaje.ToString());
            //}
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_AgregarNino_Click(object sender, EventArgs e)
        {
            ////Esta parte valida que ni los TextBox ni comboBox estén vacios.
            //if (string.IsNullOrWhiteSpace(txt_NombreNino.Text)
            //    || string.IsNullOrWhiteSpace(txt_Apellido1Nino.Text)
            //    || string.IsNullOrWhiteSpace(txt_Apellido2Nino.Text)
            //    || string.IsNullOrWhiteSpace(txt_TelefonoNino.Text)
            //    || string.IsNullOrWhiteSpace(txt_DomicilioNino.Text)
            //    || string.IsNullOrWhiteSpace(txt_CorreoNino.Text)
            //    ||string.IsNullOrWhiteSpace(txt_NombreEncargado.Text)
            //    || string.IsNullOrWhiteSpace(txt_Apellido1Encargado.Text)
            //    || string.IsNullOrWhiteSpace(txt_Apellido2Encargado.Text)
            //    || string.IsNullOrWhiteSpace(txt_TelefonoEncargado.Text)
            //    || string.IsNullOrWhiteSpace(txt_ProfesionEncargado.Text)
            //    || string.IsNullOrWhiteSpace(txt_DomicilioEncargado.Text)
            //    || string.IsNullOrWhiteSpace(txt_CorreoEncargado.Text)
            //    )
            //{
            //    //Si están vacías le avisa al usuario que debe de llenar los campos correctamente. 
            //    MessageBox.Show("Llene todas las casillas.");
            //}
            //else
            //{
            //    //Si los datos están correctamente llenados, agrega cada dato con un Append al StringBuilder.
            //    StringBuilder datosStringNino = new StringBuilder();
            //    //datosStringNino.Append(dtp_FechaInscripcionNino.Text + ",");
            //    datosStringNino.Append(txt_NombreNino.Text + ",");
            //    datosStringNino.Append(txt_Apellido1Nino.Text + ",");
            //    datosStringNino.Append(txt_Apellido2Nino.Text + ",");
            //    datosStringNino.Append(txt_TelefonoNino.Text + ",");
            //    datosStringNino.Append(txt_DomicilioNino.Text + ",");
            //    datosStringNino.Append(txt_CorreoNino.Text);

            //    //Creamos un array llamado parametrosNino 
            //    string[] parametrosNino;

            //    //dividimos los paramentros con comas
            //    parametrosNino = datosStringNino.ToString().Split(',');
            //    Nino NuevoNino = new Nino();
            //    NuevoNino.AgregarDato(parametrosNino);
                
            //    StringBuilder datosStringEncargado = new StringBuilder();
            //    datosStringEncargado.Append(txt_NombreEncargado.Text + ",");
            //    datosStringEncargado.Append(txt_Apellido1Encargado.Text + ",");
            //    datosStringEncargado.Append(txt_Apellido2Encargado.Text + ",");
            //    datosStringEncargado.Append(txt_TelefonoEncargado.Text + ",");
            //    datosStringEncargado.Append(txt_ProfesionEncargado.Text + ",");
            //    datosStringEncargado.Append(txt_DomicilioEncargado.Text + ",");
            //    datosStringEncargado.Append(txt_CorreoEncargado.Text);

            //    string[] parametrosEncargado;
            //    parametrosEncargado = datosStringEncargado.ToString().Split(',');
            //    Encargado_Nino NuevoEncargado = new Encargado_Nino();
                
            //    //Se envía la información al objeto para que se guarde, luego de esto la información se enviará a la base de datos
            //    //Esta misma información la muestra en un MessageBox
            //    NuevoEncargado.AgregarDato(parametrosEncargado);

            //    //salida
            //    StringBuilder mensaje = new StringBuilder();
            //    mensaje.AppendLine("Niño");
            //   // mensaje.AppendLine("Fecha de Inscripción: " + NuevoNino.GetFecha() + ".");
            //    mensaje.AppendLine("Nombre: " + NuevoNino.GetNombreCompleto() + ".");
            //    mensaje.AppendLine("Primer apellido: " + NuevoNino.GetPrimerApellido() + ".");
            //    mensaje.AppendLine("Segundo apellido: " + NuevoNino.GetSegundoApellido() + ".");
            //    mensaje.AppendLine("Teléfono: " + NuevoNino.GetTelefono() + ".");
            //    mensaje.AppendLine("Correo: " + NuevoNino.GetCorreo() + ".");
            //    mensaje.AppendLine("Domicilio: " + NuevoNino.GetDomicilio() + ".");
            //    mensaje.AppendLine("");
            //    mensaje.AppendLine("Encargado");
            //    mensaje.AppendLine("Nombre: " + NuevoEncargado.GetNombreCompleto() + ".");
            //    mensaje.AppendLine("Primer apellido: " + NuevoEncargado.GetPrimerApellido() + ".");
            //    mensaje.AppendLine("Segundo apellido: " + NuevoEncargado.GetSegundoApellido() + ".");
            //    mensaje.AppendLine("Teléfono: " + NuevoEncargado.GetTelefono() + ".");
            //    mensaje.AppendLine("Correo: " + NuevoEncargado.GetCorreo() + ".");
            //    mensaje.AppendLine("Domicilio: " + NuevoEncargado.GetDomicilio() + ".");
            //    MessageBox.Show(NuevoNino.Tipo_Persona() + "\n" + mensaje.ToString());
            //}
        }

        private void btn_AgregarPatrocinador_Click(object sender, EventArgs e)
        {
            ////Esta parte valida que ni los TextBox ni comboBox estén vacios.
            //if (string.IsNullOrWhiteSpace(txt_NombreEmpresa.Text)
            //    || string.IsNullOrWhiteSpace(txt_TipoEmpresa.Text)
            //    || string.IsNullOrWhiteSpace(cmb_TipoPatrocinio.Text)
            //    || string.IsNullOrWhiteSpace(txt_NombreRepresentante.Text)
            //    || string.IsNullOrWhiteSpace(txt_PApellido.Text)
            //    || string.IsNullOrWhiteSpace(txt_SApellido.Text)
            //    || string.IsNullOrWhiteSpace(txt_TelefonoRepresentante.Text)
            //    || string.IsNullOrWhiteSpace(txt_CorreoRepresentante.Text)
            //    )
            //{
            //    //Si están vacías le avisa al usuario que debe de llenar los campos correctamente.
            //    MessageBox.Show("Llene todas las casillas.");
            //}
            //else
            //{
            //    //Si los datos están correctamente llenados, agrega cada dato con un Append al StringBuilder.
            //    StringBuilder datosString = new StringBuilder();
            //    datosString.Append(txt_NombreEmpresa.Text + ",");
            //    datosString.Append(txt_TipoEmpresa.Text + ",");
            //    datosString.Append(cmb_TipoPatrocinio.Text + ",");
            //    datosString.Append(txt_NombreRepresentante.Text + ",");
            //    datosString.Append(txt_PApellido.Text + ",");
            //    datosString.Append(txt_SApellido.Text + ",");
            //    datosString.Append(txt_TelefonoRepresentante.Text + ",");
            //    datosString.Append(txt_CorreoRepresentante.Text);

            //    //Creamos un array llamado parametros
            //    string[] parametros;

            //    //dividimos los paramentros con comas
            //    parametros = datosString.ToString().Split(',');

            //    Empresa_Patrocinadora empresa = new Empresa_Patrocinadora();
            //    Representante_Empresarial RepresentanteEjemplo = new Representante_Empresarial();
            //    //               empresa.AgregarDato(parametros);

            //    //Se envía la información al objeto para que se guarde, luego de esto la información se enviará a la base de datos
            //    //Esta misma información la muestra en un MessageBox
            //    RepresentanteEjemplo.AgregarDato(parametros);
            //    //salida
            //    StringBuilder mensaje = new StringBuilder();
            //    mensaje.AppendLine("Nombre de la empresa: " + empresa.GetNombre_Compania() + ".");
            //    mensaje.AppendLine("Tipo de empresa: " + empresa.GetTipo_Empresa() + ".");
            //    mensaje.AppendLine("Tipo de patrocinio: " + empresa.GetTipo_patrocinio() + ".");
            //    mensaje.AppendLine("Nombre completo: " +  RepresentanteEjemplo.GetNombreCompleto() + ".");
            //    mensaje.AppendLine("Primer apellido: " + RepresentanteEjemplo.GetPrimerApellido() + ".");
            //    mensaje.AppendLine("Segundo apellido: " + RepresentanteEjemplo.GetSegundoApellido() + ".");
            //    mensaje.AppendLine("Teléfono: " + RepresentanteEjemplo.GetTelefono() + ".");
            //    mensaje.AppendLine("Correo: " + RepresentanteEjemplo.GetCorreo() + ".");
            //    MessageBox.Show(empresa.Tipo_Persona() + "\n" + mensaje.ToString());
            //    MessageBox.Show(RepresentanteEjemplo.Tipo_Persona() + "\n" + mensaje.ToString());
            //}
        }

        private void btn_AgregarVoluntario_Click(object sender, EventArgs e)
        {

            

            Voluntario voluntarioEjemplo = new Voluntario(dtp_FechaInscripcionVoluntario.Text, txt_IdentificaciónVoluntario.Text, txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, txt_CorreoVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text);
            

            voluntarioEjemplo.AgregarDatosConObjeto(voluntarioEjemplo);

                //voluntarioEjemplo.Agregar_DatosPersona(txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, txt_CorreoVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text/*, dtp_FechaInscripcionVoluntario.Text*/);




            //dtp_FechaInscripcionVoluntario.Text

            /*
            //Si los datos están correctamente llenados, agrega cada dato con un Append al StringBuilder.
            StringBuilder datosString = new StringBuilder();
                datosString.Append(dtp_FechaInscripcionVoluntario.Text + ",");
                datosString.Append(txt_NombreVoluntario.Text + ",");
                datosString.Append(txt_Apellido1Voluntario.Text + ",");
                datosString.Append(txt_Apellido2Voluntario.Text + ",");
                datosString.Append(txt_TelefonoVoluntario.Text + ",");
                datosString.Append(txt_ProfesionVoluntario.Text + ",");
                datosString.Append(txt_DomicilioVoluntario.Text + ",");
                datosString.Append(txt_CorreoVoluntario.Text + ",");
                datosString.Append(cmb_InscripcionVoluntario.Text + ",");
                datosString.Append(cmb_DonacionVoluntario.Text);


            //Creamos un array llamado parametros 
            string[] parametros;

            //dividimos los paramentros con comas
            parametros = datosString.ToString().Split(',');


            //voluntarioEjemplo.Validacion_DatosPersona(txt_NombreVoluntario.Text);

            //Se envía la información al objeto para que se guarde, luego de esto la información se enviará a la base de datos
            //Esta misma información la muestra en un MessageBox
            voluntarioEjemplo.AgregarDato(parametros);
                //salida
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("Fecha de inscripción: " + voluntarioEjemplo.GetFecha() + ".");
                mensaje.AppendLine("Nombre completo: " + voluntarioEjemplo.GetNombreCompleto() + ".");
                mensaje.AppendLine("Primer apellido: " + voluntarioEjemplo.GetPrimerApellido() + ".");
                mensaje.AppendLine("Segundo apellido: " + voluntarioEjemplo.GetSegundoApellido() + ".");
                mensaje.AppendLine("Teléfono: " + voluntarioEjemplo.GetTelefono() + ".");
                mensaje.AppendLine("Profesión: " + voluntarioEjemplo.GetProfesion() + ".");
                mensaje.AppendLine("Domicilio: " + voluntarioEjemplo.GetDomicilio() + ".");
                mensaje.AppendLine("Correo: " + voluntarioEjemplo.GetCorreo() + ".");
                mensaje.AppendLine("Inscripción: " + voluntarioEjemplo.GetInscripcion() + ".");
            mensaje.AppendLine("Donación: " + voluntarioEjemplo.GetDonacion() + ".");
                mensaje.AppendLine("Validacion "+ voluntarioEjemplo.Validacion_DatosPersona(txt_NombreVoluntario.Text).ToString());
                MessageBox.Show(voluntarioEjemplo.Tipo_Persona() + "\n" + mensaje.ToString());*/



        }

        private void cmb_DonacionVoluntario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_DonacionVoluntario.SelectedItem.ToString().Equals("Otros"))
            {
                Donacion.Visible = true;
            }
            else
            {
                Donacion.Visible= false;
            }
        }
    }
}
