using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_ReservarEntrada
{
    public partial class fEnderezo : Form
    {
        public fEnderezo(clsAbonado oA)
        {
            InitializeComponent();
            this.abonado = oA;
        }

        clsAbonado abonado;


        private void btAceptar_Click(object sender, EventArgs e)
        {
            abonado.Enderezo = tbEnderezo.Text;
            abonado.Provincia = cbProvincia.Text;

            this.Close();
        }

    }
}
