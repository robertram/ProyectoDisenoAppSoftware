using Proyecto_Final.Otras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón que permite entrar al sistema 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contrasena = txtContraseña.Text;
            MetodosLogin metodosLogin = new MetodosLogin();
            if(metodosLogin.RevisarLogin(usuario, contrasena))
            {
                AlimentandoEsperanzas alim = new AlimentandoEsperanzas();
                alim.Show();
            }
        }
    }
}
