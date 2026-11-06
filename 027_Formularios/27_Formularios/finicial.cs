using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Formularios
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        int[] aNumeros = new int[] { 10, 20, 30, 40, 50 };
        string nome = "JUAN";

        private void btIr_a_Sec_Uno_Click(object sender, EventArgs e)
        {
            fSec_Uno fSUno = new fSec_Uno(aNumeros, nome);
            fSUno.ShowDialog();

            for (int i = 0; i < aNumeros.GetLength(0); i++)
            {
                listBox2.Items.Add(aNumeros[i]);
            }
        }

        private void fInicial_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < aNumeros.GetLength(0); i++)
            {
                listBox1.Items.Add(aNumeros[i]);
            }
        }
    }
}
