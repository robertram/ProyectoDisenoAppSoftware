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
using Proyecto_Final.SQL;
using Proyecto_Final.Personas;

namespace Proyecto_Final
{
    public partial class AlimentandoEsperanzas : Form
    {
        ClienteDePersonas cliente = new ClienteDePersonas();

        public AlimentandoEsperanzas()
        {
            InitializeComponent();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarPadrino_Click(object sender, EventArgs e)
        {

            var fechadtpPadrino = dtp_FechaInscripcionPadrino.Value.ToString("yyyy-MM-dd");

            ClienteDePersonas cliente = new ClienteDePersonas();

            Persona padrino = cliente.CrearPadrino(txt_IdentificacionPadrino.Text, fechadtpPadrino, txt_NombrePadrino.Text, txt_PrimerApellidoPadrino.Text, txt_SegundoApellidoPadrino.Text, txt_TelefonoPadrino.Text, txt_ProfesionPadrino.Text, txt_DomicilioPadrino.Text, txt_CorreoPadrino.Text, cmb_InscripcionPadrino.Text, cmb_DonacionPadrino.Text);

            AgregarPersona agregar = new AgregarPersona();
            agregar.AgregarPadrino(padrino);

            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_AgregarNino_Click(object sender, EventArgs e)
        {
            //Convierte el Date Time Picker a un string 
            var fechadtpNino = dtp_FechaInscripcionNino.Value.ToString("yyyy-MM-dd");

            //Constructor ClienteDePersonas
            ClienteDePersonas cliente = new ClienteDePersonas();

            //Guarda el objeto Nino que devuelve el método CrearNino
            Persona nino = cliente.CrearNino(txt_IdNino.Text, txt_NombreNino.Text, txt_Apellido1Nino.Text, txt_Apellido2Nino.Text, txt_TelefonoNino.Text, txt_DomicilioNino.Text, txt_CorreoNino.Text, fechadtpNino);

            //
            AgregarPersona agregar = new AgregarPersona();
            agregar.AgregarNino(nino);

            Persona encargado = cliente.CrearEncargadoNino(fechadtpNino, txt_IdentificacionEncargadoNino.Text, txt_NombreEncargado.Text, txt_Apellido1Encargado.Text, txt_Apellido2Encargado.Text, txt_TelefonoEncargado.Text, txt_ProfesionEncargado.Text, txt_DomicilioEncargado.Text, txt_CorreoEncargado.Text);

            agregar.AgregarEncargadoNino(encargado);


            //Nino nino = new Nino(txt_NombreNino.Text, txt_Apellido1Nino.Text, txt_Apellido2Nino.Text, txt_TelefonoNino.Text, txt_DomicilioNino.Text, txt_CorreoNino.Text, fechadtpNino);

            //nino.AgregarDatosConObjeto(nino);
            ////No funciona aún

            //Encargado_Nino encargado = new Encargado_Nino(fechadtpNino, txt_IdentificacionEncargadoNino.Text, txt_NombreEncargado.Text, txt_Apellido1Encargado.Text, txt_Apellido2Encargado.Text, txt_TelefonoEncargado.Text, txt_ProfesionEncargado.Text, txt_DomicilioEncargado.Text, txt_CorreoEncargado.Text);
            //encargado.AgregarDatosConObjeto(encargado);
            ////No funciona aún
        }

        private void btn_AgregarPatrocinador_Click(object sender, EventArgs e)
        {
            var fechadtpPatrocinador = dtp_FechaPatrocinador.Value.ToString("yyyy-MM-dd");

            ClienteDePersonas cliente = new ClienteDePersonas();

            Persona patrocinador = cliente.CrearPatrocinador(fechadtpPatrocinador, txt_NombreEmpresaPatrocinadora.Text, txt_TipoEmpresaPatrocinadora.Text, cmb_TipoPatrocinio.Text, txt_IdentificacionRepresentantePatrocinador.Text, txt_NombreRepresentantePatrocinador.Text, txt_PrimerApellidoPatrocinador.Text, txt_SegundoApellidoPatrocinador.Text, txt_TelefonoRepresentantePatrocinador.Text, txt_CorreoRepresentantePatrocinador.Text);

            AgregarPersona agregar = new AgregarPersona();
            agregar.AgregarPatrocinador(patrocinador);


            //Patrocinador patrocinador = new Patrocinador(txt_IdentificacionRepresentantePatrocinador.Text, txt_NombreEmpresaPatrocinadora.Text, txt_TipoEmpresaPatrocinadora.Text, cmb_TipoPatrocinio.Text, txt_NombreRepresentantePatrocinador.Text, txt_PrimerApellidoPatrocinador.Text, txt_SegundoApellidoPatrocinador.Text, txt_TelefonoRepresentantePatrocinador.Text, txt_CorreoRepresentantePatrocinador.Text);
            //patrocinador.AgregarDatosConObjeto(patrocinador);
            ////No funciona aún
        }


        //------------------------------------------------------------------------------------------------------------------------
        private void btn_AgregarVoluntario_Click(object sender, EventArgs e)
        {

            //Variable que transforma la fecha a String
            var fechadtpVoluntario = dtp_FechaInscripcionVoluntario.Value.ToString("yyyy-MM-dd");

            ClienteDePersonas cliente = new ClienteDePersonas();

            var volunt = cliente.CrearVoluntario(txt_IdentificaciónVoluntario.Text, fechadtpVoluntario, txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text, txt_CorreoVoluntario.Text);

            AgregarPersona agregar = new AgregarPersona();
            agregar.AgregarVoluntario(volunt);


            //Instancia con los datos
            //Voluntario voluntarioEjemplo = new Voluntario(txt_IdentificaciónVoluntario.Text, fechadtpVoluntario, txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text, txt_CorreoVoluntario.Text);
            
            //Método Agregar Datos
            //voluntarioEjemplo.AgregarDatosConObjeto(voluntarioEjemplo);

            
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

        //----------------------------------------- BUSCADOR --------------------------------------------------

        ConsultasSQL sql = new ConsultasSQL();

        private void tab_Buscador_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(sql.Eliminar(cmb_Tabla.SelectedItem.ToString(), txt_busc_codigo.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView1.DataSource = sql.MostrarDatos(cmb_Tabla.SelectedItem.ToString());
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cmb_Tabla.SelectedItem.ToString().Equals("Niños"))
            {
                if (txt_busc_nombre.Text != "")
                {
                    dataGridView1.DataSource = sql.BuscarNombre("tbl_Nino", txt_busc_nombre.Text);

                }
                else dataGridView1.DataSource = sql.MostrarDatos(cmb_Tabla.SelectedItem.ToString());
            }
            else if (cmb_Tabla.SelectedItem.ToString().Equals("Encargados"))
            {
                if (txt_busc_identificacion.Text != "" && txt_busc_nombre.Text != "")
                {
                    dataGridView1.DataSource = sql.BuscarAmbos("EncaradoNino", txt_busc_identificacion.Text, txt_busc_nombre.Text);
                }
                else if (txt_busc_identificacion.Text != "" && txt_busc_nombre.Text == "")
                {
                    dataGridView1.DataSource = sql.BuscarIdentificacion("EncaradoNino".ToString(), txt_busc_identificacion.Text);
                }
                else if (txt_busc_identificacion.Text == "" && txt_busc_nombre.Text != "")
                {
                    dataGridView1.DataSource = sql.BuscarNombre("EncaradoNino", txt_busc_nombre.Text);
                }
                else dataGridView1.DataSource = sql.MostrarDatos("EncaradoNino");
            }
            else
            {
                if (txt_busc_identificacion.Text != "" && txt_busc_nombre.Text != "")
                {
                    dataGridView1.DataSource = sql.BuscarAmbos(cmb_Tabla.SelectedItem.ToString(), txt_busc_identificacion.Text, txt_busc_nombre.Text);
                }
                else if (txt_busc_identificacion.Text != "" && txt_busc_nombre.Text == "")
                {
                    dataGridView1.DataSource = sql.BuscarIdentificacion(cmb_Tabla.SelectedItem.ToString(), txt_busc_identificacion.Text);
                }
                else if (txt_busc_identificacion.Text == "" && txt_busc_nombre.Text != "")
                {
                    dataGridView1.DataSource = sql.BuscarNombre(cmb_Tabla.SelectedItem.ToString(), txt_busc_nombre.Text);
                }
                else dataGridView1.DataSource = sql.MostrarDatos(cmb_Tabla.SelectedItem.ToString());
            }
        }

        private void cmb_Tabla_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Tabla.SelectedItem.ToString().Equals("Niños"))
            {
                txt_busc_identificacion.Visible = false;
            }
            else txt_busc_identificacion.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            txt_busc_codigo.Text = Convert.ToString(fila.Cells[0].Value);

        }
    }
}
