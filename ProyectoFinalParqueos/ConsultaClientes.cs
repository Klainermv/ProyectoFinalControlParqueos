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
    public partial class ConsultaClientes : Form
    {
        private Clientes cliente = new Clientes();
        public ConsultaClientes()
        {
            InitializeComponent();
            ClientesdataGridView.DataSource = cliente.Listar("*","1=1","asc");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "ClienteId=" + BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "Nombres like '%" + BuscartextBox.Text + "%'"; 
            }
            if (BuscarcomboBox.SelectedIndex == 2)
            {
                filtroWhere = "Apellidos like '%" + BuscartextBox.Text + "%'"; 
            }
            ClientesdataGridView.DataSource = cliente.Listar("*", filtroWhere, " asc ");
        }
    }
}
