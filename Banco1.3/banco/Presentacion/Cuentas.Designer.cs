namespace banco
{
    partial class frmCuentas
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditarCuentas = new System.Windows.Forms.Button();
            this.btnCancelarCuentas = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridCuentas = new System.Windows.Forms.DataGridView();
            this.btnSalirCuentas = new System.Windows.Forms.Button();
            this.btnEliminarCuentas = new System.Windows.Forms.Button();
            this.btnGrabarCuentas = new System.Windows.Forms.Button();
            this.btnNuevoCuentas = new System.Windows.Forms.Button();
            this.txtCbu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnEditarCuentas
            // 
            this.btnEditarCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEditarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCuentas.Location = new System.Drawing.Point(166, 220);
            this.btnEditarCuentas.Name = "btnEditarCuentas";
            this.btnEditarCuentas.Size = new System.Drawing.Size(148, 43);
            this.btnEditarCuentas.TabIndex = 23;
            this.btnEditarCuentas.Text = "Editar";
            this.btnEditarCuentas.UseVisualStyleBackColor = false;
            this.btnEditarCuentas.Click += new System.EventHandler(this.btnEditarCuentas_Click_1);
            // 
            // btnCancelarCuentas
            // 
            this.btnCancelarCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarCuentas.Location = new System.Drawing.Point(12, 319);
            this.btnCancelarCuentas.Name = "btnCancelarCuentas";
            this.btnCancelarCuentas.Size = new System.Drawing.Size(148, 48);
            this.btnCancelarCuentas.TabIndex = 26;
            this.btnCancelarCuentas.Text = "Cancelar";
            this.btnCancelarCuentas.UseVisualStyleBackColor = false;
            this.btnCancelarCuentas.Click += new System.EventHandler(this.btnCancelarCuentas_Click_1);
            // 
            // cboCliente
            // 
            this.cboCliente.BackColor = System.Drawing.Color.White;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(153, 152);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(165, 28);
            this.cboCliente.TabIndex = 20;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(153, 106);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(165, 28);
            this.cboTipoCuenta.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Dni de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tipo Cuenta";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cbu";
            // 
            // dataGridCuentas
            // 
            this.dataGridCuentas.AllowUserToAddRows = false;
            this.dataGridCuentas.AllowUserToDeleteRows = false;
            this.dataGridCuentas.AllowUserToOrderColumns = true;
            this.dataGridCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCuentas.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridCuentas.Location = new System.Drawing.Point(342, 42);
            this.dataGridCuentas.Name = "dataGridCuentas";
            this.dataGridCuentas.ReadOnly = true;
            this.dataGridCuentas.RowHeadersVisible = false;
            this.dataGridCuentas.RowHeadersWidth = 62;
            this.dataGridCuentas.RowTemplate.Height = 28;
            this.dataGridCuentas.Size = new System.Drawing.Size(604, 325);
            this.dataGridCuentas.TabIndex = 27;
            this.dataGridCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCuentas_CellContentClick_1);
            // 
            // btnSalirCuentas
            // 
            this.btnSalirCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSalirCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirCuentas.Location = new System.Drawing.Point(166, 319);
            this.btnSalirCuentas.Name = "btnSalirCuentas";
            this.btnSalirCuentas.Size = new System.Drawing.Size(148, 48);
            this.btnSalirCuentas.TabIndex = 28;
            this.btnSalirCuentas.Text = "Salir";
            this.btnSalirCuentas.UseVisualStyleBackColor = false;
            this.btnSalirCuentas.Click += new System.EventHandler(this.btnSalirCuentas_Click_1);
            // 
            // btnEliminarCuentas
            // 
            this.btnEliminarCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEliminarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCuentas.Location = new System.Drawing.Point(166, 270);
            this.btnEliminarCuentas.Name = "btnEliminarCuentas";
            this.btnEliminarCuentas.Size = new System.Drawing.Size(148, 43);
            this.btnEliminarCuentas.TabIndex = 25;
            this.btnEliminarCuentas.Text = "Eliminar";
            this.btnEliminarCuentas.UseVisualStyleBackColor = false;
            this.btnEliminarCuentas.Click += new System.EventHandler(this.btnEliminarCuentas_Click_1);
            // 
            // btnGrabarCuentas
            // 
            this.btnGrabarCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGrabarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabarCuentas.Location = new System.Drawing.Point(12, 270);
            this.btnGrabarCuentas.Name = "btnGrabarCuentas";
            this.btnGrabarCuentas.Size = new System.Drawing.Size(148, 43);
            this.btnGrabarCuentas.TabIndex = 24;
            this.btnGrabarCuentas.Text = "Grabar";
            this.btnGrabarCuentas.UseVisualStyleBackColor = false;
            this.btnGrabarCuentas.Click += new System.EventHandler(this.btnGrabarCuentas_Click_1);
            // 
            // btnNuevoCuentas
            // 
            this.btnNuevoCuentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnNuevoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoCuentas.Location = new System.Drawing.Point(12, 220);
            this.btnNuevoCuentas.Name = "btnNuevoCuentas";
            this.btnNuevoCuentas.Size = new System.Drawing.Size(148, 43);
            this.btnNuevoCuentas.TabIndex = 22;
            this.btnNuevoCuentas.Text = "Nuevo";
            this.btnNuevoCuentas.UseVisualStyleBackColor = false;
            this.btnNuevoCuentas.Click += new System.EventHandler(this.btnNuevoCuentas_Click_1);
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(153, 61);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(165, 26);
            this.txtCbu.TabIndex = 17;
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 383);
            this.Controls.Add(this.btnEditarCuentas);
            this.Controls.Add(this.btnCancelarCuentas);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridCuentas);
            this.Controls.Add(this.btnSalirCuentas);
            this.Controls.Add(this.btnEliminarCuentas);
            this.Controls.Add(this.btnGrabarCuentas);
            this.Controls.Add(this.btnNuevoCuentas);
            this.Controls.Add(this.txtCbu);
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.Banco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnEditarCuentas;
        private System.Windows.Forms.Button btnCancelarCuentas;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridCuentas;
        private System.Windows.Forms.Button btnSalirCuentas;
        private System.Windows.Forms.Button btnEliminarCuentas;
        private System.Windows.Forms.Button btnGrabarCuentas;
        private System.Windows.Forms.Button btnNuevoCuentas;
        private System.Windows.Forms.TextBox txtCbu;
    }
}

