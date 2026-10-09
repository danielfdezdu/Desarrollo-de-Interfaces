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

        private void btAplicar_Click(object sender, EventArgs e)
        {
            if (rbRojo.Checked)
                lblSaludo.BackColor = Color.Red;
            else if (rbAmarillo.Checked)
                lblSaludo.BackColor = Color.Yellow;
            else if (rbVerde.Checked)           
                lblSaludo.BackColor = Color.Green;
        }
    }
}
