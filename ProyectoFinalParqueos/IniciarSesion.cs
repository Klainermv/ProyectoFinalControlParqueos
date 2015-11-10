using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace ProyectoFinalParqueos
{
    public partial class IniciarSesion : Form
    {
        private Usuarios usuario = new Usuarios();
      
        public IniciarSesion()
        {
            InitializeComponent();
        
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            if (usuario.IniciarSesion(NombreUsuariotextBox.Text, ContraseniatextBox.Text) == false)
            {
                MessageBox.Show("Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.IniciarSesion(NombreUsuariotextBox.Text, ContraseniatextBox.Text) == true)
            {
                Principal p = new Principal();
                p.login(true);
                this.Close();

            }
            
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
    }
}
