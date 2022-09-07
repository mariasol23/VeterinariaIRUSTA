using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaIRUSTA.Entidades
{
    public class Atencion : Mascota
    {
        public int Id_atencion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public Atencion() : base()
        {

        }


        public override string ToString()
        {
            return "Fecha: " + Fecha + " | Descripcion: " + Descripcion + " | Importe: " + Importe;
        }
    }
}
