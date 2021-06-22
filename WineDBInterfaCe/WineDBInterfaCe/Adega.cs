using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineDBInterfaCe
{
    class Adega
    {

        private String _ID, _nome, _endereco;
        private int _n_cubas, _NIF_Gerente;
        private double _cap_max;

        public Adega()
        {

        }

        public String ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }

        public String Nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public String Endereco
        {
            get { return this._endereco; }
            set { this._endereco = value; }
        }

        public int NifGerente
        {
            get { return this._NIF_Gerente; }
            set { this._NIF_Gerente = value; }
        }

        public int NumCubas
        {
            get { return this._n_cubas; }
            set { this._n_cubas = value; }
        }

        public double CapMax
        {
            get { return this._cap_max; }
            set { this._cap_max = value; }
        }

    }
}
