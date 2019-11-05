namespace Bravo.GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBomberos = new System.Windows.Forms.DataGridView();
            this.incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bntAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bomberoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBomberos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomberoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(131, 54);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaDesde.TabIndex = 0;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFechaDesde_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(668, 54);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(133, 22);
            this.dtpFechaHasta.TabIndex = 1;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.DtpFechaHasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // dgvBomberos
            // 
            this.dgvBomberos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBomberos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incluir,
            this.nombre,
            this.apellido,
            this.disponibilidad});
            this.dgvBomberos.Location = new System.Drawing.Point(52, 151);
            this.dgvBomberos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBomberos.Name = "dgvBomberos";
            this.dgvBomberos.RowHeadersVisible = false;
            this.dgvBomberos.Size = new System.Drawing.Size(980, 247);
            this.dgvBomberos.TabIndex = 4;
            // 
            // incluir
            // 
            this.incluir.HeaderText = "Incluir";
            this.incluir.Name = "incluir";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // disponibilidad
            // 
            this.disponibilidad.HeaderText = "Disponibilidad";
            this.disponibilidad.Name = "disponibilidad";
            this.disponibilidad.Text = "Disponibilidad";
            this.disponibilidad.UseColumnTextForButtonValue = true;
            // 
            // bntAceptar
            // 
            this.bntAceptar.Location = new System.Drawing.Point(737, 470);
            this.bntAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntAceptar.Name = "bntAceptar";
            this.bntAceptar.Size = new System.Drawing.Size(100, 28);
            this.bntAceptar.TabIndex = 5;
            this.bntAceptar.Text = "Aceptar";
            this.bntAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(885, 470);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // bomberoBindingSource
            // 
            this.bomberoBindingSource.DataSource = typeof(Bravo.Entidades.Bombero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bntAceptar);
            this.Controls.Add(this.dgvBomberos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBomberos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomberoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBomberos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewButtonColumn disponibilidad;
        private System.Windows.Forms.Button bntAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bomberoBindingSource;
    }
}

