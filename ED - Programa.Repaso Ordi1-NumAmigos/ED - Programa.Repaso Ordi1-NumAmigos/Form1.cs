using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED___Programa.Repaso_Ordi1_NumAmigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            /*
             Crear programa que utilizando un metodo de fuerza bruta evalue todas las combinaciones de pares 
             de numeros entre 2 y 3000 y muestre todas las parejas de numeros amigos.
             Una pareja de numero a,b son amigos si la suma de divisores del numero a (sin contar a ) sumen b 
             y la suma de los divisores del numero b (sin contar b) sumen a y además a y b sean diferentes.
             */

            //txtMostrar.Text = sumaDivisores(12).ToString();
            for (int i = 2; i <= 3000; i++)
            {
                for (int j = i + 1; j <= 3000; j++)
                {
                    if (sonAmigos(i, j))
                        txtMostrar.Text += i.ToString() + ", " + j.ToString() + Environment.NewLine;
                }
            }
        }

        private int sumaDivisores(int numero)
        {
            int suma = 0;
            for (short i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                    suma += i;
            }
            return suma;
        }

        private bool sonAmigos(int numero1, int numero2)
        {
            if (sumaDivisores(numero1) == numero2 && sumaDivisores(numero2) == numero1)
                return true;
            else
                return false;
        }
    }
}
