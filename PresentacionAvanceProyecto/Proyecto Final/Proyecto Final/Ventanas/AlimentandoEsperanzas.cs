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
using Proyecto_Final.Personas;

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

        }

        private void btn_AgregarPadrino_Click(object sender, EventArgs e)
        {
            Padrino pad = new Padrino(txt_IdentificacionPadrino.Text, dtp_FechaInscripcionPadrino.Text, txt_NombrePadrino.Text, txt_PrimerApellidoPadrino.Text, txt_SegundoApellidoPadrino.Text, txt_TelefonoPadrino.Text, txt_ProfesionPadrino.Text, txt_DomicilioPadrino.Text, txt_CorreoPadrino.Text, cmb_InscripcionPadrino.Text, cmb_DonacionPadrino.Text);
            pad.AgregarDatosConObjeto(pad);

            MessageBox.Show("Padrino Agregado");


            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_AgregarNino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Niño");
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



            Voluntario voluntarioEjemplo = new Voluntario(txt_IdentificaciónVoluntario.Text/*, dtp_FechaInscripcionVoluntario.Text*/, txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text, txt_CorreoVoluntario.Text);
            
            voluntarioEjemplo.AgregarDatosConObjeto(voluntarioEjemplo);

            PersonaPrueba per = new PersonaPrueba(txtNombrePersonaPrueba.Text);
            per.AgregarDatosConObjeto(per);


            //Fecha fe = new Fecha(dtp_SoloFecha.Value.Date);
            //fe.AgregarDatosConObjeto(fe);


            //txtNombrePersonaPrueba.Text

        }

        private void cmb_DonacionVoluntario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_DonacionVoluntario.SelectedItem.ToString().Equals("Otros"))
            {
                txt_VoluntarioDonacionOtros.Visible = true;
            }
            else
            {
                txt_VoluntarioDonacionOtros.Visible= false;
            }
        }

        
    }
}
