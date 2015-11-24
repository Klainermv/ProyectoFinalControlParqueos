namespace ProyectoFinalParqueos
{
    partial class VisorReportes
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
            this.VisorcrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorcrystalReportViewer1
            // 
            this.VisorcrystalReportViewer1.ActiveViewIndex = -1;
            this.VisorcrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorcrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorcrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorcrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.VisorcrystalReportViewer1.Name = "VisorcrystalReportViewer1";
            this.VisorcrystalReportViewer1.Size = new System.Drawing.Size(493, 334);
            this.VisorcrystalReportViewer1.TabIndex = 0;
            // 
            // VisorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 334);
            this.Controls.Add(this.VisorcrystalReportViewer1);
            this.Name = "VisorReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorcrystalReportViewer1;
    }
}