using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using RecetasSLN.Servicios.Interfaes;
using System;
using System.Data;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmAltaRecetas : Form
    {
        private static FrmAltaRecetas instancia;
        private Receta nueva;
        private IServicio servicio;
        private FabricaServicio oFabrica;

        public static FrmAltaRecetas ObtenerInstancia()
        {
            if (instancia == null) instancia = new FrmAltaRecetas();
            return instancia;
        }
        public FrmAltaRecetas()
        {
            InitializeComponent();
            oFabrica = new FabricaServicioIMP();
            servicio = oFabrica.CrearServicio();
            nueva = new Receta();
            UltimaReceta();
        }

        private void UltimaReceta()
        {
            lblRecetaN.Text = "Receta #: " + servicio.ProximaReceta();
        }

        private void FrmAltaRecetas_Load(object sender, EventArgs e)
        {
          CargarCombo();
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtCheff.Text = string.Empty;
            cboTipoRecetas.Text = "";
            dgvIngredientes.Rows.Clear();
            lblTotalIngredientes.Text = "Total de ingredientes:";
            UltimaReceta();
        }

        private void CargarCombo()
        {
            DataTable tabla = servicio.ConsultarDB("sp_consultar_ingredientes");
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
            else if (string.IsNullOrEmpty(numCantidad.Text) || !int.TryParse(numCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow fila in dgvIngredientes.Rows)
            {
                if (fila.Cells["colIngredientes"].Value != null)
                {
                    if (fila.Cells["colIngredientes"].Value.ToString().Equals(cboIngredientes.Text))
                    {
                        MessageBox.Show("El ingrediente ya esta agregado", "AVISO", MessageBoxButtons.OK);
                        cboIngredientes.Focus();
                        return;
                    }
                }
            }

            DataRowView item = (DataRowView)cboIngredientes.SelectedItem;
            int ingrId = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();

            Ingrediente i = new Ingrediente();
            i.Nombre = nombre;
            i.IngredienteId = ingrId;

            int cant = Convert.ToInt32(numCantidad.Value);
            DetalleReceta detalle = new DetalleReceta();
            detalle.Cantidad = cant;
            detalle.Ingrediente = i;

            nueva.AgregarDetalle(detalle);

            dgvIngredientes.Rows.Add(new object[] { ingrId, nombre, cant });

            TotalIngredientes();
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
            nueva.RecetaNro = servicio.ProximaReceta();
            nueva.Nombre = txtNombre.Text;
            nueva.Cheff = txtCheff.Text;
            nueva.TipoReceta = Convert.ToInt32(cboTipoRecetas.SelectedIndex);

            if (servicio.ConfirmarTransaccion(nueva))
            {
                MessageBox.Show("Receta guardada");
                Limpiar();

            }
            else
            {
                MessageBox.Show("Receta NO guardada");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvIngredientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngredientes.CurrentCell.ColumnIndex == 3)
            {
                try
                {
                    nueva.QuitarDetalle(dgvIngredientes.CurrentRow.Index);
                    dgvIngredientes.Rows.Remove(dgvIngredientes.CurrentRow);
                    TotalIngredientes();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
