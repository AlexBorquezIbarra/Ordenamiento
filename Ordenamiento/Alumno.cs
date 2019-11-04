using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Alumno
    {
        public string nombre { get; set; }
        public float promedio { get; set; }
        public int faltas { get; set; }

        public Alumno(string Nombre, float Promedio, int Faltas)
        {
            this.nombre = Nombre;
            this.promedio = Promedio;
            this.faltas = Faltas;
        }

        public override string ToString()
        {
            return this.nombre + "(" + this.promedio.ToString() + ")";
        }
    }
}
