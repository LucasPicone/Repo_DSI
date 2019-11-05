namespace Bravo.GUI
{
    partial class Form2
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBomberoDisp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisponibilidades = new System.Windows.Forms.DataGridView();
            this.txtFechaFinVigencia = new System.Windows.Forms.TextBox();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDesdeDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaHastaDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDesdeGuardia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaHastaGuardia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(783, 502);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(931, 502);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtBomberoDisp
            // 
            this.txtBomberoDisp.Enabled = false;
            this.txtBomberoDisp.Location = new System.Drawing.Point(384, 63);
            this.txtBomberoDisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBomberoDisp.Name = "txtBomberoDisp";
            this.txtBomberoDisp.Size = new System.Drawing.Size(265, 22);
            this.txtBomberoDisp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bombero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vigencia Hasta";
            // 
            // dgvDisponibilidades
            // 
            this.dgvDisponibilidades.AllowUserToAddRows = false;
            this.dgvDisponibilidades.AllowUserToDeleteRows = false;
            this.dgvDisponibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dias,
            this.horaDesdeDisponible,
            this.horaHastaDisponible,
            this.horaDesdeGuardia,
            this.horaHastaGuardia});
            this.dgvDisponibilidades.Location = new System.Drawing.Point(136, 188);
            this.dgvDisponibilidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDisponibilidades.Name = "dgvDisponibilidades";
            this.dgvDisponibilidades.RowHeadersVisible = false;
            this.dgvDisponibilidades.Size = new System.Drawing.Size(895, 286);
            this.dgvDisponibilidades.TabIndex = 6;
            // 
            // txtFechaFinVigencia
            // 
            this.txtFechaFinVigencia.Location = new System.Drawing.Point(384, 102);
            this.txtFechaFinVigencia.Name = "txtFechaFinVigencia";
            this.txtFechaFinVigencia.Size = new System.Drawing.Size(100, 22);
            this.txtFechaFinVigencia.TabIndex = 7;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            // 
            // horaDesdeDisponible
            // 
            this.horaDesdeDisponible.HeaderText = "Hora desde disponible";
            this.horaDesdeDisponible.Name = "horaDesdeDisponible";
            this.horaDesdeDisponible.ReadOnly = true;
            // 
            // horaHastaDisponible
            // 
            this.horaHastaDisponible.HeaderText = "Hora hasta disponible";
            this.horaHastaDisponible.Name = "horaHastaDisponible";
            this.horaHastaDisponible.ReadOnly = true;
            // 
            // horaDesdeGuardia
            // 
            this.horaDesdeGuardia.HeaderText = "Hora desde guardia";
            this.horaDesdeGuardia.Name = "horaDesdeGuardia";
            // 
            // horaHastaGuardia
            // 
            this.horaHastaGuardia.HeaderText = "Hora hasta guardia";
            this.horaHastaGuardia.Name = "horaHastaGuardia";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtFechaFinVigencia);
            this.Controls.Add(this.dgvDisponibilidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBomberoDisp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBomberoDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDisponibilidades;
        private System.Windows.Forms.TextBox txtFechaFinVigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDesdeDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaHastaDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDesdeGuardia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaHastaGuardia;
    }
}