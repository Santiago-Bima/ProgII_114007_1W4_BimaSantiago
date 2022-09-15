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
    public partial class FrmReporteClientes : Form
    {
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dSClientes.clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
