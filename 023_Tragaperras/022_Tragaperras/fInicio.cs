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

       
    }
}
