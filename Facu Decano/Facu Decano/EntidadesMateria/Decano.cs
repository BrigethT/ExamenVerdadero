using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMateria
{
    public class Decano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Decano() { }
        public Decano(int idnew, string nombre, string apellido)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Id = idnew;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}

