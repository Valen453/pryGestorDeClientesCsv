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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        clsArchivoCliente x = new clsArchivoCliente();

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvUsuario);
        }
    }
}
