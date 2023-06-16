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
            this.gbReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdVerVector = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.cboTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Items.AddRange(new object[] {
            "tarea 11",
            "tarea 12",
            "tarea 13",
            "tarea 14",
            "tarea 15"});
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
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(91, 42);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(97, 17);
            this.chkNotasReunion.TabIndex = 8;
            this.chkNotasReunion.Text = "Notas Reunión";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
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
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(5, 42);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 8;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
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
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(35, 199);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(218, 86);
            this.txtDetalle.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(66, 488);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(167, 488);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cargar Vector";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCargarVector_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(351, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 134);
            this.listBox1.TabIndex = 14;
            // 
            // cmdVerVector
            // 
            this.cmdVerVector.Location = new System.Drawing.Point(351, 71);
            this.cmdVerVector.Name = "cmdVerVector";
            this.cmdVerVector.Size = new System.Drawing.Size(179, 45);
            this.cmdVerVector.TabIndex = 15;
            this.cmdVerVector.Text = "Ver Vector";
            this.cmdVerVector.UseVisualStyleBackColor = true;
            this.cmdVerVector.Click += new System.EventHandler(this.cmdVerVector_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ver Vector prop Array";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnVerVector2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Ver Vector For";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnVerVector3_Click);
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 523);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdVerVector);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.gbTareas);
            this.Controls.Add(this.gbReunion);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrarTarea";
            this.Text = "Registrar Actividad";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
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
        private System.Windows.Forms.GroupBox gbReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.GroupBox gbTareas;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdVerVector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}