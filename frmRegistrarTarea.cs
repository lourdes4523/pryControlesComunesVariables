using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlesComunesVariables
{
    public partial class frmRegistrarTarea : Form
    {
        public frmRegistrarTarea()
        {
            InitializeComponent();
        }

        //zona de declaracion global para el formulario
        string[] vectorActividad = new string[10];
        //todos los elementos están en NULL

        string[] vectorRegistroActividad = new string[4];

        int indiceRegistro = 0;

        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            //cboTareas.Items.Add("Tarea 1");
            //cboTareas.Items.Add("Tarea 2");
            //cboTareas.Items.Add("Tarea 3");
            //cboTareas.Items.Add("Tarea 4");
            //cboTareas.Items.Add("Tarea 5");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //para obtener el valor del control se usa VALUE
            //TODAY viene de la libreria de .net y toma la fecha del equipo
            if (dtpFecha.Value >= DateTime.Today)
            {
                //Selectedindex es numero que indicar el elemento que tenes seleccionado en el combo
                //si es -1 quiere decir que no hay elemento seleccionado
                if (cboTipoActividad.SelectedIndex != -1)
                {
                    // != "" --- significa distinto de texto vacio
                    if (txtDetalle.Text != "")
                    {
                        //MessageBox.Show("Vamos a grabar...");

                        vectorRegistroActividad[indiceRegistro] =
                            dtpFecha.Value + " " +
                            cboTipoActividad.Text + " " +
                            txtDetalle.Text;

                        indiceRegistro++;
                    }
                    else
                    {
                        MessageBox.Show("te falta completa el detalle...");
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad...");
                    cboTipoActividad.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void cmdVerVector_Click(object sender, EventArgs e)
        {
            // //recorrer un vector
            // vectorActividad[2] = "programar";

            // //mostre un dato que no sea null
            //// listBox1.Items.Add(vectorActividad[0]);
            // listBox1.Items.Add(vectorActividad[2]);

            //recorrer un vector de inicio a fin
            int indice = 0;

            while (indice <= 9)
            {
                listBox1.Items.Add(vectorActividad[indice]);


                indice = indice + 1;
            }
        }

       
        private void btnCargarVector_Click(object sender, EventArgs e)
        {
            //recorrer un vector de inicio a fin
            int indice = 0;

            while (indice <= 9)
            {
                vectorActividad[indice] = "Posición del índice " + indice;

                indice = indice + 1;
            }
        }

        private void btnVerVector2_Click(object sender, EventArgs e)
        {
            int indice = 0;

            while (indice < vectorActividad.Length)
            {
                listBox1.Items.Add(vectorActividad[indice]);

                indice++;
            }
        }

        private void btnVerVector3_Click(object sender, EventArgs e)
        {
            for (int indice = 0; indice < vectorActividad.Length; indice++)
            {
                listBox1.Items.Add(vectorActividad[indice]);
            }
        }
    }
}