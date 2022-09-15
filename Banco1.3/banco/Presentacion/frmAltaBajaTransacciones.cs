using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banco.Dominio;

namespace banco.Presentacion
{
    public partial class frmAltaBajaTransacciones : Form
    {
        private DbHelperConexion helper;
        List<Cuenta> lCuentas;
        List<Transaccion> lTransacciones;
        public frmAltaBajaTransacciones()
        {
            InitializeComponent();
            helper = DbHelperConexion.ObtenerInstancia();
            lCuentas = new List<Cuenta>();
            lTransacciones = new List<Transaccion>();
        }

        private void frmAltaBajaTransacciones_Load(object sender, EventArgs e)
        {
            CargarListaCuentas();
        }

        private void CargarListaCuentas()
        {
            lstCuentas.Items.Clear();
            lCuentas.Clear();
            DataTable tabla = helper.ConsultarDb("Select id_cuenta, cbu , t.nombre tipo, cl.nombre + ' ' + apellido cliente, total" +
                " from cuentas c " +
                " join tiposCuentas t on t.id_tipoCuenta=c.id_tipoCuenta" +
                " join clientes cl on c.id_cliente=cl.id_cliente" +
                " where c.activo=1");
            foreach (DataRow fila in tabla.Rows)
            {
                Cuenta c = new Cuenta();
                c.pCbu = Convert.ToInt32(fila["cbu"]);
                c.pId = Convert.ToInt32(fila["id_cuenta"]);
                c.pTotal = Convert.ToDouble(fila["total"]);
                lCuentas.Add(c);
                lstCuentas.Items.Add(Convert.ToString(fila["cbu"] + " - " + fila["tipo"] + " - " + fila["cliente"]));
            }
        }

        private void lstCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCbu.Text = Convert.ToString(lCuentas[lstCuentas.SelectedIndex].pCbu);
                CargarListaTransacciones(lCuentas[lstCuentas.SelectedIndex].pId);
            }
            catch (Exception) { }
        }

        private void CargarListaTransacciones(int id_cuenta)
        {
            lstTransacciones.Items.Clear();
            lTransacciones.Clear();
            DataTable tabla = helper.ConsultarDb("Select nro_transaccion, total, fecha, activo" +
                " from transacciones t" +
                " where t.id_cuenta=" + id_cuenta);
            foreach (DataRow fila in tabla.Rows)
            {
                Transaccion t = new Transaccion();
                t.pActivo = Convert.ToInt32(fila["activo"]);
                t.NroT = Convert.ToInt32(fila["nro_transaccion"]);
                t.Monto = Convert.ToDouble(fila["total"]);
                t.Fecha = Convert.ToDateTime(fila["fecha"]);
                lTransacciones.Add(t);
                string activo;
                if (Convert.ToInt32(fila["activo"]) == 1) activo = "Activa";
                else activo = "Dado de Baja";
                lstTransacciones.Items.Add(Convert.ToString( "Nro° : " +fila["nro_transaccion"] + "  -  Total: $" + fila["total"] + "  -  " + fila["fecha"] + "  -  " + activo));
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNroT.Text = Convert.ToString(lTransacciones[lstTransacciones.SelectedIndex].NroT);
                txtMonto.Text = Convert.ToString(lTransacciones[lstTransacciones.SelectedIndex].Monto);
                txtFecha.Text = Convert.ToString(lTransacciones[lstTransacciones.SelectedIndex].Fecha);
                if (lTransacciones[lstTransacciones.SelectedIndex].pActivo == 1)
                {
                    btnAlta.Enabled = false;
                    btnBaja.Enabled = true;
                }
                else
                {
                    btnBaja.Enabled = false;
                    btnAlta.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del formulario?",
                "saliendo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }


        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            double monto = lCuentas[lstCuentas.SelectedIndex].pTotal - lTransacciones[lstTransacciones.SelectedIndex].Monto;

            MandarSql("sp_darBajaTransaccion", monto);
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            double monto = lCuentas[lstCuentas.SelectedIndex].pTotal + lTransacciones[lstTransacciones.SelectedIndex].Monto;

            MandarSql("sp_darAltaTransaccion", monto);
        }

        private void MandarSql(string nombreSp, double monto)
        {
            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@nro", Convert.ToInt32(txtNroT.Text)));

            List<Parametros> lParametros2 = new List<Parametros>();
            lParametros2.Add(new Parametros("@monto", monto));
            lParametros2.Add(new Parametros("@id_cuenta", Convert.ToInt32(lCuentas[lstCuentas.SelectedIndex].pId)));
            if (helper.EjecutarSP(nombreSp, lParametros) > 0 && helper.EjecutarSP("sp_actualizarTotal", lParametros2)>0) MessageBox.Show("Se ha podido actualizar la transaccion");
            CargarListaTransacciones(lCuentas[lstCuentas.SelectedIndex].pId);
        }
    }
}
    