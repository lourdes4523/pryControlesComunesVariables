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
    public partial class frmMostrar : Form
    {
        public string[,] matrizTareas = new string[5, 5];
        int indiceFilaRegistro, indiceColumna;

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Hide();
            principal.ShowDialog();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            indiceFilaRegistro = 0;
            indiceColumna = 0;
            while (indiceFilaRegistro < matrizTareas.GetLength(0))
            {
                dgvMostrar.Rows.Add(matrizTareas[indiceFilaRegistro, 0],
                    matrizTareas[indiceFilaRegistro, 1], matrizTareas[indiceFilaRegistro, 2],
                    matrizTareas[indiceFilaRegistro, 3], matrizTareas[indiceFilaRegistro, 4]);
                indiceFilaRegistro++;
            }
        }

        private void cmdIrARegistro_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            this.Hide();
            registrar.ShowDialog();
        }

        public frmMostrar()
        {
            InitializeComponent();
        }
    } 
}
