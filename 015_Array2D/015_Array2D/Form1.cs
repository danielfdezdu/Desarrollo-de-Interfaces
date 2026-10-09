using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_Array2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] aPrezos = new int[30];
        int[,] aArtigos = new int[6,5];
        Random r = new Random();

        private void btCargar_Click(object sender, EventArgs e)
        {
            int rFila = 0, rColu = 0, intentos = 0;

            for (int i = 1; i <= 30; i++)
            {
                rFila = r.Next(6);
                rColu = r.Next(5);
                intentos++;
                lblIntentos.Text = intentos.ToString();

                if (aArtigos[rFila, rColu] == 0)
                {
                    aArtigos[rFila, rColu] = i;
                    pbBarra.Value++;
                    lblColocar.Text = string.Format("colocados {0} de 30", pbBarra.Value);
                }
                else
                {
                    i--;
                }
                System.Threading.Thread.Sleep(150);
                lblIntentos.Refresh();
                lblColocar.Refresh();
            }
            btCargar.Enabled = false;
            btContido.Enabled = true;

        }
            
        private void btContido_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < aArtigos.GetLength(0); f++)
            {
                for (int c = 0; c < aArtigos.GetLength(1); c++)
                {
                    lbxLista.Items.Add(string.Format("posición {0}{1} artigo {2} prezo {3})",
                                                     f,
                                                     c,
                                                     aArtigos[f, c],
                                                     aPrezos[aArtigos[f,c]-1]));
                }
            }
        }
    }
}
