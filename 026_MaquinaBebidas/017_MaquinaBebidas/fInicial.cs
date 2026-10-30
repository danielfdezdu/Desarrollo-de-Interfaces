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
                if (Array.IndexOf(aLblPrecio, cC.Name) >= 0)
                {
                    cC.Text = string.Format("{0:#0.00}", prezoBebidas[Array.IndexOf(aLblPrecio, cC.Name)].ToString()) + " €";
                }
                else if (Array.IndexOf(aLblStock, cC.Name) >= 0)
                {
                    cC.Text = stockBebidas[Array.IndexOf(aLblStock, cC.Name)].ToString();
                }
                else if (Array.IndexOf(nomeBotons, cC.Name) >= 0)
                {
                    if (stockBebidas[Array.IndexOf(nomeBotons, cC.Name)] == 0)
                    {
                        cC.BackColor = Color.Red;
                        cC.Enabled = false;
                    }
                    else
                    {
                        cC.BackColor = Color.Lime;
                        cC.Enabled = true;
                    }
                }
            }
        }

        private void monedero(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "bt2Euros":
                    credito += 2.00;
                    cajaMonedas[0] += 1;
                    break;
                case "bt1Euro":
                    credito += 1.00;
                    cajaMonedas[0] += 1;
                    break;
                case "bt50Centimos":
                    credito += 0.50;
                    cajaMonedas[0] += 1;
                    break;
                case "bt20Centimos":
                    credito += 0.20;
                    cajaMonedas[0] += 1;
                    break;
                case "bt10Centimos":
                    credito += 0.10;
                    cajaMonedas[0] += 1;
                    break;
                case "bt5Centimos":
                    credito += 0.05;
                    cajaMonedas[0] += 1;
                    break;
            }
            lblCredito.Text = string.Format("{0:#0.00}", credito);
        }

        private void ComprandoBebidas(object sender, EventArgs e)
        {
            int nArrayBotones = Array.IndexOf(nomeBotons, ((Button)sender).Name);

            // revisar crédito
            if (credito >= prezoBebidas[nArrayBotones])
            {
                // hay stock?
                if (stockBebidas[nArrayBotones] > 0)
                {
                    // si hay cambio
                    cambioDevolver = Math.Round(credito - prezoBebidas[nArrayBotones], 2);
                    // mirar si se puede dar cambio

                    if (cambioDevolver == 0)
                    {
                        stockBebidas[nArrayBotones] -= 1;
                        credito = 0;
                        lblCredito.Text = credito.ToString();
                        verPrecioStock();
                        darCambio();
                    } else
                    {
                        lblMensaxe.Text = "Agotado camio";
                    }
                }
                else
                {
                    lblMensaxe.Text = "Agotado producto";
                }
            }
            else
            {
                lblMensaxe.Text = "Crédito insuficiente";
            }
        }

        private void btRecuperar_Click(object sender, EventArgs e)
        {
            lblCredito.Text = "0,00";
            credito = 0.00;
        }

        private void darCambio()
        {
            Array.Clear(cambioMonedas, 0, cambioMonedas.GetLength(0));

            for (int i = 0; i < valorMoneda.GetLength(0);)
            {
                if(valorMoneda[i] <= cambioDevolver && cajaMonedas[i] > 0)
                {
                    cambioDevolver = Math.Round(cambioDevolver - valorMoneda[i], 2);
                    cambioMonedas[i] += 1;
                    cajaMonedas[i] -= 1;
                }
                else
                {
                    i++;
                }
            }
        }

        private void verCambio()
        {
            lsbMonedas.Items.Clear();
            for (int i = 0; i<cambioMonedas.GetLength(0); i++)
            {
                if (cambioMonedas[i] > 0)
                {
                    lsbMonedas.Items.Add(cambioMonedas[i] + "Monedas de " + valorMoneda[i]);
                }
            }
        }

    }
}

