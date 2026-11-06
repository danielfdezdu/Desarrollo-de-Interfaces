using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_MaquinaBebidas
{
    public partial class f_Precios : Form
    {
        double[] aPrezosBebidas;

        public f_Precios(double[] Precios)
        {
            this.aPrezosBebidas = Precios;
            InitializeComponent();
        }

        TextBox[] aTextBox;

        private void f_Precios_Load(object sender, EventArgs e)
        {
            aTextBox = new TextBox[] { txbCocaCola, txbColaLight, txbFanNar, txbFanLim, txbSprite, txbAquarius, txbAquabona };

            for (int i = 0; i < aPrezosBebidas.GetLength(0); i++)
            {
                aTextBox[i].Text = string.Format("{0:#0.00}", aPrezosBebidas[i]);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aPrezosBebidas.GetLength(0); i++)
            {
                aPrezosBebidas[i] = Convert.ToDouble(aTextBox[i].Text);
            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
