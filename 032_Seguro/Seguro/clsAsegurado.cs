using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro
{
    public class clsAsegurado
    {
        #region "prop. privadas"
        private string _nome;
        private string _enderezo;
        private int[] _telefonos = new int[5];
        private char _sexo;
        private short _idade;
        #endregion

        #region "prop. públicas"
        public string Nome
        {
            get {return _nome;}
            set {_nome = value;}
        }

        public string Enderezo
        {
            get{return _enderezo;}
            set{_enderezo = value;}
        }

        public int[] Telefonos
        {
            get{return _telefonos;}
            set{_telefonos = value;}
        }

        public char Sexo
        {
            get{return _sexo;}
            set{_sexo = value;}
        }

        public short Idade
        {
            get{return _idade;}
            set{_idade = value;}
        }
        #endregion

        public void BorrarDatosAsegurado()
        {
            _nome = "";
            _enderezo = "";
            _telefonos = new int[0];
            _sexo = ' ';
            _idade = 0;
        }

    }

}
