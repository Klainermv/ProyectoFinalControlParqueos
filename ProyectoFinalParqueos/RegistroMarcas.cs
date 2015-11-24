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
    public partial class RegistroMarcas : Form
    {
        private Marcas marca = new Marcas();
        public RegistroMarcas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MarcaIdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            marca.MarcaId = int.Parse(MarcaIdtextBox.Text);
            if (marca.Eliminar())
            {
                Limpiar();
                MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (marca.Buscar(int.Parse(MarcaIdtextBox.Text)))
            {
                DescripciontextBox.Text = marca.Descripcion;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            marca.Descripcion = DescripciontextBox.Text;

            int id;
            int.TryParse(MarcaIdtextBox.Text,out id);

            if (id == 0)
            {
                if (marca.Insertar())
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
                if (marca.Modificar(id))
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
    }
}
