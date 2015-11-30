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
    public partial class ConsultaVehiculos : Form
    {
        private Vehiculos vehiculo = new Vehiculos();
        public ConsultaVehiculos()
        {
            InitializeComponent();
            VehiculosdataGridView.DataSource = vehiculo.Listar("*","1=1","asc");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "VehiculoId=" + BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "Placa= '" + BuscartextBox.Text + "'";
            }
            
            VehiculosdataGridView.DataSource = vehiculo.Listar("*", filtroWhere, " asc ");

        }
    }
}
