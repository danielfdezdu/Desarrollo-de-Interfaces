using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_ReservarEntrada
{
    public class clsAbonado
    {
        #region "prop privadas"
        private string _nome;
        private string _enderezo;
        private string _provincia;
        private DateTime _dataNac;
        private string[] _asientos = new string[5];
        #endregion

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Enderezo
        {
            get
            {
                return _enderezo;
            }

            set
            {
                _enderezo = value;
            }
        }

        public string Provincia
        {
            get
            {
                return _provincia;
            }

            set
            {
                _provincia = value;
            }
        }

        public DateTime DataNac
        {
            get
            {
                return _dataNac;
            }

            set
            {
                _dataNac = value;
            }
        }

        public string[] Asientos
        {
            get
            {
                return _asientos;
            }

            set
            {
                _asientos = value;
            }
        }
    }
}
