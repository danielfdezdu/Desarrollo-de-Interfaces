using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_Tragaperras
{
    public partial class fInicio : Form
    {
        public fInicio()
        {
            InitializeComponent();
        }


        string[] aFrutas = new string[9]
        {"cereza.jpg",
         "ciruela.jpg",
         "fresa.jpg",
         "limon.jpg",
         "manzana.jpg",
         "melon.jpg",
         "naranja.jpg",
         "piña.jpg",
         "platano.jpg"
        };
        
      
        Random r = new Random();

        int nXogadas = 0;
        int nFruta1 = 0;
        int nFruta2 = 0;
        int nFruta3 = 0;
        int premio = 0;

        private void Monedero(object sender, EventArgs e)
        {
            
            if (((Button)sender).Name == "bt20")
            {
                nXogadas += 2;
            }
            else if (((Button)sender).Name == "bt50")
            {
                nXogadas += 5;
            }
            else if (((Button)sender).Name == "bt01")
            {
                nXogadas += 10;
            }
            else if (((Button)sender).Name == "bt02")
            {
                nXogadas += 20;
            }

            lblXogadas.Text = nXogadas.ToString();
            btXogar.Enabled = true;
        }

        private void btXogar_Click(object sender, EventArgs e)
        {
            nXogadas--;
            lblXogadas.Text = nXogadas.ToString();

            temporizador.Enabled = true;
            btXogar.Enabled = false;
            btDeter.Enabled = true;
            gbxMonedas.Enabled = false;
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            nFruta1 = r.Next(9);
            pbFruta1.Image = Image.FromFile("D:\\Daniel_Fernandez\\Desarrollo-de-Interfaces\\imagenes_tragaperras\\" + aFrutas[nFruta1]);
            nFruta2 = r.Next(9);
            pbFruta2.Image = Image.FromFile("D:\\Daniel_Fernandez\\Desarrollo-de-Interfaces\\imagenes_tragaperras\\" + aFrutas[nFruta2]);
            nFruta3 = r.Next(9);
            pbFruta3.Image = Image.FromFile("D:\\Daniel_Fernandez\\Desarrollo-de-Interfaces\\imagenes_tragaperras\\" + aFrutas[nFruta3]);

        }

        private void btDeter_Click(object sender, EventArgs e)
        {
            temporizador.Enabled = false;
            // revisar premios

            if (nFruta1 == 0 && nFruta2 == 0 && nFruta3 == 0) premio += 50;
            else if (nFruta1 == 0 && nFruta2 == nFruta3) premio += 10;
            else if (nFruta1 == nFruta2 || nFruta2 == nFruta3) premio += 5;
            else if (nFruta1 == nFruta3) premio += 2;

            lblPremio.Text = premio.ToString();

            if (premio > 0)
            {
                btCobrarAcumulado.Enabled = true;
                btAcumular.Enabled = true;
            }

            // cambiar estado botones
            if (nXogadas > 0)
            {
                btXogar.Enabled = true;
            }
            else
            {
                btXogar.Enabled = true;
            }

            btXogar.Enabled = true;
            btDeter.Enabled = false;
            gbxMonedas.Enabled = true;
        }

        private void btCobrarPremio_Click(object sender, EventArgs e)
        {

        }

        private void btAcumular_Click(object sender, EventArgs e)
        {

        }

        private void btCobrarAcumulado_Click(object sender, EventArgs e)
        {

        }

        private void btConvertir_Click(object sender, EventArgs e)
        {

        }
    }
}
