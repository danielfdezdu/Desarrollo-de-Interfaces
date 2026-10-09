using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_DepositoAgua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OcultarVisualizarSeleccionDeposito(object sender, EventArgs e)
        {
            if (rbAutomatico.Checked)
                gpSeleccion.Visible = false;
            else
                gpSeleccion.Visible = true;
        }

        private void btIntroducir_Click(object sender, EventArgs e)
        {
            if (rbAutomatico.Checked) // Modo automático seleccionado. Buscar el más vacío.
            {
                // Comprobar que os despósitos admiten esa cantidad de agua
                if ((progressBar1.Value + nudIntroducir.Value) > progressBar1.Maximum && (progressBar2.Value + nudIntroducir.Value) > progressBar2.Maximum)
                {
                    MessageBox.Show("Ningún depóstito admite esa cantidad de agua");
                }
                else // Polo menos un dos depósitos admite esa cantidade de auga, Cal?
                {
                    if (progressBar1.Value > progressBar2.Value)
                    {
                        // Introducir en depósito 2
                        progressBar2.Value += Convert.ToInt32(nudIntroducir.Value);
                    }
                    else
                        progressBar1.Value += Convert.ToInt32(nudIntroducir.Value);
                }
            }
            else // Modo manual. Comprobar que depósito está seleccionado
            {
                if (rbDeposito1.Checked) // Seleccionado depósito 1, comprobar si admite carga de agua 
                {
                    if (progressBar1.Value + nudIntroducir.Value > progressBar1.Maximum)
                    {
                        MessageBox.Show("O depósito 1 non admite esa cantidade de auga");
                    }
                    else
                    {
                        progressBar1.Value += Convert.ToInt32(nudIntroducir.Value);
                    }
                }
                else if (rbDeposito2.Checked) // Seleccionado depósito 2, Comprobar si admite carga de agua
                {
                    if (progressBar2.Value + nudIntroducir.Value > progressBar2.Maximum)
                    {
                        MessageBox.Show("O depósito 2 non admite esa cantidade de auga");
                    }
                    else
                    {
                        progressBar2.Value += Convert.ToInt32(nudIntroducir.Value);
                    }
                }
            }
            lblValorDeposito1.Text = progressBar1.Value.ToString();
            lblValorDeposito2.Text = progressBar2.Value.ToString();
        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            if (rbAutomatico.Checked) // Modo automático seleccionado. Buscar el más lleno.
            {
                // Comprobar que os despósitos admiten esa cantidad de agua
                if ((progressBar1.Value - nudRetirar.Value) < progressBar1.Minimum && (progressBar2.Value - nudRetirar.Value) < progressBar2.Minimum)
                {
                    MessageBox.Show("Ningún depóstito admite quitar esa cantidad de agua");
                }
                else // Polo menos un dos depósitos admite quitar esa cantidade de auga, Cal?
                {
                    if (progressBar1.Value < progressBar2.Value)
                    {
                        // Retirar en depósito 2
                        progressBar2.Value -= Convert.ToInt32(nudRetirar.Value);
                    }
                    else
                        progressBar1.Value -= Convert.ToInt32(nudRetirar.Value);
                }
            }
            else // Modo manual. Comprobar que depósito está seleccionado
            {
                if (rbDeposito1.Checked) // Seleccionado depósito 1, comprobar si admite quitar esa carga de agua 
                {
                    if (progressBar1.Value - nudRetirar.Value < progressBar1.Minimum)
                    {
                        MessageBox.Show("O depósito 1 non admite quitar esa cantidade de auga");
                    }
                    else
                    {
                        progressBar1.Value -= Convert.ToInt32(nudRetirar.Value);
                    }
                }
                else if (rbDeposito2.Checked) // Seleccionado depósito 2, Comprobar si admite quitar esa carga de agua
                {
                    if (progressBar2.Value - nudRetirar.Value < progressBar2.Minimum)
                    {
                        MessageBox.Show("O depósito 2 non admite quitar esa cantidade de auga");
                    }
                    else
                    {
                        progressBar2.Value -= Convert.ToInt32(nudRetirar.Value);
                    }
                }
            }
        }

        private void btVaciar_Click(object sender, EventArgs e)
        {
            rbAutomatico.Checked = true;
            rbDeposito1.Checked = false;
            rbDeposito2.Checked = false;
            nudIntroducir.Value = 0;
            nudRetirar.Value = 0;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            lblValorDeposito1.Text = "0";
            lblValorDeposito2.Text = "0";
        }
    }
}