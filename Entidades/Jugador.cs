using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : BusinessEntity
    {
        private int nroCamiseta;

        public int NroCamiseta
        {
            get { return nroCamiseta; }
            set { nroCamiseta = value; }
        }


        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private List<Partido> partidos;

        public List<Partido> Partidos
        {
            get { return partidos; }
            set { partidos = value; }
        }

        private int asistencia;

        public int Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }


        private int goles;

        public int Goles
        {
            get { return goles; }
            set { goles = value; }
        }


        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Jugador()
        {

        }
    }
}
