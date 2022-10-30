using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApi.Datos;
using DataApi.Dominio;
using FrontBanco.Formularios;

namespace FrontBanco.Formularios
{
    public partial class frmTransacciones : Form
    {
        private Transaccion nuevo;
        private static frmTransacciones instancia;

        public static frmTransacciones ObtenerInstancia()
        {
            if (instancia == null) instancia = new frmTransacciones();
            return instancia;
        }

        public frmTransacciones()
        {
            InitializeComponent();
            nuevo = new Transaccion();
        }


        private void frmTransacciones_Load(object sender, EventArgs e)
        {
            ProximaTransaccion();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.Enabled = false;
            CargarComboCuentas();
            CargarComboTipos();
            LimpiarTransacciones();
        }


        private void CargarComboTipos()
        {
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("SELECT * FROM tiposMovimientos order by 2");
            if (tabla != null)
            {
                cboTipos.DataSource = tabla;
                cboTipos.DisplayMember = "tipo";
                cboTipos.ValueMember = "id_tipo";
                cboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        private void CargarComboCuentas()
        {
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("SELECT * FROM cuentas where activo=1 order by 2");
            if (tabla != null)
            {
                cboCuentas.DataSource = tabla;
                cboCuentas.DisplayMember = "cbu";
                cboCuentas.ValueMember = "id_cuenta";
                cboCuentas.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        private void LimpiarTransacciones()
        {
            txtMonto.Text = "";
            cboCuentas.SelectedIndex = -1;
            cboTipos.SelectedIndex = -1;
            txtTotal.Text = "";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del formulario?",
                "saliendo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }


        private void ProximaTransaccion()
        {
            int next = DbHelperDao.ObtenerInstancia().ProximaTransaccion();
            if (next > 0)
                lblNroTransaccion.Text = "Transacción Nº: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de transacción!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void CalcularTotal()
        {
            double total = nuevo.CalcularTotal();
            txtTotal.Text = total.ToString();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboCuentas.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una cuenta!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCuentas.Focus();
                return;
            }

            if (cboTipos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una accion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipos.Focus();
                return;
            }

            if (txtMonto.Text == "" || !int.TryParse(txtMonto.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonto.Focus();
                return;
            }


            foreach (DataGridViewRow row in dgvTransacciones.Rows)
            {
                if (row.Cells["colTipo"].Value.ToString().Equals(cboTipos.Text))
                {
                    MessageBox.Show("Ya se realizo esa Accion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            double monto = Convert.ToDouble(txtMonto.Text);
            int tipo = Convert.ToInt32(cboTipos.SelectedValue);
            if (tipo == 2) monto = 0 - monto;
            Movimiento movimiento = new Movimiento(monto, tipo);
            nuevo.AgregarMovimiento(movimiento);

            dgvTransacciones.Rows.Add(cboCuentas.SelectedValue,movimiento.Monto, cboTipos.Text);

            CalcularTotal();
            cboCuentas.Enabled = false;
            txtMonto.Text = "";
            cboTipos.SelectedIndex = -1;
        }


        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransacciones.CurrentCell.ColumnIndex == 3)
            {
                nuevo.QuitarMovimiento(dgvTransacciones.CurrentRow.Index);
                dgvTransacciones.Rows.Remove(dgvTransacciones.CurrentRow);
                CalcularTotal();

            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un movimiento!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarTransaccion();
            
        }


        private void GuardarTransaccion()
        {
            nuevo.IdCuenta = Convert.ToInt32(cboCuentas.SelectedValue);
            nuevo.Fecha = Convert.ToDateTime(txtFecha.Text);
            if (DbHelperDao.ObtenerInstancia().ConfirmarTransaccion(nuevo))
            {
                DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("select total from cuentas where id_cuenta=" + nuevo.IdCuenta);
                int total = Convert.ToInt32(tabla.Rows[0]["total"]);
                List<Parametros> lParametros = new List<Parametros>();
                lParametros.Add(new Parametros("@total", total + nuevo.CalcularTotal()));
                lParametros.Add(new Parametros("@ultimo_Mov", nuevo.Fecha));
                lParametros.Add(new Parametros("@id_Cuenta", nuevo.IdCuenta));
                
                if(DbHelperDao.ObtenerInstancia().EjecutarSP("sp_adjuntarTransaccion", lParametros) > 0 )
                {
                    MessageBox.Show("Transacción registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la Transacción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNroPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
