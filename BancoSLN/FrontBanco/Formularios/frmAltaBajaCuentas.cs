using DataApi.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontBanco.Formularios;
using DataApi.Dominio;

namespace FrontBanco.Formularios
{
    public partial class frmAltaBajaCuentas : Form
    {
        List<Cuenta> lCuentas;
        private static frmAltaBajaCuentas instancia;

        public static frmAltaBajaCuentas ObtenerInstancia()
        {
            if (instancia == null) instancia = new frmAltaBajaCuentas();
            return instancia;
        }
        public frmAltaBajaCuentas()
        {
            InitializeComponent();
            lCuentas = new List<Cuenta>();
        }
        private void frmAltaBaja_Load(object sender, EventArgs e)
        {
            CargarListaCuentas();
        }

        private void CargarListaCuentas()
        {
            lstCuentas.Items.Clear();
            lCuentas.Clear();
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("Select cbu , t.nombre tipo, cl.nombre + ' ' + apellido cliente, activo from cuentas c" +
                " join tiposCuentas t on t.id_tipoCuenta=c.id_tipoCuenta" +
                " join clientes cl on c.id_cliente=cl.id_cliente");
            foreach (DataRow fila in tabla.Rows)
            {
                Cuenta c = new Cuenta();
                c.pCbu = Convert.ToInt32(fila["cbu"]);
                c.pActivo = Convert.ToInt32(fila["activo"]);
                lCuentas.Add(c);
                string activo;
                if (Convert.ToInt32(fila["activo"]) == 1) activo = "Activa";
                else activo = "Dado de Baja";
                lstCuentas.Items.Add(Convert.ToString(fila["cbu"] + " - " + fila["tipo"] + " - " + fila["cliente"] + " - " + activo));
            }
        }

        private void lstCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCbu.Text = Convert.ToString(lCuentas[lstCuentas.SelectedIndex].pCbu);
                if (lCuentas[lstCuentas.SelectedIndex].pActivo == 1)
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

        private void frmCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del formulario?",
                "saliendo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            MandarSql("sp_darAlta");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            MandarSql("sp_darBaja");
        }

        private void MandarSql(string nombreSp)
        {
            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@cbu", Convert.ToInt32(txtCbu.Text)));
            if (DbHelperDao.ObtenerInstancia().EjecutarSP(nombreSp, lParametros) > 0) MessageBox.Show("Se ha podido actualizar la cuenta");
            CargarListaCuentas();
        }
    }
}
