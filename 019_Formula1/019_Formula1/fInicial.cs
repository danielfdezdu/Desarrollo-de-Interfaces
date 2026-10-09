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

        string[,] aPilotos = new string[,]  {{"16", "C.Leclerc", "1", "0"},
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

        private void btnXerarResultado_Click(object sender, EventArgs e)
        {
            int[] resultadoCarrera = new int[10];
            Random r = new Random();
            int corredores = 0;

            while(corredores < 10)
            {
                int pilotoAleatorio = r.Next(0,10);
                bool existe = false;

                for (int i = 0; i < corredores; i++)
                {
                    if (resultadoCarrera[i] == pilotoAleatorio)
                    {
                        existe = true;
                        break;
                    } 
                }
                if (!existe)
                {
                    resultadoCarrera[corredores] = pilotoAleatorio;
                    corredores++;
                }
            }
        }

        // Carga de la aplicación y muestra de los pilotos y constructores

        private void fInicial_Load_1(object sender, EventArgs e)
        {
            for (int f = 0; f < aConstructores.GetLength(0); f++)
            {
                lbxConstructores.Items.Add(aConstructores[f, 1]);
            }

            for (int f = 0; f < aPilotos.GetLength(0); f++)
            {
                for (int con = 0; con < aPilotos.GetLength(0); con++)
                {
                    if (aPilotos[f, 2] == aConstructores[con, 0])
                    {
                        // lbxPilotos.Items.Add(aPilotos[f, 1] + "\t" + aConstructores[con, 1]);
                        lbxPilotos.Items.Add(String.Format("{0,-18}{1}", aPilotos[f, 1] , aConstructores[con, 1]));
                        break;
                    }
                }
            }

            // Mostrar nombre de los circuitos

            foreach (Control cC in gbxCircuitos.Controls)
            {
                cC.Text = aCircuitos[Convert.ToInt32(cC.Name.Substring(11, 1))];
            }
        }     
    }
}
