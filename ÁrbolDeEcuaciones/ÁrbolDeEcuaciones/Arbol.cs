using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolDeEcuaciones
{
    class Arbol
    {
        private Nodo _inicio;
        private Nodo _fin;
        private Nodo _padre;
        private Nodo _inicioP;
        private Nodo _finalP;
        private Nodo _nodoP;

        public void agregarLista(Nodo nuevo)
        {
            if (_inicio == null)
                _inicio = nuevo;
            else
                agregarLista(nuevo, _inicio);
        }

        private void agregarLista(Nodo nuevo, Nodo ultimo)
        {
            if (ultimo._siguiente == null) 
            {
                ultimo._siguiente = nuevo;
                nuevo._anterior = ultimo;
                _fin = nuevo;
            }
            else
                agregarLista(nuevo, ultimo._siguiente);
        }

        private void agregarPila(Nodo nuevo)
        {
            if (_inicioP == null)
                _inicioP = nuevo;
            else
                agregarPila(nuevo, _inicioP);
        }

        private void agregarPila(Nodo nuevo, Nodo ultimo)
        {
            if (ultimo._siguiente == null) 
            {
                ultimo._siguiente = nuevo;
                nuevo._anterior = ultimo;
                _finalP = nuevo;
            }
            else
                agregarPila(nuevo, ultimo._siguiente);
        }

        private string eliminarUltimoPila()
        {
            string numero;
            numero = _finalP._data;
            _finalP = _finalP._anterior;
            if (_finalP != null)
                _finalP._siguiente = null;
            return numero;
        }

        public void crearArbol()
        {
            _padre = null;
            string caracterE;
            Nodo caracter = _inicio;
            Nodo cAnt = null;
            Nodo cSig = null;

            while (caracter != null)
            {
                cSig = caracter._siguiente;
                caracterE = Convert.ToString(caracter._data);
                if (caracterE == "*" || caracterE == "/") 
                {
                    _padre = caracter;
                    caracter._izquierda = caracter._anterior;
                    caracter._derecha = caracter._siguiente;
                    eliminarNodosLista(caracter, cAnt, cSig);
                }

                cAnt = caracter;
                caracter = caracter._siguiente;
            }

            caracter = _inicio;
            cAnt = null;
            cSig = null;

            while (caracter != null)
            {
                cSig = caracter._siguiente;
                caracterE = Convert.ToString(caracter._data);
                if (caracterE == "+" || caracterE == "-") 
                {
                    _padre = caracter;
                    caracter._izquierda = caracter._anterior; caracter._derecha = caracter._siguiente;
                    eliminarNodosLista(caracter, cAnt, cSig);
                }

                cAnt = caracter;
                caracter = caracter._siguiente;
            }

            _inicio = null;
        }

        private void eliminarNodosLista(Nodo caracter, Nodo cAnt, Nodo cSig)
        {
            if (caracter._anterior == _inicio)
            {
                _inicio = _inicio._siguiente;
                _inicio._anterior = null;
            }
            else
            {
                caracter._anterior = cAnt._anterior;
                cAnt._anterior._siguiente = caracter;
            }

            if (caracter._siguiente == _fin)
            {
                _fin._anterior._siguiente = null;
                _fin = _fin._anterior;
            }
            else
            {
                caracter._siguiente = cSig._siguiente;
                cSig._siguiente._anterior = caracter;
            }
        }

        public string postOrden()
        {
            if (_padre == null)
                return "Raiz vacia";
            else
                return postOrden(_padre);
        }

        private string postOrden(Nodo ultimo)
        {
            string lista = "";

            if (ultimo._izquierda != null)
                lista += postOrden(ultimo._izquierda);

            if (ultimo._derecha != null)
                lista += postOrden(ultimo._derecha);

            lista += ultimo.ToString();
            return lista;
        }

        public string resultadoPost()
        {
            int operacion = 0;
            string resultado = "";
            Nodo caracter = _inicio;

            while (caracter != null)
            {
                if (Char.IsNumber(Convert.ToChar(caracter._data)) == true) 
                {
                    _nodoP = new Nodo(caracter._data);
                    agregarPila(_nodoP);
                }
                else 
                {
                    string operador = caracter.ToString();
                    string rOperacion;         
                    int num1 = Convert.ToInt32(eliminarUltimoPila());
                    int num2 = Convert.ToInt32(eliminarUltimoPila());

                    switch (operador) 
                    {
                        case "+":
                            operacion = num2 + num1;
                            break;
                        case "-":
                            operacion = num2 - num1;
                            break;
                        case "*":
                            operacion = num2 * num1;
                            break;
                        case "/":
                            operacion = num2 / num1;
                            break;
                    }

                    rOperacion = Convert.ToString(operacion);
                    _nodoP = new Nodo(rOperacion);
                    agregarPila(_nodoP);
                }

                caracter = caracter._siguiente;
                if (caracter == null)
                    resultado = Convert.ToString(eliminarUltimoPila());
            }

            _inicioP = null;
            _finalP = null;
            _inicio = null;
            return resultado;
        }

        public string resultadoPre()
        {
            int operacion = 0;
            string resultado = "";
            Nodo caracter = _fin;

            while (caracter != null)
            {
                if (Char.IsNumber(Convert.ToChar(caracter._data)) == true) 
                {
                    _nodoP = new Nodo(caracter._data);
                    agregarPila(_nodoP);
                }
                else 
                {
                    string operador = caracter.ToString();
                    string rOperacion;
                    int num1 = Convert.ToInt32(eliminarUltimoPila());
                    int num2 = Convert.ToInt32(eliminarUltimoPila());

                    switch (operador) 
                    {
                        case "+":
                            operacion = num1 + num2;
                            break;
                        case "-":
                            operacion = num1 - num2;
                            break;
                        case "*":
                            operacion = num1 * num2;
                            break;
                        case "/":
                            operacion = num1 / num2;
                            break;
                    }

                    rOperacion = Convert.ToString(operacion);
                    _nodoP = new Nodo(rOperacion);
                    agregarPila(_nodoP);
                }

                caracter = caracter._anterior;
                if (caracter == null)
                    resultado = Convert.ToString(eliminarUltimoPila());
            }

            _inicioP = null;
            _finalP = null;
            _inicio = null;
            return resultado;
        }

        public string preOrden()
        {
            if (_padre == null)
                return "Raiz vacia";
            else
                return preOrden(_padre);
        }

        private string preOrden(Nodo ultimo)
        {
            string lista = "";

            lista += ultimo.ToString();

            if (ultimo._izquierda != null)
                lista += preOrden(ultimo._izquierda);

            if (ultimo._derecha != null)
                lista += preOrden(ultimo._derecha);

            return lista;
        }

        public string padre()
        {
            return _padre.ToString();
        }
    }
}
