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
            Patrocinador patrocinador = new Patrocinador(txt_IdentificacionRepresentantePatrocinador.Text, txt_NombreEmpresaPatrocinadora.Text, txt_TipoEmpresaPatrocinadora.Text, cmb_TipoPatrocinio.Text, txt_NombreRepresentantePatrocinador.Text, txt_PrimerApellidoPatrocinador.Text, txt_SegundoApellidoPatrocinador.Text, txt_TelefonoRepresentantePatrocinador.Text, txt_CorreoRepresentantePatrocinador.Text);
            patrocinador.AgregarDatosConObjeto(patrocinador);

        }


        //------------------------------------------------------------------------------------------------------------------------
        private void btn_AgregarVoluntario_Click(object sender, EventArgs e)
        {
            //Variable que transforma la fecha a String
            var fechadtp = dtp_FechaInscripcionVoluntario.Value.ToString("yyyy-MM-dd");

            //Instancia con los datos
            Voluntario voluntarioEjemplo = new Voluntario(txt_IdentificaciónVoluntario.Text, fechadtp, txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text, txt_CorreoVoluntario.Text);
            
            //Método Agregar Datos
            voluntarioEjemplo.AgregarDatosConObjeto(voluntarioEjemplo);

            
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
