using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    internal class Persona
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private int celular;
        public int Celular
        { 
            get { return celular; }
            set { celular = value; } 
        }

        private int ci;
        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
