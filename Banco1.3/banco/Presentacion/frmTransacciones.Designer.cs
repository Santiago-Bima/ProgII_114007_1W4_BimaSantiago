namespace banco.Presentacion
{
    partial class frmTransacciones
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
            this.label4 = new System.Windows.Forms.Label();
            this.cboCuentas = new System.Windows.Forms.ComboBox();
            this.lblNroTransaccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.colCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cbu";
            // 
            // cboCuentas
            // 
            this.cboCuentas.FormattingEnabled = true;
            this.cboCuentas.Location = new System.Drawing.Point(160, 118);
            this.cboCuentas.Name = "cboCuentas";
            this.cboCuentas.Size = new System.Drawing.Size(211, 28);
            this.cboCuentas.TabIndex = 2;
            this.cboCuentas.SelectedIndexChanged += new System.EventHandler(this.cboCuentas_SelectedIndexChanged);
            // 
            // lblNroTransaccion
            // 
            this.lblNroTransaccion.AutoSize = true;
            this.lblNroTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTransaccion.Location = new System.Drawing.Point(49, 43);
            this.lblNroTransaccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTransaccion.Name = "lblNroTransaccion";
            this.lblNroTransaccion.Size = new System.Drawing.Size(198, 29);
            this.lblNroTransaccion.TabIndex = 11;
            this.lblNroTransaccion.Text = "Transacción Nº:";
            this.lblNroTransaccion.Click += new System.EventHandler(this.lblNroPresupuesto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Monto a abonar";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(198, 158);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.MaxLength = 10;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(173, 26);
            this.txtMonto.TabIndex = 3;
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AllowUserToAddRows = false;
            this.dgvTransacciones.AllowUserToDeleteRows = false;
            this.dgvTransacciones.AllowUserToResizeColumns = false;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCbu,
            this.colMonto,
            this.colTipo,
            this.colEliminar});
            this.dgvTransacciones.Location = new System.Drawing.Point(54, 253);
            this.dgvTransacciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.RowHeadersWidth = 62;
            this.dgvTransacciones.Size = new System.Drawing.Size(509, 256);
            this.dgvTransacciones.TabIndex = 7;
            this.dgvTransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // colCbu
            // 
            this.colCbu.HeaderText = "Cbu";
            this.colCbu.MinimumWidth = 8;
            this.colCbu.Name = "colCbu";
            this.colCbu.ReadOnly = true;
            this.colCbu.Visible = false;
            this.colCbu.Width = 10;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.MinimumWidth = 8;
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            this.colMonto.Width = 85;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Accion";
            this.colTipo.MinimumWidth = 8;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 70;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 8;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 120;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(378, 193);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(150, 86);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.MaxLength = 10;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(221, 26);
            this.txtFecha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 543);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = " Total $";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(369, 543);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(172, 26);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(131, 598);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(172, 35);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(344, 598);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(165, 197);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(206, 28);
            this.cboTipos.TabIndex = 4;
            // 
            // frmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 651);
            this.Controls.Add(this.cboTipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTransacciones);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNroTransaccion);
            this.Controls.Add(this.cboCuentas);
            this.Controls.Add(this.label4);
            this.Name = "frmTransacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transacción";
            this.Load += new System.EventHandler(this.frmTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCuentas;
        private System.Windows.Forms.Label lblNroTransaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}