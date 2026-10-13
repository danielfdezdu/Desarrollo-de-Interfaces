using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Formula1
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

                string[,] aConstructores = new string[5, 2] {{"2", "Red Bull" },
        {"1", "Ferrari"},
        {"5", "Mclaren"},
        {"3", "Mercedes"},
        {"4", "Aston Martin"}};

                string[,] aPilotos = new string[,] {{"16", "C.Leclerc", "1", "0"},
        {"55", "C.Sainz", "1", "0"},
        {"33", "M.Verstappen", "2", "0"},
        {"11", "S.Pérez", "2", "0"},
        {"44", "L.Hamilton", "3", "0"},
        {"63", "G.Russell", "3", "0"},
        {"14", "F.Alonso", "4", "0"},
        {"18", "L.Stroll", "4", "0"},
        { "4", "L.Norris", "5", "0"},
        {"81", "O.Piastri", "5", "0"}};

        string[] aCircuitos = new string[] { "Sepang Malasia", "Interlagos Brasil", "Yas Marina Abu Dhabi", "Spa-Francorchamps Bélgica", "Silverstone Gran Bretaña" };
        int nCircuito;
        int[] resultadoCarrera = new int[10];
        Random r = new Random();

        private void fInicial_Load(object sender, EventArgs e)
        {

            for (int f = 0; f < aConstructores.GetLength(0); f++)//visualizar constructores
            {
                lbxConstructores.Items.Add(aConstructores[f, 1]);
            }

            for (int f = 0; f < aPilotos.GetLength(0); f++)//visualizar pilotos + constructor
            {
                for (int cons = 0; cons < aConstructores.GetLength(0); cons++)
                {
                    if (aPilotos[f, 2] == aConstructores[cons, 0])
                    {
                        //lbxPilotos.Items.Add(aPilotos[f, 1] + "\t" + aConstructores[cons, 1]);
                        lbxPilotos.Items.Add(string.Format("{0,-18}{1}", aPilotos[f, 1], aConstructores[cons, 1]));
                        break;
                    }
                }
            }

            //visualizar nombre circuitos en labels
            foreach (Control cC in gbxCircuitos.Controls)
            {
                for (int i = 0; i < aCircuitos.GetLength(0); i++)
                {
                    cC.Text = aCircuitos[Convert.ToInt32(cC.Name.Substring(11, 1))];
                }
            }
            btnXerarResultado.Enabled = true;
        }

        private void btnXerarResultado_Click(object sender, EventArgs e)
        {

            int rPiloto = 0;
            bool xaExiste = false;

            for (int i = 0; i < resultadoCarrera.GetLength(0);)
            {
                rPiloto = r.Next(0, 10);
                xaExiste = false;
                for (int x = 0; x < i; x++)
                {
                    if (rPiloto == resultadoCarrera[x])
                    {
                        xaExiste = true;
                        break;
                    }
                }
                if (xaExiste == false)
                {
                    resultadoCarrera[i] = rPiloto;
                    lbxResultado.Items.Add(aPilotos[rPiloto, 1]);
                    i++;
                }
            }

            btnOutroCircuito.Enabled = true;
            btnXerarResultado.Enabled = false;

            // 1º piloto 25 ptos -- resultadoCarrera[0]
            // 2º piloto 15 ptos -- resultadoCarrera[1]
            // 3º piloto 10 ptos -- resultadoCarrera[2]
            // 4º piloto  5 ptos -- resultadoCarrera[3]

            int puntos = 0;
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        puntos = 25;
                        break;
                    case 1:
                        puntos = 15;
                        break;
                    case 2:
                        puntos = 10;
                        break;
                    case 3:
                        puntos = 5;
                        break;
                }
                btnVerClasificacions.Enabled = true;
                btnXerarResultado.Enabled = true;
            }
        }


    private void btnVerClasificacions_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < aPilotos.GetLength(0); i++)
        {
            lbxClasPilotos.Items.Add(string.Format("{0,-15}", aPilotos[i, 1], aPilotos[i, 3]));
        }

        for (int c = 0; c < aPilotos.GetLength(0); c++)
            {
                int pConstructor = 0;
                for (int p; p < aPilotos.GetLength(0); p++)
                {
                    if (aConstructores[c, 0] == aPilotos[p, 2)
                    {
                        pConstructor += Convert.ToInt32()
                    }
                }
            }

    }

    private void colorRojoLabelCircuito()
        {
            foreach (Control lC in gbxCircuitos.Controls)
            {
                if (nCircuito == Convert.ToInt32(lC.Name.Substring(11, 1)))
                {
                    lC.BackColor = Color.Red;
                    lC.ForeColor = Color.White;
                }
            }
        }

        private void btnOutroCircuito_Click(object sender, EventArgs e)
        {
            {
                colorRojoLabelCircuito();
                nCircuito++;
                btnOutroCircuito.Enabled = false;
                lbxResultado.Items.Clear();
                lbxClasPilotos.Items.Clear();
                lbxClasConstructores.Items.Clear();
            }
        }
    }
}