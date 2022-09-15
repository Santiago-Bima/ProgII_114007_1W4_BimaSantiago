namespace PilasYColas
{
    partial class frmPilas
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnVacio = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(73, 37);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(242, 26);
            this.txtElemento.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(347, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 41);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 20;
            this.lstElementos.Location = new System.Drawing.Point(73, 79);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(416, 384);
            this.lstElementos.TabIndex = 5;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(347, 491);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(82, 41);
            this.btnExtraer.TabIndex = 4;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnVacio
            // 
            this.btnVacio.Location = new System.Drawing.Point(225, 491);
            this.btnVacio.Name = "btnVacio";
            this.btnVacio.Size = new System.Drawing.Size(82, 41);
            this.btnVacio.TabIndex = 3;
            this.btnVacio.Text = "Vacia?";
            this.btnVacio.UseVisualStyleBackColor = true;
            this.btnVacio.Click += new System.EventHandler(this.btnVacio_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(108, 491);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(82, 41);
            this.btnPrimero.TabIndex = 2;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 578);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnVacio);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtElemento);
            this.Name = "frmPilas";
            this.Text = "Pilas";
            this.Load += new System.EventHandler(this.frmPilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnVacio;
        private System.Windows.Forms.Button btnPrimero;
    }
}