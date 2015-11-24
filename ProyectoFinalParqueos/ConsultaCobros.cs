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
    public partial class ConsultaCobros : Form
    {
        private Cobros cobros = new Cobros();
        public ConsultaCobros()
        {
            InitializeComponent();
            CobrosdataGridView.DataSource = cobros.Listar("*","1=1","asc");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "CobroId=" + BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "Monto= '" + BuscartextBox.Text + "'";
            }
            
            CobrosdataGridView.DataSource = cobros.Listar("*", filtroWhere, " asc ");
        }
    }
}
