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
    public partial class RegistroModelos : Form
    {
        private Modelos modelo = new Modelos();
        public RegistroModelos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ModeloIdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModeloIdtextBox.Text))
            {

                MessageBox.Show("Debes llenar el ModeloId.");

            }
            else
            {
                modelo.ModeloId = int.Parse(ModeloIdtextBox.Text);
                if (modelo.Eliminar())
                {
                    Limpiar();
                    MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (modelo.Buscar(int.Parse(ModeloIdtextBox.Text)))
            {
                DescripciontextBox.Text = modelo.Descripcion;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {

                MessageBox.Show("Debes llenar la descripcion.");

            }
            else
            {
                modelo.Descripcion = DescripciontextBox.Text;

                int id;
                int.TryParse(ModeloIdtextBox.Text, out id);

                if (id == 0)
                {
                    if (modelo.Insertar())
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
                    if (modelo.Modificar(id))
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
}
