namespace banco.Presentacion
{
    partial class frmAltaBajaTransacciones
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
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.lstTransacciones = new System.Windows.Forms.ListBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 20;
            this.lstCuentas.Location = new System.Drawing.Point(12, 12);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(382, 604);
            this.lstCuentas.TabIndex = 1;
            this.lstCuentas.SelectedIndexChanged += new System.EventHandler(this.lstCuentas_SelectedIndexChanged);
            // 
            // lstTransacciones
            // 
            this.lstTransacciones.FormattingEnabled = true;
            this.lstTransacciones.ItemHeight = 20;
            this.lstTransacciones.Location = new System.Drawing.Point(400, 12);
            this.lstTransacciones.Name = "lstTransacciones";
            this.lstTransacciones.Size = new System.Drawing.Size(569, 344);
            this.lstTransacciones.TabIndex = 2;
            this.lstTransacciones.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaja.Location = new System.Drawing.Point(823, 436);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(130, 49);
            this.btnBaja.TabIndex = 12;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click_1);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Location = new System.Drawing.Point(823, 369);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(130, 49);
            this.btnAlta.TabIndex = 11;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(823, 550);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 49);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "CBU";
            // 
            // txtCbu
            // 
            this.txtCbu.Enabled = false;
            this.txtCbu.Location = new System.Drawing.Point(473, 380);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(204, 26);
            this.txtCbu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nro Transacción";
            // 
            // txtNroT
            // 
            this.txtNroT.Enabled = false;
            this.txtNroT.Location = new System.Drawing.Point(581, 431);
            this.txtNroT.Name = "txtNroT";
            this.txtNroT.Size = new System.Drawing.Size(209, 26);
            this.txtNroT.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(581, 474);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(209, 26);
            this.txtMonto.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(581, 517);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(209, 26);
            this.txtFecha.TabIndex = 19;
            // 
            // frmAltaBajaTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 636);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCbu);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstTransacciones);
            this.Controls.Add(this.lstCuentas);
            this.Name = "frmAltaBajaTransacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.frmAltaBajaTransacciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.ListBox lstTransacciones;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
    }
}