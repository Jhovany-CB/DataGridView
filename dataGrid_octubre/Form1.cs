using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGrid_octubre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            dg1.Rows.Add(6);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            dg1.Rows.Add(txtCodigo.Text,txtNombre.Text,txtEdad.Text);
        }

        private void btnAgregarFilas_Click(object sender, EventArgs e)
        {
            //dg1.RowCount = 3;
            dg1.ColumnCount = 5; //agrega filas ya existente, no añade demas


        }

        private void btnValorCelda_Click(object sender, EventArgs e)
        {

            dg1[1, 2].Value = txtCodigo.Text;//cambio de valor
        }

        private void btnObtenerValor_Click(object sender, EventArgs e)
        {
            string x = dg1[1, 2].Value.ToString();
            MessageBox.Show(x);
        }

        private void btnValorCeldaSeleccionada_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dg1.CurrentCell.Value.ToString());
        }

        private void btnCoordenadas_Click(object sender, EventArgs e)
        {
            int posx = Convert.ToUInt16(dg1.CurrentCellAddress.X);
            int posy = Convert.ToUInt16(dg1.CurrentCellAddress.Y);
            MessageBox.Show($"{posx}-{posy}");
        }

        private void btnCantidadFilasColumnas_Click(object sender, EventArgs e)
        {
            int x = dg1.RowCount;
            int y = dg1.RowCount;
            MessageBox.Show($"{x},{y}");
        }

        private void btnLlenarMatriz_Click(object sender, EventArgs e)
        {
            int[,] datos = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            dg1.RowCount = 3;
            dg1.ColumnCount = 3;
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    dg1[j,i].Value=datos[i,j];
                }
            }
        }
    }
}
