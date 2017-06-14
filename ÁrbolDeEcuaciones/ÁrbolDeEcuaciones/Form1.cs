using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁrbolDeEcuaciones
{
    public partial class Form1 : Form
    {
        Nodo nuevo;
        Arbol arbol = new Arbol();
        string listaP;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEcuacion_Click(object sender, EventArgs e)
        {
            string ecuacion = txtEcuacion.Text;
            char[] array = ecuacion.ToCharArray();

            foreach (char charr in array) 
            {
                nuevo = new Nodo(Convert.ToString(charr));
                arbol.agregarLista(nuevo);
            }
          
            arbol.crearArbol();
            txtPost.Text = arbol.postOrden();
            txtPre.Text = arbol.preOrden();
        }

        private void cmdEpost_Click(object sender, EventArgs e)
        {
            listaP = txtPost.Text;
            char[] array = listaP.ToCharArray();

            foreach (char charr in array) 
            {
                nuevo = new Nodo(Convert.ToString(charr));
                arbol.agregarLista(nuevo);
            }

            txtRpost.Text = arbol.resultadoPost();
        }

        private void cmdEpre_Click(object sender, EventArgs e)
        {
            listaP = txtPre.Text;
            char[] array = listaP.ToCharArray();

            foreach (char charr in array) 
            {
                nuevo = new Nodo(Convert.ToString(charr));
                arbol.agregarLista(nuevo);
            }

            txtRpre.Text = arbol.resultadoPre();
        }
    }
}
