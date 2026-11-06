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
    public partial class f_Monedas : Form
    {
        short[] cajaMonedas;
        NumericUpDown[] aNudMonedas;

        public f_Monedas(short[] cMon)
        {
            this.cajaMonedas = cMon;
            InitializeComponent();
            aNudMonedas = new NumericUpDown[] { nud2Euros, nud1Euro, nud50Centimos, nud20Centimos, nud10Centimos, nud5Centimos};
        }

        private void f_Monedas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cajaMonedas.GetLength(0); i++)
            {
                aNudMonedas[i].Value = cajaMonedas[i];
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cajaMonedas.GetLength(0); i++)
            {
                cajaMonedas[i] = aNudMonedas[i].Value.ToString();
            }
            this.Close();
        }
    }
}
