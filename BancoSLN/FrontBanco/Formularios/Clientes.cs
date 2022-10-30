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
    public partial class frmClientes : Form
    {
        List<Cliente> lClientes;
        private static frmClientes instancia;

        public static frmClientes ObtenerInstancia()
        {
            if(instancia == null) instancia = new frmClientes();
            return instancia;
        }

        public frmClientes()
        {
            InitializeComponent();
            lClientes = new List<Cliente>();
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
            LimpiarClientes();
            HabilitarCliente(false);
        }


        private void CargarListaClientes()
        {
            lstClientes.Items.Clear();
            lClientes.Clear();
            DataTable tabla = DbHelperDao.ObtenerInstancia().ConsultarDb("Select * from clientes");
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.pNombre = Convert.ToString(fila["nombre"]);
                c.pApellido = Convert.ToString(fila["apellido"]);
                c.pDni = Convert.ToInt32(fila["dni"]);
                lClientes.Add(c);
                lstClientes.Items.Add(c.ToString());
            }
        }


        private void LimpiarClientes()
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = String.Empty;
            txtDniCliente.Text = "";
        }


        private void HabilitarCliente(bool v)
        {
            txtApellidoCliente.Enabled = v;
            txtNombreCliente.Enabled = v;
            txtDniCliente.Enabled = v;
            btnEliminarClientes.Enabled = v;
            btnGrabarClientes.Enabled = v;
            btnNuevoClientes.Enabled = !v;
            btnCancelarClientes.Enabled = v;
            btnEditarClientes.Enabled = !v;
        }


        private bool ValidarCliente()
        {
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                txtNombreCliente.Focus();
                return false;
            }


            if (txtApellidoCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                txtApellidoCliente.Focus();
                return false;
            }

            if (txtDniCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un dni");
                txtDniCliente.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDniCliente.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El dni debe ser un numero");
                    txtDniCliente.Focus();
                    return false;
                }
            }
            return true;
        }


        private bool ExisteCliente(Cliente c)
        {
            for (int i = 0; i < lClientes.Count; i++)
            {
                if (lClientes[i].pDni == c.pDni) return true;
            }

            return false;
        }


        private void CargarDatosClientes(int posicion)
        {
            try
            {
                txtNombreCliente.Text = lClientes[posicion].pNombre;
                txtApellidoCliente.Text = lClientes[posicion].pApellido;
                txtDniCliente.Text = Convert.ToString(lClientes[posicion].pDni);
            }
            catch (Exception)
            {

            }
        }






        private void btnNuevoClientes_Click_1(object sender, EventArgs e)
        {
            HabilitarCliente(true);
            btnEliminarClientes.Enabled = false;
            LimpiarClientes();
            txtNombreCliente.Focus();
        }


        private void btnGrabarClientes_Click_1(object sender, EventArgs e)
        {
            if (ValidarCliente())
            {
                Cliente c = new Cliente();
                c.pNombre = txtNombreCliente.Text;
                c.pApellido = txtApellidoCliente.Text;
                c.pDni = Convert.ToInt32(txtDniCliente.Text);

                if (!ExisteCliente(c))
                {
                    List<Parametros> lParametros = new List<Parametros>();
                    lParametros.Add(new Parametros("@nombre", txtNombreCliente.Text));
                    lParametros.Add(new Parametros("@apellido", txtApellidoCliente.Text));
                    lParametros.Add(new Parametros("@dni", Convert.ToInt32(txtDniCliente.Text)));

                    if (DbHelperDao.ObtenerInstancia().EjecutarSP("sp_ingresarCliente", lParametros) > 0)
                    {
                        MessageBox.Show("Se pudo Ingresar el Cliente");
                        LimpiarClientes();
                        HabilitarCliente(false);
                        CargarListaClientes();
                    }
                }
                else
                {
                    List<Parametros> lParametros = new List<Parametros>();
                    lParametros.Add(new Parametros("@nombre", c.pNombre));
                    lParametros.Add(new Parametros("@apellido", c.pApellido));
                    lParametros.Add(new Parametros("@dni", c.pDni));
                    if (DbHelperDao.ObtenerInstancia().EjecutarSP("sp_actualizarCliente", lParametros) > 0) MessageBox.Show("Se ha podido actualizar el cliente");

                    HabilitarCliente(false);
                    LimpiarClientes();
                    CargarListaClientes();
                }
            }
        }


        private void btnEditarClientes_Click_1(object sender, EventArgs e)
        {
            HabilitarCliente(true);
            txtDniCliente.Enabled = false;
            txtNombreCliente.Focus();
        }


        private void btnEliminarClientes_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar el cliente?",
                "Eliminando...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {

                if (DbHelperDao.ObtenerInstancia().EjecutarEliminarSP("Sp_eliminarCliente", lClientes[lstClientes.SelectedIndex].pDni, -1)) MessageBox.Show("se pudo eliminar el Cliente");
                
                CargarListaClientes();
                LimpiarClientes();
                HabilitarCliente(false);
            }
        }


        private void btnCancelarClientes_Click(object sender, EventArgs e)
        {
            HabilitarCliente(false);
            LimpiarClientes();
        }


        private void btnSalirClientes_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del formulario?",
               "saliendo...",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }


        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosClientes(lstClientes.SelectedIndex);
        }
    }

}
