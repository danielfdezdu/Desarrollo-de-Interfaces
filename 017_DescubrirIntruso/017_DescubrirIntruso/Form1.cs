using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_DescubrirIntruso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[,] array = new String[6, 6];
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = "*";
                }
            }
            verContArray();
        }

        private void verContArray()
        {
            foreach (Control cC in gbxEtiquetas.Controls)
            {
                int fila = Convert.ToInt32(cC.Name.Substring(3, 1));
                int colu = Convert.ToInt32(cC.Name.Substring(4, 1));

                cC.Text = array[fila, colu];
            }
        }

        private void btAgachar_Click(object sender, EventArgs e)
        {
            int rFila = 0, rColu = 0;

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                rFila = r.Next(6);
                rColu = r.Next(6);
                if (array[rFila, rColu] == "*")
                {
                    array[rFila, rColu] = textBox1.Text;
                    i++;
                }
            }
            verContArray();
            btAgachar.Enabled = false;
            btDescubrir.Enabled = true;
        }

        private void btDescubrir_Click(object sender, EventArgs e)
        {
            int rFila = 0, rColu = 0, intentos = 0;

            for (int i = 0; i < numericUpDown1.Value;)
            {
                rFila = r.Next(6);
                rColu = r.Next(6);
                intentos++;
                if (array[rFila, rColu] == textBox1.Text)
                {
                    listBox.Items.Add("intruso en " + rFila + ", " + rColu);
                    array[rColu, rColu] = "*";
                    i++;
                }
            }
            lblNumeroIntentos.Text = "nº intentos " + intentos;
            btDescubrir.Enabled = false;
        }


    }
}
