using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaIRUSTA.Entidades
{
    public class Mascota
    {
        public List<Atencion> Atenciones { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Tipo Tipo { get; set; }        

        public Mascota()
        {
            Nombre = "";
            Edad = 0;
            Tipo = new Tipo();
            Atenciones = new List<Atencion>();
        }

        Mascota(string nombre, int edad, Tipo tipo, List<Atencion> atenciones)
        {
            Nombre = nombre;
            Edad = edad;
            Tipo = new Tipo();
            Atenciones = new List<Atencion>();
        }

        public void RegistrarAtencion(Atencion atencion)
        {
            Atenciones.Add(atencion);
        }

        public void EliminarAtencion(int id)
        {
            Atenciones.RemoveAt(id);
        }
    }
}
