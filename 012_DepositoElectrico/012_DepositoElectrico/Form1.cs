using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_DepositoElectrico
{
    public partial class Form1 : Form
    {
        int consumo = 0;
        int consumo2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void cbLavadora_Click(object sender, EventArgs e)
        {
            consumo += 10;
        }

        private void cbCociña_Click(object sender, EventArgs e)
        {
            consumo += 25;
        }

        private void cbPrancha_Click(object sender, EventArgs e)
        {
            consumo += 50;
        }

        private void cbCongelador_Click(object sender, EventArgs e)
        {
            consumo += 100;
        }

        private void cbAire_Click(object sender, EventArgs e)
        {
            consumo += 150;
        }

        private void cbLavadora2_Click(object sender, EventArgs e)
        {
            consumo2 += 10;
        }

        private void cbCociña2_Click(object sender, EventArgs e)
        {
            consumo2 += 25;
        }

        private void cbPlancha2_Click(object sender, EventArgs e)
        {
            consumo2 += 50;
        }

        private void cbCalefaccion2_Click(object sender, EventArgs e)
        {
            consumo2 += 150;
        }

        private void cbConsumo2_Click(object sender, EventArgs e)
        {
            consumo2 += 200;
        }

        private void comprobarConsumo(int consumo, int consumo2)
        {
            if (consumo + consumo2 > 650)
            {
                MessageBox.Show("No se puede consumir más");
            }
            else if (consumo > 300)
            {
                MessageBox.Show("El edificio 1 no puede consumir más");
            }
            else if (consumo2 > 400)
            {
                MessageBox.Show("El edificio 2 no puede consumir más");
            }
            else mostrarConsumo(consumo, consumo2);
        }

        private void mostrarConsumo(int consumo, int consumo2)
        {
            lblValorConsumo.Text = consumo.ToString();
            lblValorConsumo2.Text = consumo2.ToString();
        }
    }
}
