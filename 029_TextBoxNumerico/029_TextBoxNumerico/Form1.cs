using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _029_TextBoxNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] aTexto;

        private void txbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                if (txbNumero.Text.Contains(','))
                {
                    e.Handled = false;
                }
                else if (txbNumero.TextLength == 0)
                {
                    txbNumero.Text = "0,";
                    e.Handled = true;
                    txbNumero.SelectionStart = txbNumero.TextLength;
                }
                else if (txbNumero.Text == "-")
                {
                    txbNumero.Text = "0,";
                    e.Handled = true;
                    txbNumero.SelectionStart = txbNumero.TextLength;
                }
            }
            else if (e.KeyChar == '-' && txbNumero.TextLength == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
