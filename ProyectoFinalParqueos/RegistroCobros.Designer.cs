namespace ProyectoFinalParqueos
{
    partial class RegistroCobros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DetallesdataGridView1 = new System.Windows.Forms.DataGridView();
            this.CobroIdtextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.ClienteIdcomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.CobroDetalleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CobroId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ClienteId:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // DetallesdataGridView1
            // 
            this.DetallesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CobroDetalleId,
            this.ClienteId,
            this.Total});
            this.DetallesdataGridView1.Location = new System.Drawing.Point(9, 173);
            this.DetallesdataGridView1.Name = "DetallesdataGridView1";
            this.DetallesdataGridView1.Size = new System.Drawing.Size(470, 179);
            this.DetallesdataGridView1.TabIndex = 6;
            // 
            // CobroIdtextBox
            // 
            this.CobroIdtextBox.Location = new System.Drawing.Point(87, 12);
            this.CobroIdtextBox.Name = "CobroIdtextBox";
            this.CobroIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.CobroIdtextBox.TabIndex = 7;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(87, 76);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(100, 20);
            this.MontotextBox.TabIndex = 8;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(273, 131);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 9;
            // 
            // ClienteIdcomboBox
            // 
            this.ClienteIdcomboBox.FormattingEnabled = true;
            this.ClienteIdcomboBox.Location = new System.Drawing.Point(85, 131);
            this.ClienteIdcomboBox.Name = "ClienteIdcomboBox";
            this.ClienteIdcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ClienteIdcomboBox.TabIndex = 10;
            // 
            // FechadateTimePicker1
            // 
            this.FechadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker1.Location = new System.Drawing.Point(87, 44);
            this.FechadateTimePicker1.Name = "FechadateTimePicker1";
            this.FechadateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker1.TabIndex = 11;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(292, 379);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(198, 379);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(103, 379);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton.TabIndex = 12;
            this.Limpiarbutton.Text = "Nuevo";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(212, 9);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(394, 131);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 16;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // CobroDetalleId
            // 
            this.CobroDetalleId.HeaderText = "CobroDetalleId";
            this.CobroDetalleId.Name = "CobroDetalleId";
            // 
            // ClienteId
            // 
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // RegistroCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 445);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.FechadateTimePicker1);
            this.Controls.Add(this.ClienteIdcomboBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.CobroIdtextBox);
            this.Controls.Add(this.DetallesdataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Cobros";
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DetallesdataGridView1;
        private System.Windows.Forms.TextBox CobroIdtextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ComboBox ClienteIdcomboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CobroDetalleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}