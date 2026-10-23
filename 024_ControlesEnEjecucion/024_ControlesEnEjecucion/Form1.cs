using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _024_ControlesEnEjecucion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label lbl_ejecucion = new Label
        { // añadir propiedades
            Text = "Label Ejecución",
            BackColor = Color.Blue,
            ForeColor = Color.Orange,
            Font = new Font ("Arial",14,FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter,
            Size = new Size (250, 25),
            Location = new Point (300, 121)
        };

        private void Form1_Load(object sender, EventArgs e)
        {
             Controls.Add(lbl_ejecucion);

            for (int i = 0; i < 5; i++)
            {
                Button miBoton = new Button
                {
                    Name = "btn" + i,
                    Text = "Botón Ejecución " + i,
                    Size = new Size(250, 25),
                    Location = new Point(300, 70 * i)
                };
                Controls.Add(miBoton);
                miBoton.Click += new System.EventHandler(metodo_para_botones);
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metodo_para_botones(object sender, EventArgs e)
        {
            lbl_ejecucion.Text = "pulsado botón";

            if (((Button)sender).Name == "btn0")
            {

            }
        }
    }
}
