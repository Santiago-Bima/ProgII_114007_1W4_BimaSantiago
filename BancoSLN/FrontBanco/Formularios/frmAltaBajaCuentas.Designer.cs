namespace FrontBanco.Formularios
{
    partial class frmAltaBajaCuentas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 20;
            this.lstCuentas.Location = new System.Drawing.Point(12, 24);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(453, 444);
            this.lstCuentas.TabIndex = 0;
            this.lstCuentas.SelectedIndexChanged += new System.EventHandler(this.lstCuentas_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(553, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 49);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.frmCancelar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Location = new System.Drawing.Point(483, 137);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(130, 49);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaja.Location = new System.Drawing.Point(619, 137);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(130, 49);
            this.btnBaja.TabIndex = 5;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // txtCbu
            // 
            this.txtCbu.Enabled = false;
            this.txtCbu.Location = new System.Drawing.Point(541, 90);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(201, 26);
            this.txtCbu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CBU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAltaBajaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCbu);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstCuentas);
            this.Name = "frmAltaBajaCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmAltaBaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label label1;
    }
}
