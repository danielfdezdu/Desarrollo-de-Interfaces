using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo01
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        private void fInicial_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "Adios Mundo";
            lblSaludo.BackColor = Color.Coral;
            lblSaludo.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola Mundo";
        }

        
    }
}
