using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Pila_y_Cola
{
    class Vista
    {
        public void MostrarPila(ListBox lista, Stack pila, Label turno)
        {
            lista.Items.Clear();
            //Mostrar los valores 
            foreach (Persona item in pila)
                lista.Items.Add(item);

            if (pila.Count > 0)
                turno.Text = String.Format("Turno: {0}", pila.Peek());
            else
                turno.Text = "Sin elementos";
        }


        public void MostrarCola(ListBox lista, Queue cola, Label turno)
        {
            lista.Items.Clear();
            //Mostrar los valores 
            foreach (Persona item in cola)
                lista.Items.Add(item);

            if (cola.Count > 0)
                turno.Text = String.Format("Turno: {0}", cola.Peek());
            else
                turno.Text = "Sin elementos";
        }


    }//fin de la clase 
}//fin del namespace 
