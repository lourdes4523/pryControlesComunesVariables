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
    public partial class frmRegistroMatriz : Form
    {
        String[,] matrizDatos = new string[5, 3];

        public frmRegistroMatriz()
        {
            InitializeComponent();
        }

        private void frmRegistroMatriz_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarVector_Click(object sender, EventArgs e)
        {
            int indiceFila, indiceColumna = 0;


            indiceFila = 0;
            while (indiceFila < matrizDatos.GetLength(0))
            {
                while (indiceColumna<matrizDatos.GetLength(1))
                {

                   matrizDatos[indiceFila, indiceColumna] = "Fila:" + indiceFila + "columna:" + indiceColumna;


                    indiceColumna++;
                }
                
                indiceFila++;
            }
        }
    }
}
