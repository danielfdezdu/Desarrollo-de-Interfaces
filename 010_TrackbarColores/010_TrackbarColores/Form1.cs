using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_TrackbarColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cambiarColor(object sender, EventArgs e)
        {
            lblValorRed.Text = tbRed.Value.ToString();
            lblValorGreen.Text = tbGreen.Value.ToString();
            lblValorBlue.Text = tbBlue.Value.ToString();

            lblColor.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = tbRed.Value.ToString();
            lblValorRed.Text = tbRed.Value.ToString();

            lblRed.Location = new Point(239 + tbRed.Value * 5, 80);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = tbGreen.Value.ToString();
            lblValorGreen.Text = tbGreen.Value.ToString();

            lblGreen.Location = new Point(239 + tbGreen.Value * 5, 80);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = tbBlue.Value.ToString();
            lblValorBlue.Text = tbBlue.Value.ToString();

            lblBlue.Location = new Point(239 + tbBlue.Value * 5, 80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblValorRed.Text = tbRed.Maximum.ToString();
            lblValorGreen.Text = tbRed.Maximum.ToString();
            lblValorBlue.Text = tbRed.Maximum.ToString();
        }

    }
}
