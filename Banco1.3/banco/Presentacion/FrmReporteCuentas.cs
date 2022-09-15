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
    public partial class FrmReporteCuentas : Form
    {
        private static FrmReporteCuentas instancia;

        public static FrmReporteCuentas ObtenerInstancia()
        {
            if (instancia == null) instancia = new FrmReporteCuentas();
            return instancia;
        }
        public FrmReporteCuentas()
        {
            InitializeComponent();
        }

        private void FrmReporteCuentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSCuentas.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dSCuentas.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
