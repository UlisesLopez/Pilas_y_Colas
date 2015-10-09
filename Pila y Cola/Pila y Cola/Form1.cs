using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//para usar las clases de pilas y cola

namespace Pila_y_Cola
{
    public partial class Form1 : Form
    {
        //pila
        Stack pila = new Stack();
        //Cola
        Queue cola = new Queue();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //agragar en una cola
            cola.Enqueue(new Persona(txtitem.Text));
            //agragar en ua pila
            pila.Push(new Persona(txtitem.Text));
            txtitem.Text = "";
            MostrarDatos();
        }

        private void nquitar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                //quitar en una cola
                cola.Dequeue();
                //quitar en pila
                pila.Pop();
            }
            else
                MessageBox.Show("No hay elementos a remover", "Pilas & Colas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarDatos();
        }

       private void MostrarDatos()
        {
           Vista v = new Vista();
           v.MostrarPila(lbpila,pila,label4lbturnofila);
           v.MostrarCola(lbcola, cola, lbturnocola);



           /* lbpila.Items.Clear();
            lbcola.Items.Clear();
            //Mostrar los valores 
            foreach (Persona item in cola)
                lbcola.Items.Add(item);
            foreach (Persona item in pila)
                lbpila.Items.Add(item);

            cantidad.Text = String.Format("Elementos: {0}", pila.Count);
            if (pila.Count > 0)
            {

                lbturnocola.Text = String.Format("Turno: {0}", cola.Peek());
                label4lbturnofila.Text = String.Format("Turno: {0}", pila.Peek());

            }
            else
                label4lbturnofila.Text = "Sin elementos";*/
        }
    }
}
