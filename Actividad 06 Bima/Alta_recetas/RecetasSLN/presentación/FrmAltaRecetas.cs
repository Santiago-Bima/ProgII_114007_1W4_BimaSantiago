using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.datos;

namespace RecetasSLN.presentación
{
    public partial class FrmAltaRecetas : Form
    {
        private static FrmAltaRecetas instancia;
        private Receta nueva;
        public static FrmAltaRecetas ObtenerInstancia()
        {
            if (instancia == null) instancia = new FrmAltaRecetas();
            return instancia;
        }
        public FrmAltaRecetas()
        {
            InitializeComponent();
            nueva = new Receta();
            ultimaReceta();
        }
        
        private void ultimaReceta()
        {
            lblRecetaN.Text = "Receta #: " + RecetaDao.ObtenerInstancia().ProximaReceta();
        }

        private void FrmAltaRecetas_Load(object sender, EventArgs e)
        {
            cargarCombo();
            limpiar();
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtCheff.Text = string.Empty;
            cboTipoRecetas.SelectedValue = -1;
            dgvIngredientes.Rows.Clear();
            lblTotalIngredientes.Text = "Total de ingredientes:";
            ultimaReceta();
        }

        private void cargarCombo()
        {
            DataTable tabla = RecetaDao.ObtenerInstancia().ConsultarDB("sp_consultar_ingredientes");
            cboIngredientes.DataSource = tabla;
            cboIngredientes.ValueMember = "id_ingrediente";
            cboIngredientes.DisplayMember = "n_ingrediente";
            cboIngredientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (cboIngredientes.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un ingrediente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(numCantidad.Text) || !int.TryParse(numCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if(existe(cboIngredientes.Text))
                MessageBox.Show("Este ingrediente ya está cargado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DataRowView item = (DataRowView)cboIngredientes.SelectedItem;
            int ingrId = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();

            Ingrediente i = new Ingrediente(ingrId, nombre, 0);
            int cant = Convert.ToInt32(numCantidad.Value);
            DetalleReceta detalle = new DetalleReceta(i, cant);

            nueva.AgregarDetalle(detalle);

            dgvIngredientes.Rows.Add(new object[] { ingrId, nombre, cant });

            TotalIngredientes();
        }
        private bool existe(string text)
        {
            foreach (DataGridViewRow fila in dgvIngredientes.Rows)
            {
                if (fila.Cells["colIngredientes"].Value.Equals(text))
                   return true;
            }
            return false;
        }

        private void TotalIngredientes()
        {
            lblTotalIngredientes.Text = "Total de ingredientes:" + dgvIngredientes.Rows.Count;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCheff.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Chef", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCheff.Focus();
                return;
            }

            if (dgvIngredientes.Rows.Count < 3)
            {
                MessageBox.Show("Debe ingresar 3 ingredientes como minimo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIngredientes.Focus();
                return;

            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            nueva.RecetaNro = RecetaDao.ObtenerInstancia().ProximaReceta();
            nueva.Nombre = txtNombre.Text;
            nueva.Cheff = txtCheff.Text;
            nueva.TipoReceta = Convert.ToInt32(cboTipoRecetas.SelectedIndex);
            if (RecetaDao.ObtenerInstancia().ConfirmarTransaccion(nueva))
            {
                MessageBox.Show("Receta guardada");
                limpiar();

            }
            else
            {
                MessageBox.Show("Receta NO guardada");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
