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
    public partial class RegistroUsuarios : Form
    {
        private Usuarios usuario = new Usuarios();
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContraseniatextBox.Clear();
            ConfrimarContraseniatextBox.Clear();
            ActivocheckBox.Checked = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreUsuariotextBox.Text))
            {

                MessageBox.Show("Debes llenar el nombre de usuario.");

            }else
                if (string.IsNullOrEmpty(ContraseniatextBox.Text) || string.IsNullOrEmpty(ConfrimarContraseniatextBox.Text))
                {

                    MessageBox.Show("Debes llenar la contraseña.");   

                }
                else
                {



                    usuario.NombreUsuario = NombreUsuariotextBox.Text;
                    if (ActivocheckBox.Checked == true)
                    {
                        usuario.Activo = true;
                    }
                    else if (ActivocheckBox.Checked == false)
                    {
                        usuario.Activo = false;
                    }

                    if (ContraseniatextBox.Text == ConfrimarContraseniatextBox.Text)// si las contraseñas son iguales
                    {
                        usuario.Contrasenia = ContraseniatextBox.Text;

                        int id;
                        int.TryParse(UsuarioIdtextBox.Text, out id);

                        if (id == 0)
                        {


                            if (usuario.Insertar())
                            {
                                Limpiar();
                                MessageBox.Show("Guardado Correcto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            else
                            {
                                MessageBox.Show("A surgido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {

                            if (usuario.Modificar(id))
                            {
                                Limpiar();
                                MessageBox.Show("Modificado Correcto", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            else
                            {
                                MessageBox.Show("A surgido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioIdtextBox.Text))
            {

                MessageBox.Show("Debes llenar el UsuarioId.");

            }
            else
            {


                usuario.UsuarioId = int.Parse(UsuarioIdtextBox.Text);
                if (usuario.Eliminar())
                {
                    Limpiar();
                    MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
         
            if (usuario.Buscar(int.Parse(UsuarioIdtextBox.Text)))//arreglar
            {
               
                NombreUsuariotextBox.Text = usuario.NombreUsuario;
                ContraseniatextBox.Text = usuario.Contrasenia;
               
            }
        }

      
    }
}
