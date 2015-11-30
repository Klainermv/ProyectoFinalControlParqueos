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
    public partial class ConsultaModelos : Form
    {
        private Modelos modelo = new Modelos();
        public ConsultaModelos()
        {
            InitializeComponent();
            ModelosdataGridView.DataSource = modelo.Listar("*","1=1","asc");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "ModeloId=" + BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "Descripcion like '%" + BuscartextBox.Text + "%'";
            }

            ModelosdataGridView.DataSource = modelo.Listar("*", filtroWhere, " asc ");

        }
    }
}
