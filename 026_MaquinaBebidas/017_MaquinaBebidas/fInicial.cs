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

    }
}

