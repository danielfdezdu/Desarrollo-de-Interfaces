using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _028_FormularioIncrustado
{
    public partial class fIncrustado : Form
    {
        public fIncrustado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarTamaño(object sender, EventArgs e)
        {
            label1.Text = this.Size.Width.ToString();
            label2.Text = this.Size.Height.ToString();
        }

    }
}
