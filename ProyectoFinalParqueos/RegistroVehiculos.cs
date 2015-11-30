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
    public partial class RegistroVehiculos : Form
    {
        private Vehiculos vehiculo = new Vehiculos();
        public RegistroVehiculos()
        {
            InitializeComponent();
            Marcas marca = new Marcas();
            MarcascomboBox.DataSource = marca.Listar("*", "1=1", "asc");
            MarcascomboBox.DisplayMember = "Descripcion";
            MarcascomboBox.ValueMember = "MarcaId";
            Modelos modelo = new Modelos();
            ModeloscomboBox.DataSource = modelo.Listar("*", "1=1", "asc");
            ModeloscomboBox.DisplayMember = "Descripcion";
            ModeloscomboBox.ValueMember = "ModeloId";
            Clientes cliente = new Clientes();
            ClientescomboBox.DataSource = cliente.Listar("ClienteId,Nombres+' '+Apellidos as NombreCompleto", "1=1", "asc");
            ClientescomboBox.DisplayMember = "NombreCompleto";
            ClientescomboBox.ValueMember = "ClienteId";

        }

        private void Limpiar()
        {
            VehiculoIdtextBox.Clear();
            PlacatextBox.Clear();
            AnioFabricaciontextBox.Clear();
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(VehiculoIdtextBox.Text))
            {

                MessageBox.Show("Debes llenar el VehiculoId.");

            }
            else
            {
                try
                {



                    vehiculo.VehiculoId = int.Parse(VehiculoIdtextBox.Text);
                    if (vehiculo.Eliminar())
                    {
                        Limpiar();
                        MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (vehiculo.Buscar(int.Parse(VehiculoIdtextBox.Text)))
            {

                AnioFabricaciontextBox.Text = vehiculo.AnioFabricacion.ToString();
                PlacatextBox.Text = vehiculo.Placa;
                ClientescomboBox.SelectedValue = vehiculo.ClienteId;
                MarcascomboBox.SelectedValue = vehiculo.MarcaId;
                ModeloscomboBox.SelectedValue = vehiculo.ModeloId;

            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlacatextBox.Text))
            {

                MessageBox.Show("Debes llenar la placa.");

            }
            else if (string.IsNullOrEmpty(ClientescomboBox.Text))
            {

                MessageBox.Show("Debes seleccionar un cliente.");

            }

            else if (string.IsNullOrEmpty(ModeloscomboBox.Text))
            {

                MessageBox.Show("Debes seleccionar un modelo.");

            }
            else if (string.IsNullOrEmpty(MarcascomboBox.Text))
            {

                MessageBox.Show("Debes seleccionar una marca.");

            }
            else
            {



                vehiculo.Placa = PlacatextBox.Text;
                vehiculo.AnioFabricacion = Convert.ToInt32(AnioFabricaciontextBox.Text);
                vehiculo.ClienteId = int.Parse(ClientescomboBox.SelectedValue.ToString());
                vehiculo.MarcaId = int.Parse(MarcascomboBox.SelectedValue.ToString());
                vehiculo.ModeloId = int.Parse(ModeloscomboBox.SelectedValue.ToString());

                int id;
                int.TryParse(VehiculoIdtextBox.Text, out id);

                if (id == 0)
                {
                    if (vehiculo.Insertar())
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
                    if (vehiculo.Modificar(id))
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
