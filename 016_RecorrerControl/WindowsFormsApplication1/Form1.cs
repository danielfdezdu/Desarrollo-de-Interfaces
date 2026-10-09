using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btListar_Click(Control Control)
        {
            foreach (Control cC in Controls)
            {
                verControl(cC);
            }
        }
         private void verControl(Control C)
        {
            listBox1.Items.Add(C.Name);
                if (C.HasChildren)
                {
                  foreach(Control cHijo in C.Controls)
                  {

                  }
                }

        }
        }
 }
