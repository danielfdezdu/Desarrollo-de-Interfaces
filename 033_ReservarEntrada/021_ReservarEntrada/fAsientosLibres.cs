using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_ReservarEntrada
{
    public partial class fAsientosLibres : Form
    {
        public fAsientosLibres(clsGrada grd)
        {
            InitializeComponent();

            this.grada = grd;
        }

        clsGrada grada;


        private void fAsientosLibres_Load(object sender, EventArgs e)
        {
            Reloj.Enabled = true;
        }


        private void Reloj_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < grada.AsientosGrada.Length; i++)
            {
                if (grada.AsientosGrada[i] != null && grada.AsientosGrada[i].Equals("x"))
                    marcar(i);
            }
        }



        private void marcar(int num)
        {
            string letra = encontrarZona(num);

            foreach (Control cC in Controls)
            {
                if (cC.Name.Equals("lbl" + letra + num.ToString()))
                    cC.Text = "X";
            }
        }



        private string encontrarZona(int posicion)
        {
            string letra;

            #region "muy verboso; sustituído por los condicioneles posteriores"
            /*
            if (posicion >= 0 && posicion <= 13)
                letra = "A";
            else if (posicion >= 14 && posicion <= 27)
                letra = "B";
            else if (posicion >= 28 && posicion <= 33)
                letra = "C";
            else if (posicion >= 34 && posicion <= 39)
                letra = "D";
            else if (posicion >= 40 && posicion <= 43)
                letra = "E";
            else if (posicion >= 44 && posicion <= 47)
                letra = "F";
            else if (posicion >= 48 && posicion <= 51)
                letra = "G";
            else
                letra = "H";
            */
            #endregion


            if (posicion >= 52)
                letra = "H";
            else if (posicion >= 48)
                letra = "G";
            else if (posicion >= 44)
                letra = "F";
            else if (posicion >= 40)
                letra = "E";
            else if (posicion >= 34)
                letra = "D";
            else if (posicion >= 28)
                letra = "C";
            else if (posicion >= 14)
                letra = "B";
            else
                letra = "A";


            return letra;
        }



    }
}
