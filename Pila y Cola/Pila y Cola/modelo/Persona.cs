using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_y_Cola
{
    class Persona
    {

        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()//sobresecribir el metodo 
        {
            return String.Format("Nombre: {0}", Nombre);
        }

    }//fin de la clase 
}//fin del namespace
