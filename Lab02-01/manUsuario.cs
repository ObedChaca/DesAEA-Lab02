using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nom = txtNombre.Text;
            string ape = txtApellido.Text;
            string tel = txtTelefono.Text;
            string ema = txtEmail.Text;
            string dir = txtDireccion.Text;
            string fec = txtFecha.Text;

            dgvUsuarios.Rows.Add(dni, nom, ape, tel, ema, dir, fec);

            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtFecha.Text = "";
        }
    }
}
