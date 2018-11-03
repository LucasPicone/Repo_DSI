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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarCorte = new System.Windows.Forms.Button();
            this.btnCorte = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCortesCandidatos = new System.Windows.Forms.DataGridView();
            this.nombreCorteDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilosCorteDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaComercializacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCortesSolicitados = new System.Windows.Forms.DataGridView();
            this.detallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tipoCorteVacunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kilosCorteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesCandidatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSolicitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCorteVacunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.fechaPedidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(983, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            this.fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.HeaderText = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            this.fechaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(ImplementacionDSI.Pedido);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregarCorte);
            this.groupBox1.Controls.Add(this.btnCorte);
            this.groupBox1.Controls.Add(this.btnPedido);
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(363, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(238, 73);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCorte
            // 
            this.btnAgregarCorte.Enabled = false;
            this.btnAgregarCorte.Location = new System.Drawing.Point(363, 270);
            this.btnAgregarCorte.Name = "btnAgregarCorte";
            this.btnAgregarCorte.Size = new System.Drawing.Size(238, 30);
            this.btnAgregarCorte.TabIndex = 6;
            this.btnAgregarCorte.Text = "Agregar Corte";
            this.btnAgregarCorte.UseVisualStyleBackColor = true;
            // 
            // btnCorte
            // 
            this.btnCorte.Enabled = false;
            this.btnCorte.Location = new System.Drawing.Point(363, 234);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(238, 30);
            this.btnCorte.TabIndex = 5;
            this.btnCorte.Text = "Seleccionar Corte";
            this.btnCorte.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(363, 198);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(238, 30);
            this.btnPedido.TabIndex = 4;
            this.btnPedido.Text = "Seleccionar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
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
            this.dgvCortesSolicitados.AutoGenerateColumns = false;
            this.dgvCortesSolicitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortesSolicitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kilosCorteDataGridViewTextBoxColumn});
            this.dgvCortesSolicitados.DataSource = this.detallePedidoBindingSource;
            this.dgvCortesSolicitados.Location = new System.Drawing.Point(6, 21);
            this.dgvCortesSolicitados.Name = "dgvCortesSolicitados";
            this.dgvCortesSolicitados.ReadOnly = true;
            this.dgvCortesSolicitados.RowHeadersVisible = false;
            this.dgvCortesSolicitados.RowTemplate.Height = 24;
            this.dgvCortesSolicitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCortesSolicitados.Size = new System.Drawing.Size(310, 196);
            this.dgvCortesSolicitados.TabIndex = 1;
            // 
            // detallePedidoBindingSource
            // 
            this.detallePedidoBindingSource.DataSource = typeof(ImplementacionDSI.DetallePedido);
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
            // tipoCorteVacunoBindingSource
            // 
            this.tipoCorteVacunoBindingSource.DataSource = typeof(ImplementacionDSI.TipoCorteVacuno);
            // 
            // kilosCorteDataGridViewTextBoxColumn
            // 
            this.kilosCorteDataGridViewTextBoxColumn.DataPropertyName = "KilosCorte";
            this.kilosCorteDataGridViewTextBoxColumn.HeaderText = "KilosCorte";
            this.kilosCorteDataGridViewTextBoxColumn.Name = "kilosCorteDataGridViewTextBoxColumn";
            this.kilosCorteDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesCandidatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSolicitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortesSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCorteVacunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCortesCandidatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCortesSolicitados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarCorte;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnPedido;
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
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detallePedidoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilosCorteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoCorteVacunoBindingSource;
    }
}

