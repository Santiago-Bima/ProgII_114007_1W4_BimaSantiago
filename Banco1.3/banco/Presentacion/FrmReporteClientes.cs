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
        private static FrmReporteClientes instancia;

        public static FrmReporteClientes ObtenerInstancia()
        {
            if (instancia == null) instancia = new FrmReporteClientes();
            return instancia;
        }
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientes.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dSClientes.clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
