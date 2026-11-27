using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_ReservarEntrada
{
    public partial class fEscollerAsiento : Form
    {
        /*
            Corrección: podería ter un array de botóns:
            Button[] botones = new Button[] { btA, btB, btC, btD, btE, btF, btG, btH };

            Corrección:
            comprobarGrada() recibe abonado ---> Se le añade el nuevo asiento en el primer null
        */ 


        public fEscollerAsiento(clsAbonado oA, clsGrada grd)
        {
            InitializeComponent();

            this.abonado = oA;
            this.grada = grd;
        }

        clsAbonado abonado;
        clsGrada grada;
        int posSiguienteAsiento;


        private void escollerAsiento(object sender, EventArgs e)
        {
            if (!podeRecibirMaisAsientos())
                MessageBox.Show("Non pode escoller máis asientos.");
            else
                darAsiento((Button)sender);
        }


        //Tendría máis xeito por isto coma un método da clase clsAbonado
        //O problema é que modifica unha variable global e devolve un booleano
        private bool podeRecibirMaisAsientos()
        {
            int contador = 0;

            for (int i = 0; i < abonado.Asientos.Length; i++)
            {
                if (abonado.Asientos[i] != null && !abonado.Asientos[i].Equals(""))
                    contador++;
                else
                {
                    posSiguienteAsiento = i;
                    break;
                }
            }

            return contador < abonado.Asientos.Length;
        }


        //Mejorar: el método "comprobarGrada()" hace demasiado ---> Devuelve un valor y modifica otro por referencia.
        private void darAsiento(Button zona)
        {
            int asientoRecibido = -1;

            string nomeZona = zona.Name.Substring(2);
            bool haiAsientos = grada.comprobarGrada(nomeZona, ref asientoRecibido);

            if (haiAsientos)
                abonado.Asientos[posSiguienteAsiento] = nomeZona + asientoRecibido.ToString();
            else
                MessageBox.Show("Non hai asientos dispoñíbeis nesa zona.");
        }


        private void btAsentosLibres_Click(object sender, EventArgs e)
        {
            fAsientosLibres fLibres = new fAsientosLibres(grada);
            fLibres.Show();
        }


        //Al pulsar una sección, comprobar si hay asientos libres ahí.
        //Si no hay, sacar mensaje
        //Si hay, darle el asiento al objeto clsAbonado (tiene un máx. de 5 asientos)
    }
}
