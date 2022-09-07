using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaIRUSTA.Entidades
{
    public class Tipo
    {
        public string Nombre { get; set; }

        public Tipo()
        {
            Nombre = "";
        }

        public Tipo(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
