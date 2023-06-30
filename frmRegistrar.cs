using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlesComunesVariables
{
    public partial class frmRegistrar : Form
    {
        frmMostrar ventanaMostrar = new frmMostrar();
        string[] vectorActividad = new string[5];
        string[] vectorRegistroActvidad = new string[5];
        readonly int indiceRegistro = 0;
        int indiceFilaRegistro;
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void lblTipoActividad_Click(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string varTareas = "";
            string varReunion = "";
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstTipoActividad.SelectedIndex != -1)
                {
                    if (optSi.Checked == true)
                    {
                        varReunion = "SI";

                    }
                    else
                    {
                        varReunion = "NO";
                    }
                    if (chkDebate.Checked)
                    {
                        varTareas = "Debate, ";
                    }
                    if (chkInvestigacion.Checked)
                    {
                        varTareas = varTareas + "Investigacion, ";
                    }
                    if (chkNotasReunion.Checked)
                    {
                        varTareas = varTareas + "Notas Reunion, ";
                    }
                    if (chkRepositorio.Checked)
                    {
                        varTareas = varTareas + "Repositorio, ";
                    }
                    if (txtDetalle.Text != "")
                    {

                        MessageBox.Show("Vamos a grabar...");

                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 1] = lstTipoActividad.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 2] = txtDetalle.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 3] = varReunion;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 4] = varTareas;

                     
                        
                        indiceFilaRegistro++;
                        if (indiceFilaRegistro == ventanaMostrar.matrizTareas.GetLength(0))
                        {
                            cmdRegistrar.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta completar el detalle", "Cargar Detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de actividad", "Cargar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstTipoActividad.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fecha actual o posterior a la de hoy", "Cargar fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion bienvenida = new frmInicioDeSesion();
            this.Hide();
            bienvenida.ShowDialog();
        }

        private void cmdVerRegistro_Click(object sender, EventArgs e)
        {
            ventanaMostrar.ShowDialog();
            this.Hide();
        }
    }
}
