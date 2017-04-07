using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED___Programa_Repaso_Ordi1
{
    public partial class Form1 : Form
    {
        int[] vector;
        Random random = new Random(DateTime.Now.Millisecond);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            vector = new int[int.Parse(txtTamaño.Text)];
            for(short i = 0; i < vector.Length; i++)
                vector[i] = random.Next(1, 100);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Clear();
            for (short i = 0; i < vector.Length; i++)
                txtMostrar.Text += vector[i].ToString() + Environment.NewLine;
        }

        private void btnevVector_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = evaluarOrden(vector).ToString();
        }

        private int evaluarOrden(int[] vector)
        {
            //for (short i = 0; i < vector.Length - 1; i++)
            //{
            //    if (!(vector[i] < vector[i + 1]))
            //        break;
            //    if (i == vector.Length - 2)
            //        return 1;
            //}
            //for (short i = 0; i < vector.Length - 1; i++)
            //{
            //    if (!(vector[i] > vector[i + 1]))
            //        break;
            //    if (i == vector.Length - 2)
            //        return -1;
            //}
            //return 0;
            short i = 0;
            while (i < vector.Length - 1 && vector[i] < vector[i + 1])
                i++;
            if (i == vector.Length - 1)
                return 1;
            else
            {
                i = 0;
                while (i < vector.Length - 1 && vector[i] > vector[i + 1])
                    i++;
                if (i == vector.Length - 1)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
