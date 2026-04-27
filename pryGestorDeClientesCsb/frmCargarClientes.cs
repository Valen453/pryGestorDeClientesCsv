using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestorDeClientesCsb
{
    public partial class frmCargarClientes : Form
    {
        public frmCargarClientes()
        {
            InitializeComponent();
        }
        clsArchivoCliente x = new clsArchivoCliente();


        private void verificarContenido()
        {
            if (txtCodigo.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "" && txtUsuario.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }


        private void frmCargarClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            verificarContenido();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            verificarContenido();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            verificarContenido();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            verificarContenido();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {


            x.Grabar(txtCodigo.Text, txtUsuario.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Datos grabados correctamente");
        }


    }
}
