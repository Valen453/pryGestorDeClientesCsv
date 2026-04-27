namespace pryGestorDeClientesCsb
{
    partial class frmClientesDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(344, 451);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(167, 13);
            this.lblCantidadClientes.TabIndex = 9;
            this.lblCantidadClientes.Text = "La cantidad de clientes es de 999";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(344, 483);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(204, 13);
            this.lblPromedioDeuda.TabIndex = 8;
            this.lblPromedioDeuda.Text = "El promedio de la deuda es de $99999.99";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(344, 426);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(181, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "El total de la deuda es de $99999.99";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colUsuario,
            this.colLimite,
            this.colDeuda});
            this.dgvUsuario.Location = new System.Drawing.Point(76, 12);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(483, 383);
            this.dgvUsuario.TabIndex = 6;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Limite de crédito";
            this.colLimite.Name = "colLimite";
            this.colLimite.ReadOnly = true;
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.ReadOnly = true;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 576);
            this.Controls.Add(this.lblCantidadClientes);
            this.Controls.Add(this.lblPromedioDeuda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvUsuario);
            this.Name = "frmClientesDeudores";
            this.Text = "Clientes Deudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
    }
}