using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontBanco.Formularios
{
    public partial class FrmLogin : Form
    {
        frmPrincipal principal;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario y una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                if (txtUsuario.Text == "Admin" && txtContraseña.Text == "Pass123")
                {
                    principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else if (txtUsuario.Text != "Admin" || txtContraseña.Text != "Pass")
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (txtUsuario.Text == "" && txtContraseña.Text != "")
            {
                MessageBox.Show("Ingrese un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtUsuario.Text != "" && txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese una Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked == true)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
