using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_Eurocopa
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        string[,] aEquipos = new string[20, 2]{{"Austria",""},
                                               {"Bélgica",""},
                                               {"Croacia",""},
                                               {"Inglaterra",""},
                                               {"Francia",""},
                                               {"Alemania",""},
                                               {"Hungría",""},
                                               {"Islandia",""},
                                               {"Italia",""},
                                               {"Polonia",""},
                                               {"Portugal",""},
                                               {"Irlanda",""},
                                               {"Rumanía",""},
                                               {"Rusia",""},
                                               {"Eslovaquia",""},
                                               {"España",""},
                                               {"Suecia",""},
                                               {"Suiza",""},
                                               {"Turquía",""},
                                               {"Ucrania",""} };
        int[] aGrupo1 = new int[10];
        int[] aGrupo2 = new int[10];

        int[,] aCalendario = new int[90, 4];

        private void fInicial_Load(object sender, EventArgs e)
        {
            lbxEquipos.Items.Clear();

            for (int i = 0; i < aEquipos.GetLength(0); i++)
            {
                    String siglas = (aEquipos[i, 0].Substring(0, 3)).ToUpper();
                    aEquipos[i, 1] = siglas.ToUpper();
                    lbxEquipos.Items.Add(string.Format("{0,-8} \t {1}", siglas, aEquipos[i, 0]));
                
            }

            btGrupos.Enabled = true;
            btCalendario.Enabled = true;

        }

        private void btGrupos_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rEquipos = 0;
            lbxGrupo1.Items.Clear();
            lbxGrupo2.Items.Clear();

            for (int i = 0; i < aEquipos.GetLength(0);)
            {
                rEquipos = r.Next(0, 20);

                if (i < 10)
                {
                    if (Array.IndexOf(aGrupo1, rEquipos, 0, i) == -1) // este IF pregunta si existe un valor en el array grupo1
                    {                                                 // =-1 indica que NO existe, por tanto colocamos valor en el array
                        aGrupo1[i] = rEquipos;
                        lbxGrupo1.Items.Add(aEquipos[rEquipos, 1] + "\t" + aEquipos[rEquipos, 0]);
                        i++;
                    }
                    
                }
                else
                {
                   if (Array.IndexOf(aGrupo1, rEquipos, 0, 1) == -1 && Array.IndexOf(aGrupo2, rEquipos, 0, i - 10) == -1)
                    {
                        aGrupo2[i-10] = rEquipos;
                        lbxGrupo2.Items.Add(aEquipos[rEquipos, 1] + "\t" + aEquipos[rEquipos, 0]);
                        i++;
                    }
                }
            }

        }

        private void btCalendario_Click(object sender, EventArgs e)
        {

        }

        private void revolverEquipos(int[] aGrupo)
        {
            for (int i = 1; i < aGrupo.GetLength(1); i++)
            {

            }
        }

    }
}


