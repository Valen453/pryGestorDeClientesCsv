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
            lblCantidadClientes.Text = "El total de clientes es de " + Convert.ToString(x.cantidadClientesDeudores(dgvUsuario));
            lblTotal.Text = "El total de la deuda es de $" + Convert.ToString(x.sumarDeuda(dgvUsuario));
            lblPromedioDeuda.Text = "El promedio de la deuda es de $" + Convert.ToString(
                x.promedioDeuda(x.cantidadClientesDeudores(dgvUsuario), x.sumarDeuda(dgvUsuario)));


        }
    }
}
