using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalParqueos
{
    public partial class Principal : Form
    {
        public bool estado;

        public Principal()
        {
            InitializeComponent();
            estado = false;
            registrosToolStripMenuItem.Enabled = estado;
            consultasToolStripMenuItem.Enabled = estado;
            logOutToolStripMenuItem.Enabled = estado;
            IniciarSesionToolStripMenuItem.Enabled = !estado;
            reportesToolStripMenuItem.Enabled = estado;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios usuario = new RegistroUsuarios();
            usuario.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios usuario = new ConsultaUsuarios();
            usuario.Show();
        }

        private void IniciarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            IniciarSesion iniciar = new IniciarSesion(estado,this);
            iniciar.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = false;
            registrosToolStripMenuItem.Enabled = estado;
            consultasToolStripMenuItem.Enabled = estado;
            logOutToolStripMenuItem.Enabled = estado;
            IniciarSesionToolStripMenuItem.Enabled = !estado;
            reportesToolStripMenuItem.Enabled = estado;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes clientes = new RegistroClientes();
            clientes.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVehiculos vehiculos = new RegistroVehiculos();
            vehiculos.Show();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroModelos modelos = new RegistroModelos();
            modelos.Show();

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMarcas marcas = new RegistroMarcas();
            marcas.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroContratos contratos = new RegistroContratos();
            contratos.Show();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCobros cobros = new RegistroCobros();
            cobros.Show();
        }

        private void parqueosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroParqueos parqueos = new RegistroParqueos();
            parqueos.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes clientes = new ConsultaClientes();
            clientes.Show();
        }

        private void modelosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteModelos rm = new Reportes.ReporteModelos();
            vr.VisorcrystalReportViewer1.ReportSource = rm;
            vr.Show();
        }

        private void marcasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteMarcas rm = new Reportes.ReporteMarcas();
            vr.VisorcrystalReportViewer1.ReportSource = rm;
            vr.Show();
        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaVehiculos vehiculos = new ConsultaVehiculos();
            vehiculos.Show();
        }

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaContratos contratos = new ConsultaContratos();
            contratos.Show();
        }

        private void cobrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCobros cobros = new ConsultaCobros();
            cobros.Show();
        }

        private void modelosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaModelos modelos = new ConsultaModelos();
            modelos.Show();
        }

        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaMarcas marcas = new ConsultaMarcas();
            marcas.Show();
        }

        private void parqueosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaParqueos parqueo = new ConsultaParqueos();
            parqueo.Show();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteUsuario ru = new Reportes.ReporteUsuario();
            vr.VisorcrystalReportViewer1.ReportSource = ru;
            vr.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteClientes rc = new Reportes.ReporteClientes();
            vr.VisorcrystalReportViewer1.ReportSource = rc;
            vr.Show();
        }

        private void vehiculosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReportVehiculos rv = new Reportes.ReportVehiculos();
            vr.VisorcrystalReportViewer1.ReportSource = rv;
            vr.Show();
        }

        private void parqueosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteParqueos rp = new Reportes.ReporteParqueos();
            vr.VisorcrystalReportViewer1.ReportSource = rp;
            vr.Show();
        }

        private void contratosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteContratos rc = new Reportes.ReporteContratos();
            vr.VisorcrystalReportViewer1.ReportSource = rc;
            vr.Show();
        }

        private void cobrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisorReportes vr = new VisorReportes();
            Reportes.ReporteCobros rc = new Reportes.ReporteCobros();
            vr.VisorcrystalReportViewer1.ReportSource = rc;
            vr.Show();
        }

    }
}
