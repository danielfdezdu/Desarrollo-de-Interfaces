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
           // Controls.Add(lbl_ejecucion);

            for (int i = 0; i < 5; i++)
            {
                Controls.Add(
                    new Button
                    {
                        Name = "btn" + i,
                        Text = "Botón Ejecución " + i,
                        Size = new Size(250, 25),
                        Location = new Point(300, 70 * i)
                    }
                );
            }

        }

    }
}
