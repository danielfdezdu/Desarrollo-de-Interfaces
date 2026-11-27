using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_ReservarEntrada
{
    public class clsGrada
    {
        #region "propiedades"

        private string[] _asientosGrada = new string[56];

        public string[] AsientosGrada
        {
            get {return _asientosGrada;}
            set {_asientosGrada = value;}
        }
        #endregion

        //método que devuelva boolean indicando si encontró asiento libre dentro de grada
        //Si lo hay, marcar ese asiento con 'x' y anotarlo en el objeto Abonado
        public bool comprobarGrada(string zona, ref int asientoRecibido)
        {
            int[] posInicioFin = new int[2];
            bool esValida = false;

            limites(posInicioFin, zona);

            

            for (int i = posInicioFin[0]; i <= posInicioFin[1]; i++)
            {
                if (AsientosGrada[i] == null || !AsientosGrada[i].Equals("x"))
                {
                    esValida = true;
                    AsientosGrada[i] = "x";
                    asientoRecibido = i;
                    break;
                }
                    
            }


            return esValida;
        }


        //A y B ---> 14
        //C y D ---> 6
        //E,F,G,H ---> 4


        private void limites(int[] posiciones, string zona)
        {
            //40 ---> Ya es E
            int[] posInicio = new int[] { 0, 14, 28, 34, 40, 44, 48, 52 };
            int[] posFin = new int[] { 13, 27, 33, 39, 43, 47, 51, 55 };

            int letra = -1;

            if (zona.Equals("A"))
                letra = 0;
            else if (zona.Equals("B"))
                letra = 1;
            else if (zona.Equals("C"))
                letra = 2;
            else if (zona.Equals("D"))
                letra = 3;
            else if (zona.Equals("E"))
                letra = 4;
            else if (zona.Equals("F"))
                letra = 5;
            else if (zona.Equals("G"))
                letra = 6;
            else if (zona.Equals("H"))
                letra = 7;


            posiciones[0] = posInicio[letra];
            posiciones[1] = posFin[letra];
        }



    }
}
