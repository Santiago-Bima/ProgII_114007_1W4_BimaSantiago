namespace banco.Presentacion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaAltaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnReporteCuentas = new System.Windows.Forms.Button();
            this.btnRepClientes = new System.Windows.Forms.Button();
            this.btnRepoCuentas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1827, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.darDeBajaAltaToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // darDeBajaAltaToolStripMenuItem
            // 
            this.darDeBajaAltaToolStripMenuItem.Name = "darDeBajaAltaToolStripMenuItem";
            this.darDeBajaAltaToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.darDeBajaAltaToolStripMenuItem.Text = "Dar de Baja/Alta";
            this.darDeBajaAltaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaAltaToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem1,
            this.darDeBajaAltaToolStripMenuItem1});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // nuevaToolStripMenuItem1
            // 
            this.nuevaToolStripMenuItem1.Name = "nuevaToolStripMenuItem1";
            this.nuevaToolStripMenuItem1.Size = new System.Drawing.Size(242, 34);
            this.nuevaToolStripMenuItem1.Text = "Nueva";
            this.nuevaToolStripMenuItem1.Click += new System.EventHandler(this.nuevaToolStripMenuItem1_Click);
            // 
            // darDeBajaAltaToolStripMenuItem1
            // 
            this.darDeBajaAltaToolStripMenuItem1.Name = "darDeBajaAltaToolStripMenuItem1";
            this.darDeBajaAltaToolStripMenuItem1.Size = new System.Drawing.Size(242, 34);
            this.darDeBajaAltaToolStripMenuItem1.Text = "Dar de Baja/Alta";
            this.darDeBajaAltaToolStripMenuItem1.Click += new System.EventHandler(this.darDeBajaAltaToolStripMenuItem1_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(22, 47);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(272, 904);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(301, 47);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersWidth = 62;
            this.dgvCuentas.RowTemplate.Height = 28;
            this.dgvCuentas.Size = new System.Drawing.Size(999, 352);
            this.dgvCuentas.TabIndex = 2;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Location = new System.Drawing.Point(301, 405);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.RowHeadersWidth = 62;
            this.dgvTransacciones.RowTemplate.Height = 28;
            this.dgvTransacciones.Size = new System.Drawing.Size(546, 330);
            this.dgvTransacciones.TabIndex = 3;
            this.dgvTransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransacciones_CellContentClick);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(300, 741);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersWidth = 62;
            this.dgvMovimientos.RowTemplate.Height = 28;
            this.dgvMovimientos.Size = new System.Drawing.Size(397, 210);
            this.dgvMovimientos.TabIndex = 4;
            this.dgvMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(1371, 188);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(132, 49);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnReporteCuentas
            // 
            this.btnReporteCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnReporteCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteCuentas.Location = new System.Drawing.Point(916, 637);
            this.btnReporteCuentas.Name = "btnReporteCuentas";
            this.btnReporteCuentas.Size = new System.Drawing.Size(251, 98);
            this.btnReporteCuentas.TabIndex = 6;
            this.btnReporteCuentas.Text = "Generar Reporte de las transacciones";
            this.btnReporteCuentas.UseVisualStyleBackColor = false;
            this.btnReporteCuentas.Click += new System.EventHandler(this.btnReporteCuentas_Click);
            // 
            // btnRepClientes
            // 
            this.btnRepClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRepClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepClientes.Location = new System.Drawing.Point(916, 427);
            this.btnRepClientes.Name = "btnRepClientes";
            this.btnRepClientes.Size = new System.Drawing.Size(251, 98);
            this.btnRepClientes.TabIndex = 7;
            this.btnRepClientes.Text = "Generar Reporte de los clientes";
            this.btnRepClientes.UseVisualStyleBackColor = false;
            this.btnRepClientes.Click += new System.EventHandler(this.btnRepClientes_Click);
            // 
            // btnRepoCuentas
            // 
            this.btnRepoCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRepoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepoCuentas.Location = new System.Drawing.Point(916, 531);
            this.btnRepoCuentas.Name = "btnRepoCuentas";
            this.btnRepoCuentas.Size = new System.Drawing.Size(251, 98);
            this.btnRepoCuentas.TabIndex = 8;
            this.btnRepoCuentas.Text = "Generar Reporte de las cuentas con transacciones";
            this.btnRepoCuentas.UseVisualStyleBackColor = false;
            this.btnRepoCuentas.Click += new System.EventHandler(this.btnRepoCuentas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1827, 1050);
            this.Controls.Add(this.btnRepoCuentas);
            this.Controls.Add(this.btnRepClientes);
            this.Controls.Add(this.btnReporteCuentas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.dgvTransacciones);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaAltaToolStripMenuItem;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaAltaToolStripMenuItem1;
        private System.Windows.Forms.Button btnReporteCuentas;
        private System.Windows.Forms.Button btnRepClientes;
        private System.Windows.Forms.Button btnRepoCuentas;
    }
}