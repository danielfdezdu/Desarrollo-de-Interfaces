using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Telefono
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            double totalSegundos = 0;
            double totalImporte = 0;

            if (nudMinutos.Value == 0 && nudSegundos.Value == 0)
            {
                MessageBox.Show("o valor de minutos e segundos non pode ser -0-");
            } else
            {
                if (nudMinutos.Value == 0)
                {
                    totalSegundos = 60;
                } else
                {
                    totalSegundos = (int)nudSegundos.Value + Convert.ToInt32(nudMinutos.Value) * 60;
                }
            }

            if (rbLocal.Checked) totalImporte = totalSegundos * 0.05 / 60;
            else if (rbProvincial.Checked) totalImporte = totalSegundos * 0.06 / 60;
            else if (rbNacional.Checked) totalImporte = totalSegundos * 0.09 / 60;
            else if (rbMobil.Checked) totalImporte = totalSegundos * 0.15 / 60;

            if (!cbChamada.Checked) totalImporte += 0.10;

            if (cbTarifa.Checked) totalImporte *= 0.60;

            lblResultado.Text = string.Format("{0:##,##0.00}",totalImporte);
            
        }
    }
}
