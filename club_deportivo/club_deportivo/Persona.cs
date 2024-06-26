using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo
{
    public class Persona
    {

        public int idPersona;
        public string nombre;
        public string apellido;
        public int dNI;

        public Persona(string nombre, string apellido, int dNI)
        {
            //IdPersona = 0;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int DNI { get => dNI; set => dNI = value; }
    }

}
