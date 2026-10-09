using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo02
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        private void btCambiarSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola Mundoooooo";
        }

        private void Cuando_Paso_Raton_x_Encima_Etiqueta(object sender, EventArgs e)
        {
            lblSaludo.BackColor = Color.Orange;
            lblSaludo.ForeColor = Color.White;
        }

        private void Cuando_el_Raton_Abandona_Etiqueta(object sender, EventArgs e)
        {
            lblSaludo.BackColor = Color.SpringGreen;
            lblSaludo.ForeColor = Color.Black;
        }
    }
}
