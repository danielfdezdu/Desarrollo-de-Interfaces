using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_PasoValorPasoPreferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Paso valor
        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = 10, N2 = 20;
            lblN1.Text = N1.ToString();
            lblN2.Text = N2.ToString();

            pasoxValor(N1, N2);

            lblN1x.Text = N1.ToString();
            lblN2x.Text = N2.ToString();
        }

        private void pasoxValor(int a, int b)
        {
            a++;
            b++;
        }

        // Paso referencia
        private void button2_Click(object sender, EventArgs e)
        {
            int N3 = 30, N4 = 40;
            lblN3.Text = N3.ToString();
            lblN4.Text = N4.ToString();

            pasoxReferencia(ref N3, ref N4);

            lblN3x.Text = N3.ToString();
            lblN4x.Text = N4.ToString();
        }

        private void pasoxReferencia(ref int a, ref int b)
        {
            a++;
            b++;
        }

    }
}
