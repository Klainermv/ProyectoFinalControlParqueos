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
    public partial class RegistroContratos : Form
    {
        private Contratos contrato = new Contratos();
        public RegistroContratos()
        {
            InitializeComponent();
            Clientes cliente = new Clientes();
            ClientescomboBox.DataSource = cliente.Listar("ClienteId,Nombres+' '+Apellidos as NombreCompleto", "1=1", " asc");
            ClientescomboBox.DisplayMember = "NombreCompleto";
            ClientescomboBox.ValueMember = "ClienteId";

            Vehiculos vehiculo = new Vehiculos();
            VehiculoscomboBox.DataSource = vehiculo.Listar("*", "1=1", " asc");
            VehiculoscomboBox.DisplayMember = "Placa";
            VehiculoscomboBox.ValueMember = "VehiculoId";

            Parqueos parqueo = new Parqueos();
            ParqueoscomboBox.DataSource = parqueo.Listar("*", "1=1", " asc");
            ParqueoscomboBox.DisplayMember = "ParqueoId";
            ParqueoscomboBox.ValueMember = "ParqueoId";


        }

        private void Limpiar()
        {
            ContratoIdtextBox.Clear();
            TotaltextBox.Clear();
            ActivocheckBox1.Checked = false;
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ContratoIdtextBox.Text))
            {

                MessageBox.Show("Debes llenar el ContratoId.");

            }
            else
            {


                contrato.ContratoId = int.Parse(ContratoIdtextBox.Text);
                if (contrato.Eliminar())
                {
                    Limpiar();
                    MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (contrato.Buscar(int.Parse(ContratoIdtextBox.Text)))
            {
                
                FechaVencimientodateTimePicker1.Value = contrato.FechaVencimiento;
                TotaltextBox.Text = contrato.Total.ToString();
                ActivocheckBox1.Checked = contrato.Activo;
                ClientescomboBox.SelectedValue = contrato.ClienteId;
                VehiculoscomboBox.SelectedValue = contrato.VehiculoId;
                ParqueoscomboBox.SelectedValue = contrato.ParqueId;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientescomboBox.Text))
            {

                MessageBox.Show("Debes seleccionar un cliente.");

            }
            else if (string.IsNullOrEmpty(VehiculoscomboBox.Text))
            {

                MessageBox.Show("Debes seleccionar un vehiculo.");

            }
            else if (string.IsNullOrEmpty(ParqueoscomboBox.Text))
            {

                MessageBox.Show("Debes seleccionar un parqueo.");

            }
            else
            {



                contrato.ParqueId = int.Parse(ParqueoscomboBox.SelectedValue.ToString());
                contrato.ClienteId = int.Parse(ClientescomboBox.SelectedValue.ToString());
                contrato.VehiculoId = int.Parse(VehiculoscomboBox.SelectedValue.ToString());
                contrato.FechaVencimiento = FechaVencimientodateTimePicker1.Value;
                contrato.Total = float.Parse(TotaltextBox.Text);
                contrato.Balance = float.Parse(TotaltextBox.Text);
                contrato.Activo = ActivocheckBox1.Checked;

                int id;
                int.TryParse(ContratoIdtextBox.Text, out id);

                if (id == 0)
                {
                    if (contrato.Insertar())
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
                    if (contrato.Modificar(id))
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
