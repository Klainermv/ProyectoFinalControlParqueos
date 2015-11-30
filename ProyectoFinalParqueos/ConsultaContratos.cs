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
    public partial class ConsultaContratos : Form
    {
        private Contratos contrato = new Contratos();
        public ConsultaContratos()
        {
            InitializeComponent();
            ContratosdataGridView.DataSource = contrato.Listar("*","1=1","asc");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "ContratoId=" + BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "ClienteId = '" + BuscartextBox.Text + "'";
            }
            
            ContratosdataGridView.DataSource = contrato.Listar("*", filtroWhere, " asc ");
        }
    }
}
