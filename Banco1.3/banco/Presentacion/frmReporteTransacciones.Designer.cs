namespace banco.Presentacion
{
    partial class frmReporteTransacciones
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
            this.components = new System.ComponentModel.Container();
            this.cboCuentas = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dSTransacciones = new banco.Presentacion.Reportes.DSTransacciones();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCuentas
            // 
            this.cboCuentas.FormattingEnabled = true;
            this.cboCuentas.Location = new System.Drawing.Point(132, 29);
            this.cboCuentas.Name = "cboCuentas";
            this.cboCuentas.Size = new System.Drawing.Size(359, 28);
            this.cboCuentas.TabIndex = 1;
            this.cboCuentas.SelectedIndexChanged += new System.EventHandler(this.cboCuentas_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Location = new System.Drawing.Point(550, 17);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(146, 50);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dSTransacciones
            // 
            this.dSTransacciones.DataSetName = "DSTransacciones";
            this.dSTransacciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSTransacciones;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banco.Presentacion.Reportes.ReporteTransacciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 544);
            this.reportViewer1.TabIndex = 3;
            // 
            // frmReporteTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboCuentas);
            this.Name = "frmReporteTransacciones";
            this.Text = "Reporte de Transacciones";
            this.Load += new System.EventHandler(this.frmReporteTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCuentas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Reportes.DSTransacciones dSTransacciones;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}