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
    public partial class fSeguro : Form
    {
        public fSeguro()
        {
            InitializeComponent();
        }

        private void btTelefonos_Click(object sender, EventArgs e)
        {
            fTelefonos fTel = new fTelefonos(oSeguro);
            fTel.ShowDialog();
        }

        private void btOutrosDatos_Click(object sender, EventArgs e)
        {
            fOutrosDatos fOutros = new fOutrosDatos(oSeguro);
            fOutros.ShowDialog();
        }

        clsAsegurado oSeguro = new clsAsegurado();

        private void engadirDatos()
        {
            oSeguro.Nome = tbxNome.Text;
            oSeguro.Enderezo = tbxEnderezo.Text;
            
        }

        private void btNovoAsegurado_Click(object sender, EventArgs e)
        {
            oSeguro = new clsAsegurado();

            //limpiar  formulario
            tbxNome.Text = "";
            tbxEnderezo.Text = "";
            lbxDatosAsegurado.Items.Clear();

            //estado botones
            btDatosAsegurado.Enabled = true;
            btTelefonos.Enabled = true;
            btOutrosDatos.Enabled = true;

            tbxNome.Enabled = true;
            tbxEnderezo.Enabled = true;
            
        }

        private void tbxNome_Leave(object sender, EventArgs e)
        {
            oSeguro.Nome = tbxEnderezo.Text;
        }

        private void tbxEnderezo_Leave(object sender, EventArgs e)
        {
            oSeguro.Enderezo = tbxEnderezo.Text;
        }

        private void btDatosAsegurado_Click(object sender, EventArgs e)
        {
            lbxDatosAsegurado.Items.Clear();
            lbxDatosAsegurado.Items.Add(string.Format("nome: {0,-15}", oSeguro.Nome));
            lbxDatosAsegurado.Items.Add(string.Format("enderezo: {0,-15}", oSeguro.Enderezo));

            bool primeraLinea = true;
            for (int i = 0; i < oSeguro.Telefonos.GetLength(0); i++)
            {
                if (primeraLinea && oSeguro.Telefonos[i] > 0) {
                    lbxDatosAsegurado.Items.Add(string.Format("{0,-12}{1}", "teléfonos: ", oSeguro.Telefonos[i]));
                    primeraLinea = false;
                }   
                else if (oSeguro.Telefonos[i] > 0) {
                    lbxDatosAsegurado.Items.Add(string.Format("{0,-12}{1}", "", oSeguro.Telefonos[i]));
                }
            }
            lbxDatosAsegurado.Items.Add(string.Format("{0,-12}{1}", "edad: ", oSeguro.Idade));
            lbxDatosAsegurado.Items.Add(string.Format("{0,-12}{1}", "sexo: ", oSeguro.Sexo));
        }
    }
}
