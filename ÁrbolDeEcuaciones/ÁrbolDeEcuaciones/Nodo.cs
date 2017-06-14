using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolDeEcuaciones
{
    class Nodo
    {
        public string _data { get; }
        public Nodo _izquierda { get; set; }
        public Nodo _derecha { get; set; }
        public Nodo _siguiente { get; set; }
        public Nodo _anterior { get; set; }

        public Nodo(string data)
        {
            this._data = data;
            _izquierda = null;
            _derecha = null;
            _siguiente = null;
            _anterior = null;
        }

        public override string ToString()
        {
            return _data;
        }
    }
}
