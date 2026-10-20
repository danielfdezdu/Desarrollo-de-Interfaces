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
            else if (((Button)sender).Name == "bt1")
            {
                nXogadas += 10;
            }
            else if (((Button)sender).Name == "bt2")
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
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            nFruta1 = r.Next(9);
            pbFruta1.Image = Image.FromFile("D:\\Daniel_Fernández\\Desarrollo-de-Interfaces\\imagenes_tragaperras" + aFrutas[]);
            nFruta2 = r.Next(9);
            pbFruta2.Image = Image.FromFile("D:\\Daniel_Fernández\\Desarrollo-de-Interfaces\\imagenes_tragaperras" + aFrutas[]);
            nFruta3 = r.Next(9);
            pbFruta3.Image = Image.FromFile("D:\\Daniel_Fernández\\Desarrollo-de-Interfaces\\imagenes_tragaperras" + aFrutas[]);

        }
    }
}
