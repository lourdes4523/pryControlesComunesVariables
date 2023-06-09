namespace pryControlesComunesVariables
{
    partial class frmRegistrarTarea
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtBDetalle = new System.Windows.Forms.TextBox();
            this.gbReunion = new System.Windows.Forms.GroupBox();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.gbReunion.SuspendLayout();
            this.gbTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(35, 42);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(219, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new System.Drawing.Point(32, 103);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(28, 13);
            this.lblTipoActividad.TabIndex = 2;
            this.lblTipoActividad.Text = "Tipo";
            // 
            // cboTipoActividad
            // 
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Location = new System.Drawing.Point(34, 119);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(219, 21);
            this.cboTipoActividad.TabIndex = 3;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(31, 171);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle";
            // 
            // txtBDetalle
            // 
            this.txtBDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDetalle.Location = new System.Drawing.Point(35, 187);
            this.txtBDetalle.MinimumSize = new System.Drawing.Size(18, 18);
            this.txtBDetalle.Multiline = true;
            this.txtBDetalle.Name = "txtBDetalle";
            this.txtBDetalle.Size = new System.Drawing.Size(219, 91);
            this.txtBDetalle.TabIndex = 5;
            // 
            // gbReunion
            // 
            this.gbReunion.Controls.Add(this.optNo);
            this.gbReunion.Controls.Add(this.optSi);
            this.gbReunion.Location = new System.Drawing.Point(34, 298);
            this.gbReunion.Name = "gbReunion";
            this.gbReunion.Size = new System.Drawing.Size(219, 76);
            this.gbReunion.TabIndex = 6;
            this.gbReunion.TabStop = false;
            this.gbReunion.Text = "Reunion";
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Location = new System.Drawing.Point(17, 38);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(34, 17);
            this.optSi.TabIndex = 7;
            this.optSi.TabStop = true;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(108, 38);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(39, 17);
            this.optNo.TabIndex = 8;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.chkNotasReunion);
            this.gbTareas.Controls.Add(this.chkDebate);
            this.gbTareas.Controls.Add(this.chkInvestigacion);
            this.gbTareas.Controls.Add(this.chkRepositorio);
            this.gbTareas.Location = new System.Drawing.Point(34, 393);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Size = new System.Drawing.Size(219, 90);
            this.gbTareas.TabIndex = 7;
            this.gbTareas.TabStop = false;
            this.gbTareas.Text = "Tareas";
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(6, 19);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkRepositorio.TabIndex = 8;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(5, 42);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 8;
            this.chkInvestigacion.Text = "Investigacion";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.Location = new System.Drawing.Point(91, 19);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(80, 17);
            this.chkDebate.TabIndex = 0;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(91, 42);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(97, 17);
            this.chkNotasReunion.TabIndex = 8;
            this.chkNotasReunion.Text = "Notas Reunion";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 523);
            this.Controls.Add(this.gbTareas);
            this.Controls.Add(this.gbReunion);
            this.Controls.Add(this.txtBDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrarTarea";
            this.Text = "Registrar Actividad";
            this.gbReunion.ResumeLayout(false);
            this.gbReunion.PerformLayout();
            this.gbTareas.ResumeLayout(false);
            this.gbTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.ComboBox cboTipoActividad;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtBDetalle;
        private System.Windows.Forms.GroupBox gbReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.GroupBox gbTareas;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
    }
}