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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsArchivoCliente x = new clsArchivoCliente();

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvUsuario);
        }
    }
}
