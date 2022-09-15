namespace PilasYColas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFormularioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFormularioToolStripMenuItem});
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.pilasToolStripMenuItem.Text = "Pilas";
            // 
            // verFormularioToolStripMenuItem
            // 
            this.verFormularioToolStripMenuItem.Name = "verFormularioToolStripMenuItem";
            this.verFormularioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verFormularioToolStripMenuItem.Text = "ver Formulario";
            this.verFormularioToolStripMenuItem.Click += new System.EventHandler(this.verFormularioToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFormularioToolStripMenuItem1});
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.colasToolStripMenuItem.Text = "Colas";
            // 
            // verFormularioToolStripMenuItem1
            // 
            this.verFormularioToolStripMenuItem1.Name = "verFormularioToolStripMenuItem1";
            this.verFormularioToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.verFormularioToolStripMenuItem1.Text = "Ver Formulario";
            this.verFormularioToolStripMenuItem1.Click += new System.EventHandler(this.verFormularioToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFormularioToolStripMenuItem1;
    }
}

