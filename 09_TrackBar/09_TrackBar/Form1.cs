using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbValor.Text = tbProgreso.Value.ToString();
            lblMovil.Text = tbProgreso.Value.ToString();

            lblMovil.Location = new Point(239+tbProgreso.Value * 5,80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMinimo.Text = tbProgreso.Minimum.ToString();
            lblMaximo.Text = tbProgreso.Maximum.ToString();
        }

    }
}

