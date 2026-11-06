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
    public partial class fSec_Uno : Form
    {
        int[] aNum;
        string nombre;

        public fSec_Uno(int[] aN, string nome)
        {
            this.aNum = aN;
            this.nombre = nome;
            InitializeComponent();
        }

        private void btIr_a_Sec_Dos_Click(object sender, EventArgs e)
        {
            fSec_Dos fSDos = new fSec_Dos();
            fSDos.ShowDialog();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            aNum[1] = 2222;
            aNum[2] = 3333;
            nombre = "PEDRO";

            this.Close();
        }

        private void fSec_Uno_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < aNum.GetLength(0); i++)
            {
                listBox1.Items.Add(aNum[i]);
            }
            listBox1.Items.Add(nombre);

        }
    }
}
