using System;
using System.Collections.Generic;
using System.Text;

namespace Grid
{
    class Grid
    {

        public int _id;
        public int Id
        {
            get
            { return this._id; }
            set
            {
                this._id = value;
            }
        }

        public int id_vesao { get; set; }

        public string resultado { get; set; }

        public Grid(int id, int id_versao, string resultado)
        {
            Id = id;
            this.id_vesao = id_versao;
            this.resultado = resultado;


        }
    }
}
