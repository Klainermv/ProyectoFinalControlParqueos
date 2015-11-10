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
    public partial class ConsultaUsuarios : Form
    {
        private Usuarios usuario = new Usuarios(); 
        public ConsultaUsuarios()
        {
            InitializeComponent();
            UsuariosdataGridView.DataSource = usuario.Listar("*","1=1"); //este lo uso para llamar todo cuando corre la ventana
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";
            
            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "UsuarioId="+BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "NombreUsuario like '%" + BuscartextBox.Text+"%'"; // para buscar tod de un mismo nommbre
            }
            UsuariosdataGridView.DataSource = usuario.Listar("*", filtroWhere);
        }
    }
}
