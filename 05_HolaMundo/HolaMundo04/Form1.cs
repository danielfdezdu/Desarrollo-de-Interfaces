using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            lblSaludo.Font = new Font("Arial", lblSaludo.Font.Size +1);
            comprobarFuente();
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            lblSaludo.Font = new Font("Arial", lblSaludo.Font.Size -1);
            comprobarFuente();
        }

        private void rbAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            lblSaludo.BackColor = Color.Yellow;
        }

        private void rbRojo_CheckedChanged(object sender, EventArgs e)
        {
            lblSaludo.BackColor = Color.Red;
        }

        private void rbVerde_CheckedChanged(object sender, EventArgs e)
        {
            lblSaludo.BackColor = Color.Green;
        }

        private void comprobarFuente()
        {
            if (lblSaludo.Font.Size > 30)
            {
                btMas.Enabled = false;
            }
            else if (lblSaludo.Font.Size < 10)
            {
                btMenos.Enabled = false;
            }
            else
            {
                btMas.Enabled = true;
                btMenos.Enabled = true;
            }
        }

    }
}
