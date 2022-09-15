using banco.AccesoDatos;
using banco.Presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace banco
{
    public partial class frmCuentas : Form
    {
        List<Cuenta> lCuentas;
        private static frmCuentas instancia;

        public static frmCuentas ObtenerInstancia()
        {
            if (instancia == null) instancia = new frmCuentas();
            return instancia;
        }


        public frmCuentas()
        {
            InitializeComponent();
            lCuentas = new List<Cuenta>();
        }


        private void Banco_Load(object sender, EventArgs e)
        {
            CargarComboTipoCuentas();
            CargarComboClientes();
            CargarGridCuentas();
            LimpiarCuentas();
            HabilitarCuentas(false);
        }


        private void CargarGridCuentas()
        {
            dataGridCuentas.DataSource = null;
            dataGridCuentas.Rows.Clear();
            dataGridCuentas.Columns.Clear();
            lCuentas.Clear();
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("Select cbu, t.nombre as 'Tipo de Cuenta', c.nombre + ' ' + c.apellido as 'cliente', total Total" +
                " from cuentas join clientes c on c.id_cliente=cuentas.id_cliente" +
                " join tiposCuentas t on t.id_tipoCuenta=cuentas.id_tipoCuenta" +
                " where activo=1");
            DataTable tabla2 = DbHelperDao.ObtenerInstancia().ConsultarDb("select cbu, id_tipoCuenta, dni from cuentas c join clientes cc on c.id_cliente=cc.id_cliente where activo=1");
            foreach (DataRow fila in tabla2.Rows)
            {
                Cuenta c = new Cuenta();
                c.pCbu = Convert.ToInt32(fila["cbu"]);
                c.pTipoCuenta = Convert.ToInt32(fila["id_tipoCuenta"]);
                c.pCliente = Convert.ToInt32(fila["dni"]);
                lCuentas.Add(c);
            }
            dataGridCuentas.DataSource = tabla;
        }


        private void CargarComboTipoCuentas()
        {
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("SELECT * FROM TiposCuentas order by 2");
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = "nombre";
            cboTipoCuenta.ValueMember = "id_tipoCuenta";
            cboTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void CargarComboClientes()
        {
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("SELECT * FROM clientes order by 2");
            cboCliente.DataSource = tabla;
            cboCliente.DisplayMember = "dni";
            cboCliente.ValueMember = "id_cliente";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void LimpiarCuentas()
        {
            txtCbu.Text = "";
            cboTipoCuenta.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
        }


        private void HabilitarCuentas(bool v)
        {
            txtCbu.Enabled = v;
            cboTipoCuenta.Enabled = v;
            cboCliente.Enabled = v;
            btnGrabarCuentas.Enabled = v;
            btnNuevoCuentas.Enabled = !v;
            btnCancelarCuentas.Enabled = v;
            btnEditarCuentas.Enabled = !v;
            btnEliminarCuentas.Enabled = v;
        }


        private bool ValidarCuenta()
        {
            if (txtCbu.Text == "")
            {
                MessageBox.Show("Debe ingresar un cbu");
                txtCbu.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCbu.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El cbu debe ser un numero o quiza es muy grande el numero");
                    txtCbu.Focus();
                    return false;
                }
            }

            if (cboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta");
                cboTipoCuenta.Focus();
                return false;
            }
            else if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                cboCliente.Focus();
                return false;
            }

            return true;
        }


        private bool ExisteCuenta(Cuenta c)
        {
            for (int i = 0; i < lCuentas.Count; i++)
            {
                if (lCuentas[i].pCbu == c.pCbu) return true;
            }

            return false;
        }


        private void CargarDatosCuentas(int posicion)
        {
            txtCbu.Text = Convert.ToString(lCuentas[posicion].pCbu);
            cboTipoCuenta.SelectedValue = lCuentas[posicion].pTipoCuenta;
            cboCliente.SelectedValue = lCuentas[posicion].pCliente;
        }







        private void btnNuevoCuentas_Click_1(object sender, EventArgs e)
        {
            HabilitarCuentas(true);
            btnEliminarCuentas.Enabled = false;
            LimpiarCuentas();
            txtCbu.Focus();
        }


        private void btnEditarCuentas_Click_1(object sender, EventArgs e)
        {
            HabilitarCuentas(true);
            txtCbu.Enabled = false;
        }


        private void btnGrabarCuentas_Click_1(object sender, EventArgs e)
        {
            if (ValidarCuenta())
            {
                Cuenta c = new Cuenta();
                c.pCbu = Convert.ToInt32(txtCbu.Text);
                c.pTipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
                c.pCliente = Convert.ToInt32(cboCliente.SelectedValue);

                if (!ExisteCuenta(c))
                {
                    List<Parametros> lParametros = new List<Parametros>();
                    lParametros.Add(new Parametros("@cbu", c.pCbu));
                    lParametros.Add(new Parametros("@id_tipoCuenta", c.pTipoCuenta));
                    lParametros.Add(new Parametros("@id_cliente", c.pCliente));

                    if (DbHelperDao.ObtenerInstancia().EjecutarSP("sp_ingresarCuenta", lParametros) > 0)
                    {
                        MessageBox.Show("Se pudo Ingresar la cuenta");
                        LimpiarCuentas();
                        HabilitarCuentas(false);
                        CargarGridCuentas();
                    }
                }
                else
                {
                    List<Parametros> lParametros = new List<Parametros>();
                    lParametros.Add(new Parametros("@cbu", c.pCbu));
                    lParametros.Add(new Parametros("@id_tipoCuenta", c.pTipoCuenta));
                    lParametros.Add(new Parametros("@id_cliente", c.pCliente));
                    if (DbHelperDao.ObtenerInstancia().EjecutarSP("sp_actualizarCuenta", lParametros) > 0) MessageBox.Show("Se ha podido actualizar la cuenta");

                    HabilitarCuentas(false);
                    LimpiarCuentas();
                    CargarGridCuentas();
                }
            }
        }


        private void btnEliminarCuentas_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar la Cuenta?",
                "Eliminando...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                

                if (DbHelperDao.ObtenerInstancia().EjecutarEliminarSP("Sp_eliminarCuentaYRelacionados", -1, lCuentas[Convert.ToInt32(dataGridCuentas.CurrentCell.RowIndex)].pCliente)) MessageBox.Show("se pudo eliminar la Cuenta");
                
                CargarGridCuentas();
                LimpiarCuentas();
                HabilitarCuentas(false);
            }
        }


        private void btnCancelarCuentas_Click_1(object sender, EventArgs e)
        {
            HabilitarCuentas(false);
            LimpiarCuentas();
        }


        private void btnSalirCuentas_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del formulario?",
                "saliendo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }


        private void dataGridCuentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) CargarDatosCuentas(e.RowIndex);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
