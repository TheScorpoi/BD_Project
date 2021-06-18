using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineDBInterfaCe
{
    class Pessoa
    {
        private String _nome, _morada, _genero, _telemovel;
        private int _NIF;
        private DateTime _data_nascimento;


        public Pessoa ()
        {
        }

        public String nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public String morada
        {
            get { return this._morada; }
            set { this._morada = value; }
        }

        public String genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }

        public String telemovel
        {
            get { return this._telemovel; }
            set { this._genero = value; }
        }

        public int NIF
        {
            get { return this._NIF; }
            set { this._NIF = value; }
        }

        public DateTime data_nascimento
        {
            get { return this._data_nascimento; }
            set { this._data_nascimento = value; }
        }

        override
        public String ToString()
        {
            StringBuilder sb = new StringBuilder(_nome + " " + _NIF);
            return sb.ToString();

        }
    }
}
