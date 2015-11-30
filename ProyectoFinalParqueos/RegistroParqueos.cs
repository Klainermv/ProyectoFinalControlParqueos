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
    public partial class RegistroParqueos : Form
    {
        Parqueos parqueo = new Parqueos();
        public RegistroParqueos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ParqueoIdtextBox.Clear();
            DisponiblecheckBox.Checked = false;
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ParqueoIdtextBox.Text))
            {

                MessageBox.Show("Debes llenar el ParqueoId.");

            }
            else
            {


                parqueo.ParqueoId = int.Parse(ParqueoIdtextBox.Text);
                if (parqueo.Eliminar())
                {
                    Limpiar();
                    MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (parqueo.Buscar(int.Parse(ParqueoIdtextBox.Text)))
            {
                DisponiblecheckBox.Checked = parqueo.Disponible;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            parqueo.Disponible = DisponiblecheckBox.Checked;
            int id;
            int.TryParse(ParqueoIdtextBox.Text, out id);

            if (id == 0)
            {
                if (parqueo.Insertar())
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
                if (parqueo.Modificar(id))
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
