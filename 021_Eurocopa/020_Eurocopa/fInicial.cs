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
        int nXornada = 0;
        int nPartido = 0;

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
            int nXornada = 0;

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
            btGrupos.Enabled = false;
            btCalendario.Enabled = true;
        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
            btGrupos.Enabled = false;
            nXornada = 1;
            XerarCrucesXornada(1, aGrupo1);
            XerarCrucesXornada(2, aGrupo2);
            // antes de xerar a seguinte xornada hai que cambiar
            // os arrrays aGrupo1 a aGrupo2

            for (nXornada = 2; nXornada < 10; nXornada++)
            {
                int temporalP9G1 = aGrupo1[9];
                int temporalP9G2 = aGrupo2[9];
                for (int i = 9; i > 1; i--)
                {
                    aGrupo1[i] = aGrupo1[i - 1];
                    aGrupo2[i] = aGrupo2[i - 1];
                }

                aGrupo1[1] = temporalP9G1;
                aGrupo2[1] = temporalP9G2;

                XerarCrucesXornada(1, aGrupo1);
                XerarCrucesXornada(2, aGrupo2);
            }

            // ver en listbox as xornadas

            for(int i = 0; i < aCalendario.GetLength(0); i++)
            {
                if (i % 10 == 0)
                {
                    lbxCalendarioG1.Items.Add("---------");
                    lbxCalendarioG1.Items.Add("xornada " + aCalendario[i, 0]);
                    lbxCalendarioG1.Items.Add("---------");

                    lbxCalendarioG2.Items.Add("---------");
                    lbxCalendarioG2.Items.Add("xornada " + aCalendario[i, 0]);
                    lbxCalendarioG2.Items.Add("---------");
                }

                if (aCalendario[i, 1] == 1)
                {
                    lbxCalendarioG1.Items.Add(aEquipos[aCalendario[i, 2], 1] + "\t" + aEquipos[aCalendario[i, 3], 1]);
                }
                else
                {
                    lbxCalendarioG2.Items.Add(aEquipos[aCalendario[i, 2], 1] + "\t" + aEquipos[aCalendario[i, 3], 1]);
                }
            }

        }

        private void XerarCrucesXornada(int grupo, int[] aGrupo)
        {
            for (int i = 0; i < 5; i++)
            {
                aCalendario[nPartido , 0] = nXornada;
                aCalendario[nPartido , 1] = grupo;
                aCalendario[nPartido , 2] = aGrupo[i];
                aCalendario[nPartido , 3] = aGrupo[9-i];
                nPartido++;

            }
        }

    }
}


