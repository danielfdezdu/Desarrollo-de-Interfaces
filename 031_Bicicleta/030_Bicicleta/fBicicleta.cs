using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030_Bicicleta
{
        public partial class fBicicleta : Form
        {
            public fBicicleta()
            {
                InitializeComponent();
            }

            clsBicicleta oBicicleta = new clsBicicleta("Orbea", "Montaña");

            private void btnVerMarca_Click(object sender, EventArgs e)
            {
                lblMarca.Text = oBicicleta.Marca;
                lblModelo.Text = oBicicleta.Modelo;
                // oBicicleta.Marca = "Shimano";
            }

            private void btnAcelerar_Click(object sender, EventArgs e)
            {
                oBicicleta.Acelerar(1);
                lblVelocidad.Text = oBicicleta.Velocidad.ToString();
            }

            private void btnSprint_Click(object sender, EventArgs e)
            {
                oBicicleta.Acelerar(5);
                lblVelocidad.Text = oBicicleta.Velocidad.ToString();
            }

            private void btnFrenar_Click(object sender, EventArgs e)
            {
                oBicicleta.Frenar(1);
                lblVelocidad.Text = oBicicleta.Velocidad.ToString();
            }

            private void btnFrenarF_Click(object sender, EventArgs e)
            {
                oBicicleta.Frenar(5);
                lblVelocidad.Text = oBicicleta.Velocidad.ToString();
            }
        }
}

