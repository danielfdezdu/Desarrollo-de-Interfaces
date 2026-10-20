using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_RelojDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void actualizarReloj(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #region "// metodo 1"
        // mover un formulario sin borde
        // -----------------------------------------------

        bool movimiento = true;

        private void lblReloj_MouseDown(object sender, MouseEventArgs e)
        {
            movimiento = true;
        }

        private void lblReloj_MouseUp(object sender, MouseEventArgs e)
        {
            movimiento = false;
        }

        private void lblReloj_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimiento)
            {
                this.Location = Cursor.Position;
            }
        }

        #endregion

    }
}
