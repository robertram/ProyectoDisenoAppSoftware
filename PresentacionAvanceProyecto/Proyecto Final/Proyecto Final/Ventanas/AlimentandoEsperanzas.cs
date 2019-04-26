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
        ////
        //static ClienteDePersonas cliente = new ClienteDePersonas();
        ////
        //static Proxy proxy = new Proxy();
        ////
        //static AgregarPersona agregar = new AgregarPersona();

        public AlimentandoEsperanzas()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarPadrino_Click(object sender, EventArgs e)
        {
            //Variable guarda la fecha del DateTimePicker y lo pasa a String
            var fechadtpPadrino = dtp_FechaInscripcionPadrino.Value.ToString("yyyy-MM-dd");

            //Instancias de ClienteDePersonas, AgregarPersona y Proxy
            ClienteDePersonas cliente = new ClienteDePersonas();
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();

            //Método cliente.CrearPadrino devuelve objeto Tipo Persona y se guarda en la variable padrino
            Persona padrino = cliente.CrearPadrino(txt_IdentificacionPadrino.Text, fechadtpPadrino, txt_NombrePadrino.Text, txt_PrimerApellidoPadrino.Text, txt_SegundoApellidoPadrino.Text, txt_TelefonoPadrino.Text, txt_ProfesionPadrino.Text, txt_DomicilioPadrino.Text, txt_CorreoPadrino.Text, cmb_InscripcionPadrino.Text, cmb_DonacionPadrino.Text);
            
            agregar.AgregarPadrino(padrino, proxy);

            //Se crea la lista
            List<IPersona> list = new List<IPersona>();

            //Sse agrega a la lista
            list.Add(padrino);

            //Se crea el visitor
            IVisitante datos = new SetDatos();
            datos.VisitorAceptar(list);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_AgregarNino_Click(object sender, EventArgs e)
        {
            //Variable guarda la fecha del DateTimePicker y lo pasa a String
            var fechadtpNino = dtp_FechaInscripcionNino.Value.ToString("yyyy-MM-dd");

            //Instancias de ClienteDePersonas, AgregarPersona y Proxy
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();

            //Guarda el objeto Nino que devuelve el método CrearNino
            Persona nino = cliente.CrearNino(txt_IdNino.Text, txt_NombreNino.Text, txt_Apellido1Nino.Text, txt_Apellido2Nino.Text, txt_TelefonoNino.Text, txt_DomicilioNino.Text, txt_CorreoNino.Text, fechadtpNino);

            //Método agrega el nino
            agregar.AgregarNino(nino, proxy);

            //Método cliente.CrearEncargadoNino devuelve objeto Tipo Persona y se guarda en la variable encargado
            Persona encargado = cliente.CrearEncargadoNino(fechadtpNino, txt_IdentificacionEncargadoNino.Text, txt_NombreEncargado.Text, txt_Apellido1Encargado.Text, txt_Apellido2Encargado.Text, txt_TelefonoEncargado.Text, txt_ProfesionEncargado.Text, txt_DomicilioEncargado.Text, txt_CorreoEncargado.Text);
            proxy = new Proxy();

            //Método agrega el EncargadoNino
            agregar.AgregarEncargadoNino(encargado, proxy);

            //Se crea la lista
            List<IPersona> list = new List<IPersona>();

            //Sse agrega a la lista
            list.Add(nino);

            //Se crea el visitor
            IVisitante datos = new SetDatos();
            datos.VisitorAceptar(list);
        }

        private void btn_AgregarPatrocinador_Click(object sender, EventArgs e)
        {
            //Variable guarda la fecha del DateTimePicker y lo pasa a String
            var fechadtpPatrocinador = dtp_FechaPatrocinador.Value.ToString("yyyy-MM-dd");

            //Instancias de ClienteDePersonas, AgregarPersona y Proxy
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();

            //Método cliente.CrearPatrocinador devuelve objeto Tipo Persona y se guarda en la variable patrocinador
            Persona patrocinador = cliente.CrearPatrocinador(fechadtpPatrocinador, txt_NombreEmpresaPatrocinadora.Text, txt_TipoEmpresaPatrocinadora.Text, cmb_TipoPatrocinio.Text, txt_IdentificacionRepresentantePatrocinador.Text, txt_NombreRepresentantePatrocinador.Text, txt_PrimerApellidoPatrocinador.Text, txt_SegundoApellidoPatrocinador.Text, txt_TelefonoRepresentantePatrocinador.Text, txt_CorreoRepresentantePatrocinador.Text);
            
            //Método agrega el Patrocinador
            agregar.AgregarPatrocinador(patrocinador, proxy);

            //Se crea la lista
            List<IPersona> list = new List<IPersona>();

            //Sse agrega a la lista
            list.Add(patrocinador);

            //Se crea el visitor
            IVisitante datos = new SetDatos();
            datos.VisitorAceptar(list);
        }


        //------------------------------------------------------------------------------------------------------------------------
        private void btn_AgregarVoluntario_Click(object sender, EventArgs e)
        {
            //Variable guarda la fecha del DateTimePicker y lo pasa a String
            var fechadtpVoluntario = dtp_FechaInscripcionVoluntario.Value.ToString("yyyy-MM-dd");

            //Instancias de ClienteDePersonas, AgregarPersona y Proxy
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();

            //Método cliente.CrearVoluntario devuelve objeto Tipo Persona y se guarda en la variable volunt
            var voluntario = cliente.CrearVoluntario(txt_IdentificaciónVoluntario.Text, fechadtpVoluntario, txt_NombreVoluntario.Text, txt_Apellido1Voluntario.Text, txt_Apellido2Voluntario.Text, txt_TelefonoVoluntario.Text, txt_ProfesionVoluntario.Text, txt_DomicilioVoluntario.Text, cmb_InscripcionVoluntario.Text, cmb_DonacionVoluntario.Text, txt_CorreoVoluntario.Text);
            
            //Método agrega el Voluntario
            agregar.AgregarVoluntario(voluntario, proxy);

            //Se crea la lista
            List<IPersona> list = new List<IPersona>();

            //Sse agrega a la lista
            list.Add(voluntario);

            //Se crea el visitor
            IVisitante datos = new SetDatos();
            datos.VisitorAceptar(list);

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

        //Método para cuando se da click en el botón de eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Proxy proxy = new Proxy();
            try
            {
                //Verifica que haya un código que eliminar
                if (txt_busc_codigo.Text.Equals(""))
                {
                    //Si no hay un código seleccionado pide que se seleccione uno
                    MessageBox.Show("Por favor seleccione un código");
                }
                else
                {
                    //Si hay un códido se llama el método para eliminar de ConsultasSQL
                    if (sql.Eliminar(cmb_Tabla.SelectedItem.ToString(), txt_busc_codigo.Text, proxy))
                    {
                        //Se confirma que se hayan eliminado los datos
                        MessageBox.Show("Datos eliminados");
                        //Se actualiza el Data Grid View
                        dataGridView1.DataSource = sql.MostrarDatos(cmb_Tabla.SelectedItem.ToString(), proxy);
                    }
                    //Si no se pueden eliminar los datos se muestra un mensaje
                    else MessageBox.Show("No se han podido eliminar los datos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        //Inicia el método para cuando se haga click al botón de buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Proxy proxy = new Proxy();
            //Se verificará con cuales datos se realizará la busqueda
            try
            {
                //En este caso se busca con identificación y nombre
                if (txt_busc_identificacion.Text != "" && txt_busc_nombre.Text != "")
                {
                    //Se llama al método de ConsultasSQL que busca por nombre y identificación
                    //Se muestran los datos en el Data Grid View
                    dataGridView1.DataSource = sql.BuscarAmbos(cmb_Tabla.SelectedItem.ToString(), txt_busc_identificacion.Text, txt_busc_nombre.Text, proxy);
                }
                //En este caso se busca por identificación
                else if (txt_busc_identificacion.Text != "" && txt_busc_nombre.Text == "")
                {
                    //Se llama al método de ConsultasSQL que busca por identificación
                    //Se muestran los datos en el Data Grid View
                    dataGridView1.DataSource = sql.BuscarIdentificacion(cmb_Tabla.SelectedItem.ToString(), txt_busc_identificacion.Text, proxy);
                }
                //En este caso se busca por nombre
                else if (txt_busc_identificacion.Text == "" && txt_busc_nombre.Text != "")
                {
                    //Se llama al método de ConsultasSQL que busca por nombre
                    //Se muestran los datos en el Data Grid View
                    dataGridView1.DataSource = sql.BuscarNombre(cmb_Tabla.SelectedItem.ToString(), txt_busc_nombre.Text, proxy);
                }
                //Si solo se selecciona la tabla se llama al método de ConsultasSQL que cumple esa función.
                else dataGridView1.DataSource = sql.MostrarDatos(cmb_Tabla.SelectedItem.ToString(), proxy);
            }
            catch (Exception)
            {
                MessageBox.Show("Intente de nuevo");
            }
            
        }

        private void cmb_Tabla_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        //Inicia el método para cuando se hace click en una celda del Data Grid View
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Capta la fila donde se hace click
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            //Le inserta a la casilla Código el número de código de la persona seleccionada
            txt_busc_codigo.Text = Convert.ToString(fila.Cells[0].Value);
        }
    }
}
