namespace pryControlesComunesVariables
{
    partial class frmMostrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdIrARegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registro de Actividades";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFecha,
            this.dgvTipo,
            this.dgvDetalle,
            this.dgvReunion,
            this.dgvTareas});
            this.dgvMostrar.Location = new System.Drawing.Point(12, 66);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(545, 294);
            this.dgvMostrar.TabIndex = 16;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
            // 
            // dgvFecha
            // 
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.Name = "dgvFecha";
            // 
            // dgvTipo
            // 
            this.dgvTipo.HeaderText = "Tipo";
            this.dgvTipo.Name = "dgvTipo";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.HeaderText = "Detalle";
            this.dgvDetalle.Name = "dgvDetalle";
            // 
            // dgvReunion
            // 
            this.dgvReunion.HeaderText = "Reunion";
            this.dgvReunion.Name = "dgvReunion";
            // 
            // dgvTareas
            // 
            this.dgvTareas.HeaderText = "Tareas";
            this.dgvTareas.Name = "dgvTareas";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCancelar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(162, 400);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(89, 23);
            this.cmdCancelar.TabIndex = 17;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // cmdIrARegistro
            // 
            this.cmdIrARegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIrARegistro.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIrARegistro.Location = new System.Drawing.Point(273, 400);
            this.cmdIrARegistro.Name = "cmdIrARegistro";
            this.cmdIrARegistro.Size = new System.Drawing.Size(89, 23);
            this.cmdIrARegistro.TabIndex = 18;
            this.cmdIrARegistro.Text = "Ir a registro";
            this.cmdIrARegistro.UseVisualStyleBackColor = false;
            this.cmdIrARegistro.Click += new System.EventHandler(this.cmdIrARegistro_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdIrARegistro);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.label1);
            this.Name = "frmMostrar";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTareas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdIrARegistro;
    }
}