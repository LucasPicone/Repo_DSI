namespace ImplementacionDSI
{
    partial class frmGenerarRemito
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PENombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.txtAgregarCorte = new System.Windows.Forms.Button();
            this.txtCorte = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCortesCandidatos = new System.Windows.Forms.DataGridView();
            this.nombreCorteDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilosCorteDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaComercializacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCortesSolicitados = new System.Windows.Forms.DataGridView();
            this.nombreCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilosCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCortesSeleccionados = new System.Windows.Forms.DataGridView();
            this.nombreCorteSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilosCorteSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilosAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarRemito = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesCandidatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSolicitados)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaPedido,
            this.numero,
            this.PENombre,
            this.direccion,
            this.razonSocial});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(983, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fechaPedido
            // 
            this.fechaPedido.HeaderText = "Fecha de Pedido";
            this.fechaPedido.Name = "fechaPedido";
            this.fechaPedido.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "numeroPedido";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            // 
            // PENombre
            // 
            this.PENombre.HeaderText = "Nombre Punto Entrega";
            this.PENombre.Name = "PENombre";
            this.PENombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Cliente";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCancelar);
            this.groupBox1.Controls.Add(this.txtAgregarCorte);
            this.groupBox1.Controls.Add(this.txtCorte);
            this.groupBox1.Controls.Add(this.txtPedido);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // txtCancelar
            // 
            this.txtCancelar.Location = new System.Drawing.Point(363, 307);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(238, 73);
            this.txtCancelar.TabIndex = 7;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            // 
            // txtAgregarCorte
            // 
            this.txtAgregarCorte.Enabled = false;
            this.txtAgregarCorte.Location = new System.Drawing.Point(363, 270);
            this.txtAgregarCorte.Name = "txtAgregarCorte";
            this.txtAgregarCorte.Size = new System.Drawing.Size(238, 30);
            this.txtAgregarCorte.TabIndex = 6;
            this.txtAgregarCorte.Text = "Agregar Corte";
            this.txtAgregarCorte.UseVisualStyleBackColor = true;
            // 
            // txtCorte
            // 
            this.txtCorte.Enabled = false;
            this.txtCorte.Location = new System.Drawing.Point(363, 234);
            this.txtCorte.Name = "txtCorte";
            this.txtCorte.Size = new System.Drawing.Size(238, 30);
            this.txtCorte.TabIndex = 5;
            this.txtCorte.Text = "Seleccionar Corte";
            this.txtCorte.UseVisualStyleBackColor = true;
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(363, 198);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(238, 30);
            this.txtPedido.TabIndex = 4;
            this.txtPedido.Text = "Seleccionar Pedido";
            this.txtPedido.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCortesCandidatos);
            this.groupBox3.Location = new System.Drawing.Point(630, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 225);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cortes Candidatos";
            // 
            // dgvCortesCandidatos
            // 
            this.dgvCortesCandidatos.AllowUserToAddRows = false;
            this.dgvCortesCandidatos.AllowUserToDeleteRows = false;
            this.dgvCortesCandidatos.AllowUserToResizeRows = false;
            this.dgvCortesCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortesCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCorteDisponible,
            this.kilosCorteDisponible,
            this.fechaComercializacion});
            this.dgvCortesCandidatos.Location = new System.Drawing.Point(11, 21);
            this.dgvCortesCandidatos.Name = "dgvCortesCandidatos";
            this.dgvCortesCandidatos.ReadOnly = true;
            this.dgvCortesCandidatos.RowHeadersVisible = false;
            this.dgvCortesCandidatos.RowTemplate.Height = 24;
            this.dgvCortesCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCortesCandidatos.Size = new System.Drawing.Size(330, 196);
            this.dgvCortesCandidatos.TabIndex = 2;
            // 
            // nombreCorteDisponible
            // 
            this.nombreCorteDisponible.HeaderText = "Nombre";
            this.nombreCorteDisponible.Name = "nombreCorteDisponible";
            this.nombreCorteDisponible.ReadOnly = true;
            // 
            // kilosCorteDisponible
            // 
            this.kilosCorteDisponible.HeaderText = "Kilos";
            this.kilosCorteDisponible.Name = "kilosCorteDisponible";
            this.kilosCorteDisponible.ReadOnly = true;
            // 
            // fechaComercializacion
            // 
            this.fechaComercializacion.HeaderText = "Fecha Comercialización";
            this.fechaComercializacion.Name = "fechaComercializacion";
            this.fechaComercializacion.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCortesSolicitados);
            this.groupBox2.Location = new System.Drawing.Point(6, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cortes Solicitados";
            // 
            // dgvCortesSolicitados
            // 
            this.dgvCortesSolicitados.AllowUserToAddRows = false;
            this.dgvCortesSolicitados.AllowUserToDeleteRows = false;
            this.dgvCortesSolicitados.AllowUserToResizeRows = false;
            this.dgvCortesSolicitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortesSolicitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCorte,
            this.kilosCorte});
            this.dgvCortesSolicitados.Location = new System.Drawing.Point(6, 21);
            this.dgvCortesSolicitados.Name = "dgvCortesSolicitados";
            this.dgvCortesSolicitados.ReadOnly = true;
            this.dgvCortesSolicitados.RowHeadersVisible = false;
            this.dgvCortesSolicitados.RowTemplate.Height = 24;
            this.dgvCortesSolicitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCortesSolicitados.Size = new System.Drawing.Size(310, 196);
            this.dgvCortesSolicitados.TabIndex = 1;
            // 
            // nombreCorte
            // 
            this.nombreCorte.HeaderText = "Nombre";
            this.nombreCorte.Name = "nombreCorte";
            this.nombreCorte.ReadOnly = true;
            // 
            // kilosCorte
            // 
            this.kilosCorte.HeaderText = "Kilos Pedidos";
            this.kilosCorte.Name = "kilosCorte";
            this.kilosCorte.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCortesSeleccionados);
            this.groupBox4.Location = new System.Drawing.Point(12, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(995, 201);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cortes Seleccionados";
            // 
            // dgvCortesSeleccionados
            // 
            this.dgvCortesSeleccionados.AllowUserToAddRows = false;
            this.dgvCortesSeleccionados.AllowUserToDeleteRows = false;
            this.dgvCortesSeleccionados.AllowUserToResizeRows = false;
            this.dgvCortesSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortesSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCorteSeleccionado,
            this.kilosCorteSeleccionado,
            this.seccion,
            this.estante,
            this.camara,
            this.kilosAcumulado});
            this.dgvCortesSeleccionados.Location = new System.Drawing.Point(6, 30);
            this.dgvCortesSeleccionados.Name = "dgvCortesSeleccionados";
            this.dgvCortesSeleccionados.ReadOnly = true;
            this.dgvCortesSeleccionados.RowHeadersVisible = false;
            this.dgvCortesSeleccionados.RowTemplate.Height = 24;
            this.dgvCortesSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCortesSeleccionados.Size = new System.Drawing.Size(965, 145);
            this.dgvCortesSeleccionados.TabIndex = 2;
            // 
            // nombreCorteSeleccionado
            // 
            this.nombreCorteSeleccionado.HeaderText = "Nombre";
            this.nombreCorteSeleccionado.Name = "nombreCorteSeleccionado";
            this.nombreCorteSeleccionado.ReadOnly = true;
            // 
            // kilosCorteSeleccionado
            // 
            this.kilosCorteSeleccionado.HeaderText = "Kilos";
            this.kilosCorteSeleccionado.Name = "kilosCorteSeleccionado";
            this.kilosCorteSeleccionado.ReadOnly = true;
            // 
            // seccion
            // 
            this.seccion.HeaderText = "Sección";
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            // 
            // estante
            // 
            this.estante.HeaderText = "Estante";
            this.estante.Name = "estante";
            this.estante.ReadOnly = true;
            // 
            // camara
            // 
            this.camara.HeaderText = "Cámara";
            this.camara.Name = "camara";
            this.camara.ReadOnly = true;
            // 
            // kilosAcumulado
            // 
            this.kilosAcumulado.HeaderText = "Kilos Acumulados";
            this.kilosAcumulado.Name = "kilosAcumulado";
            this.kilosAcumulado.ReadOnly = true;
            // 
            // btnGenerarRemito
            // 
            this.btnGenerarRemito.Location = new System.Drawing.Point(907, 636);
            this.btnGenerarRemito.Name = "btnGenerarRemito";
            this.btnGenerarRemito.Size = new System.Drawing.Size(100, 49);
            this.btnGenerarRemito.TabIndex = 3;
            this.btnGenerarRemito.Text = "Generar Remito";
            this.btnGenerarRemito.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 636);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 49);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmGenerarRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 697);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarRemito);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenerarRemito";
            this.Text = "Generar Remito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesCandidatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSolicitados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSeleccionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn PENombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCortesCandidatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCortesSolicitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilosCorte;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.Button txtAgregarCorte;
        private System.Windows.Forms.Button txtCorte;
        private System.Windows.Forms.Button txtPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCorteDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilosCorteDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaComercializacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCortesSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCorteSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilosCorteSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estante;
        private System.Windows.Forms.DataGridViewTextBoxColumn camara;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilosAcumulado;
        private System.Windows.Forms.Button btnGenerarRemito;
        private System.Windows.Forms.Button btnSalir;
    }
}

