using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco.Presentacion
{
    public partial class frmReporteTransacciones : Form
    {

        private DbHelperConexion helper;
        public frmReporteTransacciones()
        {
            InitializeComponent();
            helper = DbHelperConexion.ObtenerInstancia();
        }

        private void frmReporteTransacciones_Load(object sender, EventArgs e)
        {
            CargarComboCuentas();
        }
        private void CargarComboCuentas()
        {
            DataTable tabla = helper.ConsultarDb("SELECT * FROM cuentas where activo=1 order by 2");
            if (tabla != null)
            {
                cboCuentas.DataSource = tabla;
                cboCuentas.DisplayMember = "cbu";
                cboCuentas.ValueMember = "cbu";
                cboCuentas.DropDownStyle = ComboBoxStyle.DropDownList;
                cboCuentas.SelectedIndex = -1;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string cadenaSql = "SELECT nro_transaccion 'Numero_de_Transaccion', nombre + ' ' + apellido Cliente, " +
                " fecha Fecha, t.total Total" +
                " FROM transacciones t join cuentas q on q.id_cuenta=t.id_cuenta" +
                " join clientes c on c.id_cliente = q.id_cliente" +
                " WHERE cbu =" + Convert.ToInt32(cboCuentas.SelectedValue);
                if (cboCuentas.SelectedIndex > -1)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", helper.ConsultarDb(cadenaSql)));
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una cuenta!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboCuentas.Focus();
                    return;
                }
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
