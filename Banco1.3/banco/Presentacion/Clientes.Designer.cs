namespace banco.Presentacion
{
    partial class frmClientes
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
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.btnCancelarClientes = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnGrabarClientes = new System.Windows.Forms.Button();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.btnNuevoClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarClientes.Location = new System.Drawing.Point(198, 266);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(148, 43);
            this.btnEditarClientes.TabIndex = 18;
            this.btnEditarClientes.Text = "Editar";
            this.btnEditarClientes.UseVisualStyleBackColor = false;
            this.btnEditarClientes.Click += new System.EventHandler(this.btnEditarClientes_Click_1);
            // 
            // btnCancelarClientes
            // 
            this.btnCancelarClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarClientes.Location = new System.Drawing.Point(30, 393);
            this.btnCancelarClientes.Name = "btnCancelarClientes";
            this.btnCancelarClientes.Size = new System.Drawing.Size(148, 43);
            this.btnCancelarClientes.TabIndex = 20;
            this.btnCancelarClientes.Text = "Cancelar";
            this.btnCancelarClientes.UseVisualStyleBackColor = false;
            this.btnCancelarClientes.Click += new System.EventHandler(this.btnCancelarClientes_Click);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(154, 179);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(179, 26);
            this.txtDniCliente.TabIndex = 15;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(154, 111);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(179, 26);
            this.txtApellidoCliente.TabIndex = 14;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(154, 54);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(179, 26);
            this.txtNombreCliente.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(415, 24);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(402, 404);
            this.lstClientes.TabIndex = 21;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarClientes.Location = new System.Drawing.Point(198, 331);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(148, 43);
            this.btnEliminarClientes.TabIndex = 19;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            this.btnEliminarClientes.Click += new System.EventHandler(this.btnEliminarClientes_Click_1);
            // 
            // btnGrabarClientes
            // 
            this.btnGrabarClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGrabarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabarClientes.Location = new System.Drawing.Point(30, 331);
            this.btnGrabarClientes.Name = "btnGrabarClientes";
            this.btnGrabarClientes.Size = new System.Drawing.Size(148, 43);
            this.btnGrabarClientes.TabIndex = 17;
            this.btnGrabarClientes.Text = "Grabar";
            this.btnGrabarClientes.UseVisualStyleBackColor = false;
            this.btnGrabarClientes.Click += new System.EventHandler(this.btnGrabarClientes_Click_1);
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSalirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirClientes.Location = new System.Drawing.Point(198, 393);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(155, 43);
            this.btnSalirClientes.TabIndex = 22;
            this.btnSalirClientes.Text = "Salir";
            this.btnSalirClientes.UseVisualStyleBackColor = false;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click_1);
            // 
            // btnNuevoClientes
            // 
            this.btnNuevoClientes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnNuevoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoClientes.Location = new System.Drawing.Point(30, 266);
            this.btnNuevoClientes.Name = "btnNuevoClientes";
            this.btnNuevoClientes.Size = new System.Drawing.Size(148, 43);
            this.btnNuevoClientes.TabIndex = 16;
            this.btnNuevoClientes.Text = "Nuevo";
            this.btnNuevoClientes.UseVisualStyleBackColor = false;
            this.btnNuevoClientes.Click += new System.EventHandler(this.btnNuevoClientes_Click_1);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 447);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.btnCancelarClientes);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnGrabarClientes);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnNuevoClientes);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnCancelarClientes;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnGrabarClientes;
        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.Button btnNuevoClientes;
    }
}