using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatallaNaval
{
    public partial class fBatallaNaval : Form
    {
        public fBatallaNaval()
        {
            InitializeComponent();
        }

        int[] aTipoBarco = new int[] { 4, 3, 2, 2, 1, 1 };
        int[,] aBarcos;

        Random r = new Random();

        private void btColocarNaves_Click(object sender, EventArgs e)
        {
            aBarcos = new int[8, 8];
            int rFila = 0, rColu = 0, rHV = 0;

            for (int i = 0; i < aTipoBarco.GetLength(0);)
            {
                rHV = r.Next(0, 2); //0 horizontal 1 vertical
                rFila = r.Next(0, 8);
                rColu = r.Next(0, 8);
                bool vacio = false;

                if (rHV == 0) //colocamos en horizontal
                {
                    if ((rColu + aTipoBarco[i]) <= aBarcos.GetLength(1))
                    {
                        for (int x = rColu; x < rColu + aTipoBarco[i]; x++)
                        {
                            if (aBarcos[rFila, x] == 0)
                            {
                                vacio = true;
                            }
                            else
                            {
                                vacio = false;
                                break;
                            }
                        }
                    }
                    if (vacio == true)
                    {
                        for (int x = rColu; x < rColu + aTipoBarco[i]; x++)
                        {
                            aBarcos[rFila, x] = aTipoBarco[i];
                        }
                        i++;
                    }
                }
                else //colocamos en vertical
                {
                    if ((rColu + aTipoBarco[i]) < aBarcos.GetLength(1))
                    {

                    }
                }

            }
            verBarcos();
        }

        private void verBarcos()
        {
            foreach (Control cC in groupBox1.Controls)
            {
                if (cC.Name.StartsWith("lblEnemigo"))
                {
                    int fi = Convert.ToInt32(cC.Name.Substring(10, 1));
                    int co = Convert.ToInt32(cC.Name.Substring(11, 1));
                    cC.Text = aBarcos[fi, co].ToString();

                    switch (aBarcos[fi, co])
                    {
                        case 4:
                            cC.BackColor = Color.Red;
                            break;
                        case 3:
                            cC.BackColor = Color.Orange;
                            break;
                        case 2:
                            cC.BackColor = Color.Green;
                            break;
                        case 1:
                            cC.BackColor = Color.Blue;
                            break;
                        case 0:
                            cC.BackColor = Color.White;
                            break;
                    }
                }
            }
        }
    }
}