using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Numero = 0;

        // int[] aNumeros = new int[5];

        int[] aNumeros = new int[5];

        // int[] aNumeros = { 10, 9, 11, 7, 4 };

        private void btEngadir_Click(object sender, EventArgs e)
        {
            if (Numero < 5)
            {
                aNumeros[Numero] = Convert.ToInt32(textBox1.Text);
                Numero++;
            } else
            {
                MessageBox.Show("indice maior dos límites do Array");
                btEngadir.Enabled = false;
                tbNumeros.Enabled = false;
            }

            tbNumeros.Text = "";
            tbNumeros.Focus();

            verArray();
        }

        private void verArray()
        {
            for (int i=0; i<5; i++)
            {
                tbNumeros.Items.Add(aNumeros[i]);
            }
        }
    }
}
