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
    public partial class ConsultaParqueos : Form
    {
        private Parqueos parqueo = new Parqueos();
        public ConsultaParqueos()
        {
            InitializeComponent();
            ParqueosdataGridView.DataSource = parqueo.Listar("*","1=1","asc");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "ParqueoId=" + BuscartextBox.Text;
            }
            

            ParqueosdataGridView.DataSource = parqueo.Listar("*", filtroWhere, " asc ");
        }
    }
}
