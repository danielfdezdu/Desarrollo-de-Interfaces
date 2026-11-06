using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_MaquinaBebidas
{
    public partial class f_Stock : Form
    {
        short[] stock;

        public f_Stock(short[] stockBebidas)
        {
            this.stock = stockBebidas;
            InitializeComponent();
        }

        string[] aNomesNUD;

        private void btCancelarStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptarStock_Click(object sender, EventArgs e)
        {
            foreach (Control cC in Controls)
            {
                if (Array.IndexOf(aNomesNUD, cC.Name) >= 0)
                {
                    stock[Array.IndexOf(aNomesNUD, cC.Name)] = Convert.ToInt16(cC.Text);
                }
            }

            this.Close();
        }

        private void f_Stock_Load(object sender, EventArgs e)
        {
            aNomesNUD = new string[] { "nudCocaCola", "nudColaLight", "nudFanNar", "nudFanLim", "nudSprite", "nudAquabona", "nudAquarius" };

            foreach (Control cC in Controls)
            {
                if (Array.IndexOf(aNomesNUD, cC.Name) >= 0)
                {
                    cC.Text = stock[Array.IndexOf(aNomesNUD, cC.Name)].ToString();
                }
            }
        }
    }
}
