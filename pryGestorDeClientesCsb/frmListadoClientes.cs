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
            lblCantidadClientes.Text = "El total de clientes es de " + Convert.ToString(x.cantidadClientes());
            lblTotal.Text = "El total de la deuda es de $" + Convert.ToString(x.sumarDeuda(dgvUsuario));
            lblPromedioDeuda.Text = "El promedio de la deuda es de $" + Convert.ToString(x.promedioDeuda(dgvUsuario));

        }
    }
}
