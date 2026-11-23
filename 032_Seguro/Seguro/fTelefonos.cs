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
    public partial class fTelefonos : Form
    {
        private clsAsegurado oSeguro;

        public fTelefonos(clsAsegurado oSeguro)
        {
            InitializeComponent();
            this.oSeguro = oSeguro;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxTelefonos.Items.Count; i++)
            {
                oSeguro.Telefonos[i] = Convert.ToInt32(lbxTelefonos.Items[i]);
            }
            this.Close();
        }

        private void btEngadirTelefono_Click(object sender, EventArgs e)
        {
            if (lbxTelefonos.Items.Count < 5)
            {
                if (tbxTelefono.Text == "") tbxTelefono.Text = "0";

                lbxTelefonos.Items.Add(tbxTelefono.Text);
                tbxTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Pódense arquivar un máximo de 5 teléfonos");
            }
        }
    }
}
