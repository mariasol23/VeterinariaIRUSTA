using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaIRUSTA.Entidades
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Codigo { get; set; }
        public Mascota Mascota { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, string sexo, int codigo, Mascota mascota)
        {
            Nombre = nombre;
            Apellido = Apellido;
            Sexo = sexo;
            Codigo = codigo;
            Mascota = new Mascota();
        }

        public override string ToString()
        {
            return  "Codigo: " + Codigo + "   | Nombre : " + Apellido + ", " + Nombre;
        }
    }
}
