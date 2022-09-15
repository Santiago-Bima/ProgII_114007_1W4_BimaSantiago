using PilasYColas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasYColas.Presentacion
{
    public partial class frmColas : Form
    {

        private ICollection coleccion;

        public frmColas()
        {
            InitializeComponent();
            coleccion = new Colas();
        }

        private void frmColas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
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

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            if (!coleccion.estaVacia())
                MessageBox.Show("Primer elemento: " + coleccion.primero(), "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVacio_Click_1(object sender, EventArgs e)
        {
            string mensaje = coleccion.estaVacia() ? "Cola vacía" : "Cola con elementos";
            MessageBox.Show(mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraer_Click_1(object sender, EventArgs e)
        {
            object elemento = coleccion.extraer();
            lstElementos.Items.Remove(elemento);
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
