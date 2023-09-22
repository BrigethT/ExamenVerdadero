using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMateria
{

    public class Facultad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Id_Decano { get; set; }

        public Facultad(int idfac, string nombre, int iddec)
        {
            this.Id = idfac;
            this.Nombre = nombre;
            this.Id_Decano = iddec;
        }
        public Facultad() { }

        public override string ToString()
        {
            return Nombre;
        }
    }

}
