using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void revisaBoton(object sender, EventArgs e)
        {
            lblMensaje.Text = "que tal";

            if (((Button)sender).Name == "btUNO")
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).BackColor = Color.Blue;
                lblMensaje.BackColor = Color.Black;
                lblMensaje.ForeColor = Color.Blue;

                lblMensaje.Text = "que tal" + ((Button)sender).Name + " " + ((Button)sender).Name + " " + ((Button)sender).Text;
            }
            else if (((Button)sender).Name == "btDOS")
            {
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).BackColor = Color.Red;
                lblMensaje.BackColor = Color.Orange;
                lblMensaje.ForeColor = Color.Red;

                lblMensaje.Text = "que tal" + ((Button)sender).Name + " " + ((Button)sender).Name + " " + ((Button)sender).Text;
            }
            else if (((Button)sender).Name == "btTRES")
            {
                ((Button)sender).BackColor = Color.Magenta;
                ((Button)sender).BackColor = Color.Yellow;
                lblMensaje.BackColor = Color.Magenta;
                lblMensaje.ForeColor = Color.Yellow;

                lblMensaje.Text = "que tal" + ((Button)sender).Name + " " + ((Button)sender).Name + " " + ((Button)sender).Text;
            }
        }
    }
}

