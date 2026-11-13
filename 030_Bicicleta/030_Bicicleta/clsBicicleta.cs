using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Bicicleta
{
    class clsBicicleta
    {
        // propiedades
        #region "propiedades privadas"
        private string _marca;
        private string _modelo;
        private short _velocidad;
        #endregion

        #region "propiedades públicas"
        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public short Velocidad
        {
            get
            {
                return _velocidad;
            }

            set
            {
                if (value > 70)
                    value = 70;
                else if (value < 0)
                    value = 0;

                _velocidad = value;
            }
        }
        #endregion

        // métodos
        // constructor
        public clsBicicleta(string ma, string mo)
        {
            this.Marca = ma;
            this.Modelo = mo;
        }

        public void Acelerar(short Vel)
        {

            this.Velocidad += Vel;

            //if (this.Velocidad + Vel < 70)
            //{
            //    this.Velocidad += Vel;

            //} else
            //{
            //    this.Velocidad = 70;
            //}
        }

        public void Frenar(short Vel)
        {

            this.Velocidad -= Vel;

            //this.Velocidad -= Vel;
            //if (this.Velocidad - Vel > 0)
            //{
            //    this.Velocidad -= Vel;
            //} else
            //{
            //    this.Velocidad = 0;
            //}
        }

    }
}
