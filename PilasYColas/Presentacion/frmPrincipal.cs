using PilasYColas.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasYColas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del formulario?",
                "saliendo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }

        private void verFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas pilas = new frmPilas();
            pilas.Show();
        }

        private void verFormularioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmColas colas = new frmColas();
            colas.Show();
        }
    }
}
