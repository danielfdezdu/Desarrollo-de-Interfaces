using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 585;
            this.Width = 624;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double soldo = 0, pIRPF = 0, nfillos = 0;
            double cFillos = 0, cECivil = 0, cOutros = 0;

            if (tbSoldo.Text == "")
            {
                soldo = 0;
            } else soldo = Convert.ToInt32(tbSoldo.Text);


            if (tbIRPF.Text == "")
            {
                pIRPF = 0;
            } else pIRPF = Convert.ToInt32(tbIRPF.Text);

            if (tbFillos.Text == "")
            {
                 nfillos = 0;
            }
            else nfillos = Convert.ToInt32(tbFillos.Text);

            if (soldo == 0)
                MessageBox.Show("o empregado debe ter un saldo");
            else
                cFillos = nfillos * 20;

            if (rbCasado.Checked) cECivil = 15;
            else if (rbSolteiro.Checked) cECivil = 5;
            else if (rbViuvo.Checked) cECivil = 30;

            if (cbMenor.Checked) cOutros += 10;
            if (cbDpto.Checked) cOutros += 20;
            if (cb10anos.Checked) cOutros += 30;

            double descontoIRPF = (soldo + cFillos + cECivil + cOutros) * pIRPF / 100;

            double sueldoLiquido = (soldo + cFillos + cECivil + cOutros) - descontoIRPF;

            lblCampBruto.Text = string.Format("{0:##,##0.00}", soldo);
            lblCampCivil.Text = string.Format("{0:##,##0.00}", cECivil);
            lblCampFil.Text = string.Format("{0:##,##0.00}", cFillos);
            lblCampOutros.Text = string.Format("{0:##,##0.00}", cOutros);

            lblCampIRPF.Text = string.Format("{0:##,##0.00}", descontoIRPF);
            lblCampLiquido.Text = string.Format("{0:##,##0.00}", sueldoLiquido);

            this.Height = 585;
            this.Width = 1079;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbSoldo.Text = "";
            tbIRPF.Text = "";
            tbFillos.Text = "";

            cb10anos.Checked = false;
            cbDpto.Checked = false;
            cbMenor.Checked = false;

            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbViuvo.Checked = false;

            lblCampBruto.Text = "";
            lblCampCivil.Text = "";
            lblCampFil.Text = "";
            lblCampIRPF.Text = "";
            lblCampLiquido.Text = "";
            lblCampOutros.Text = "";

            this.Height = 585;
            this.Width = 624;
        }


    }

    }
 
