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
        public bool estado;
        private Principal principal;

        public IniciarSesion(Boolean estado, Principal principal)
        {
            InitializeComponent();
            this.estado = estado;
            this.principal = principal;
        
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            if (usuario.IniciarSesion(NombreUsuariotextBox.Text, ContraseniatextBox.Text) == false)
            {
                MessageBox.Show("Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estado = false;
            }
            else if (usuario.IniciarSesion(NombreUsuariotextBox.Text, ContraseniatextBox.Text) == true)
            {
                estado = true;
                this.principal.registrosToolStripMenuItem.Enabled = estado;
                this.principal.consultasToolStripMenuItem.Enabled = estado;
                this.principal.logOutToolStripMenuItem.Enabled = estado;
                this.principal.IniciarSesionToolStripMenuItem.Enabled = !estado;
                this.principal.reportesToolStripMenuItem.Enabled = estado;
                this.Close();

            }
            
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
    }
}
