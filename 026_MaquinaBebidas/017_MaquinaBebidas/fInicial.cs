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
    public partial class fInicial : Form
    {
        string[] aLblPrecio = new string[] { "lblCCPrecio", "lblCLPrecio", "lblFNPrecio", "lblFLPrecio", "lblSPPrecio", "lblAQPrecio", "lblAGPrecio" };
        string[] aLblStock = new string[] { "lblCCExistencias", "lblCLExistencias", "lblFNExistencias", "lblFLExistencias", "lblSPExistencias", "lblAQExistencias", "lblAGExistencias" };
        string[] nomeBotons = new string[] { "btCocaCola", "btColaLight", "btFantaNar", "btFantaLim", "btSprite", "btAquarius", "btAquabona" };

        // array,s prezo e stock
        double[] prezoBebidas = new double[] { 0.9, 0.9, 0.85, 0.80, 0.75, 0.70, 0.50 };
        short[] stockBebidas = new short[] { 10, 9, 8, 7, 0, 6, 5 };

        // array,s para monedas e devolución
        double[] valorMoneda = new double[] { 2, 1, 0.50, 0.20, 0.10, 0.05 };
        short[] cajaMonedas = new short[] { 2, 2, 2, 2, 2, 2 };
        short[] cambioMonedas = new short[] { 0, 0, 0, 0, 0, 0 };

        double credito;
        double cambioDevolver;

        public fInicial()
        {
            InitializeComponent();
        }

        private void fInicial_Load(object sender, EventArgs e)
        {
            lblCredito.Text = credito.ToString();
            verPrecioStock();
        }

        private void verPrecioStock()
        {
            foreach (Control cC in Controls)
            {
                if (cC.Name.StartsWith("lbl"))
                {
                    if(Array.IndexOf(aLblPrecio, cC.Name) >= 0)
                    {
                        cC.Text = string.Format("{0:#00.00}", prezoBebidas[Array.IndexOf(aLblPrecio, cC.Name)].ToString()) + " €";
                    }
                }
                else if (cC.Name.StartsWith("bt"))
                {

                }
            }

            foreach (Control cC in Controls)
            {
                if (cC.Name.StartsWith("lbl"))
                {
                    if (Array.IndexOf(aLblStock, cC.Name) >= 0)
                    {
                        cC.Text = string.Format("{0:#00.00}", stockBebidas[Array.IndexOf(aLblStock, cC.Name)].ToString());
                    }
                }
                else if (cC.Name.StartsWith("bt"))
                {

                }
            }
        }

        private void bt2Euros_Click(object sender, EventArgs e)
        { 
            credito += 2;
            lblCredito.Text = credito.ToString();
        }

        private void bt1Euro_Click(object sender, EventArgs e)
        {
            credito += 1;
            lblCredito.Text = credito.ToString();
        }

        private void bt50Centimos_Click(object sender, EventArgs e)
        {
            credito += 0.50;
            lblCredito.Text = credito.ToString();
        }

        private void bt20Centimos_Click(object sender, EventArgs e)
        {
            credito += 0.20;
            lblCredito.Text = credito.ToString();
        }

        private void bt10Centimos_Click(object sender, EventArgs e)
        {
            credito += 0.10;
            lblCredito.Text = credito.ToString();
        }

        private void bt5Centimos_Click(object sender, EventArgs e)
        {
            credito += 0.05;
            lblCredito.Text = credito.ToString();
        }

        private void btRecuperar_Click(object sender, EventArgs e)
        {
            credito = 0;
            lblCredito.Text = credito.ToString();
        }

        private void btCocaCola_Click(object sender, EventArgs e)
        {
            btCocaCola.BackColor = Color.Lime;
        }

        private void btColaLight_Click(object sender, EventArgs e)
        {
            btColaLight.BackColor = Color.Lime;
        }

        private void btFantaNar_Click(object sender, EventArgs e)
        {
            btFantaNar.BackColor = Color.Lime;
        }

        private void btFantaLim_Click(object sender, EventArgs e)
        {
            btFantaLim.BackColor = Color.Lime;
        }

        private void btSprite_Click(object sender, EventArgs e)
        {
            btSprite.BackColor = Color.Lime;
        }

        private void btAquarius_Click(object sender, EventArgs e)
        {
            btAquarius.BackColor = Color.Lime;
        }

        private void btAquabona_Click(object sender, EventArgs e)
        {
            btAquabona.BackColor = Color.Lime;
        }
    }
}

