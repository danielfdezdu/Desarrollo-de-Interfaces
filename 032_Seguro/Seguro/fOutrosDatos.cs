using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguro
{
    public partial class fOutrosDatos : Form
    {
        private clsAsegurado oSeguro;

        public fOutrosDatos(clsAsegurado oSeguro)
        {
            InitializeComponent();
            this.oSeguro = oSeguro;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            oSeguro.Idade = Convert.ToInt16(tbxEdade.Text);
            if (rbtMuller.Checked)
            {
                oSeguro.Sexo = 'M';
            }
            else
            {
                oSeguro.Sexo = 'H';
            }
            this.Close();
        }
    }
}
