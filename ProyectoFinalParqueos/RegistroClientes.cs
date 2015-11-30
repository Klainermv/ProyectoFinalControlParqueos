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
    public partial class RegistroClientes : Form
    {
        private Clientes clientes = new Clientes();
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ClienteIdtextBox.Clear();
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            CedulamaskedTextBox2.Clear();
            TelefonomaskedTextBox1.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {

                MessageBox.Show("Debes llenar el ClienteId.");

            }
            else
            {


                clientes.ClienteId = int.Parse(ClienteIdtextBox.Text);
                if (clientes.Eliminar())
                {
                    Limpiar();
                    MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            if (clientes.Buscar(int.Parse(ClienteIdtextBox.Text)))
            {

                NombrestextBox.Text = clientes.Nombres;
                ApellidostextBox.Text = clientes.Apellidos;
                CedulamaskedTextBox2.Text = clientes.Cedula;
                TelefonomaskedTextBox1.Text = clientes.Telefono;
                FechaIngresodateTimePicker.Value = clientes.FechaIngreso;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombrestextBox.Text))
            {

                MessageBox.Show("Debes llenar el/los nombre/s.");

            }
            else if (string.IsNullOrEmpty(ApellidostextBox.Text))
            {

                MessageBox.Show("Debes llenar los apellidos.");

            }
            else
            {



                clientes.Nombres = NombrestextBox.Text;
                clientes.Apellidos = ApellidostextBox.Text;
                clientes.Cedula = CedulamaskedTextBox2.Text;
                clientes.Telefono = TelefonomaskedTextBox1.Text;
                clientes.FechaIngreso = Convert.ToDateTime(FechaIngresodateTimePicker.Value);

                int id;
                int.TryParse(ClienteIdtextBox.Text, out id);

                if (id == 0)
                {

                    if (clientes.Insertar())
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


                    if (clientes.Modificar(id))
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
