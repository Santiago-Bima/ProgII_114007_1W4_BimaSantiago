using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PilasYColas.Dominio;

namespace PilasYColas
{
    public partial class frmPilas : Form
    {

        private ICollection coleccion;

        public frmPilas()
        {
            InitializeComponent();
            coleccion = new Pilas(20);
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtElemento.Text))
            {
                object elemento = txtElemento.Text;
                if (coleccion.añadir(elemento))
                {
                    lstElementos.Items.Add(elemento);
                    MessageBox.Show("Elemento Añadido", "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lista llena!", "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!coleccion.estaVacia())
                MessageBox.Show("Primer elemento: " + coleccion.primero(), "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVacio_Click(object sender, EventArgs e)
        {
            string mensaje = coleccion.estaVacia() ? "Pila vacía" : "Pila con elementos";
            MessageBox.Show(mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            object elemento = coleccion.extraer();
            lstElementos.Items.Remove(elemento);
        }
    }
}
