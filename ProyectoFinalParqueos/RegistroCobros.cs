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
    public partial class RegistroCobros : Form
    {
        private Cobros cobro = new Cobros();
        public RegistroCobros()
        {
            InitializeComponent();

            Clientes cliente = new Clientes();
            ClienteIdcomboBox.DataSource = cliente.Listar("ClienteId, Nombres+' '+Apellidos as NombreCompleto", "1=1", "asc");
            ClienteIdcomboBox.DisplayMember = "NombreCompleto";
            ClienteIdcomboBox.ValueMember = "ClienteId";
        }

        private void Limpiar()
        {
            CobroIdtextBox.Clear();
            MontotextBox.Clear();
            TotaltextBox.Clear();
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            cobro.CobroId = int.Parse(CobroIdtextBox.Text);
            if (cobro.Eliminar())
            {
                Limpiar();
                MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (cobro.Buscar(int.Parse(CobroIdtextBox.Text)))
            {
                MontotextBox.Text = cobro.Monto.ToString();
                FechadateTimePicker1.Value = cobro.Fecha;
              
            }
        }

       

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            cobro.Fecha = FechadateTimePicker1.Value;
            cobro.Monto = float.Parse(MontotextBox.Text);
            
            string ClienteId;
            string Total;
            int id;
            int.TryParse(CobroIdtextBox.Text, out id);

            if (id == 0)
            {
                try
                {


                    if (cobro.Insertar())
                    {
                        cobro.MaximoCobroId();
                        CobroIdtextBox.Text = cobro.CobroId.ToString();
                        foreach (DataGridViewRow row in DetallesdataGridView1.Rows)
                        {
                            ClienteId = row.Cells[1].Value.ToString();
                            Total = row.Cells[2].Value.ToString();

                            cobro.ClienteId = int.Parse(ClienteId);
                            cobro.Total = float.Parse(Total);

                            cobro.CobroId = int.Parse(CobroIdtextBox.Text);

                            cobro.InsertarDetalle();


                        }
                        Limpiar();
                        MessageBox.Show("Guardado Correcto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("A surgido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                }
               
            }
            else
            {
                cobro.ClienteId = int.Parse(ClienteIdcomboBox.Text);
                cobro.EliminarDetalle();

                if (cobro.Modificar(id))
                {
                    cobro.InsertarDetalle();   
                    Limpiar();
                    MessageBox.Show("Modificado Correcto", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    MessageBox.Show("A surgido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            
            DetallesdataGridView1.Rows.Add(0,ClienteIdcomboBox.SelectedValue, TotaltextBox.Text);
            int suma = 0;

 

                    foreach (DataGridViewRow row in DetallesdataGridView1.Rows)

                    {

                        suma += Convert.ToInt32(row.Cells[2].Value);  //aqui recorre las celdas y las va sumando

                    }

                    MontotextBox.Text = Convert.ToString(suma);   //aqui se graba el total

                
             
        }

       

        
    }
}
