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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }



        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnArchivoAbrir_Click(object sender, EventArgs e)
        {
            fIncrustado fI = new fIncrustado();
            fI.MdiParent = this;

            fI.StartPosition = FormStartPosition.Manual;
            fI.Left = 0;
            fI.Top = 0;

            mn.Enabled = false;
            mnBt.Enabled = false;

            fI.Show();

            fI.FormClosing += seEstaCerrandoFI;
        }

        private void seEstaCerrandoFI(object sender, EventArgs e)
        {
            mn.Enabled = true;
            mnBt.Enabled = Enabled;
        }

    }
}
