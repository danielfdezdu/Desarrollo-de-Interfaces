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
    public partial class f_Inicial : Form
    {
        public f_Inicial()
        {
            InitializeComponent();
        }


        clsAbonado abonado = new clsAbonado();
        clsGrada grada = new clsGrada();


        /////////////////////////////
        /////A otros formularios/////
        /////////////////////////////


        private void btEnderezo_Click(object sender, EventArgs e)
        {
            fEnderezo formEnderezo = new fEnderezo(abonado);
            formEnderezo.ShowDialog();

            lblEnderezo.Text = abonado.Enderezo;
            lblProvincia.Text = abonado.Provincia;
        }


        private void btEscoller_Click(object sender, EventArgs e)
        {
            fEscollerAsiento formEscollerAsiento = new fEscollerAsiento(abonado, grada);
            formEscollerAsiento.ShowDialog();

            lblGrada.Text = ""; //Si no eliminas el texto y, tras seleccionar asientos, vuelves a darle al botón, se añaden repetidos.
            for (int i = 0; i < abonado.Asientos.Length; i++)
            {
                if (abonado.Asientos[i] != null && !abonado.Asientos[i].Equals(""))
                    lblGrada.Text += lblGrada.Text.Equals("") ? abonado.Asientos[i] : (", " + abonado.Asientos[i]);
            }
        }



        //////////////////////
        ////Otros métodos/////
        //////////////////////

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = tbNome.Text;

            abonado.Nome = tbNome.Text;
        }

        private void dtpNacemento_ValueChanged(object sender, EventArgs e)
        {
            lblData.Text = dtpNacemento.Value.Date.ToLongDateString();
            abonado.DataNac = dtpNacemento.Value.Date;
        }

        
    }
}
