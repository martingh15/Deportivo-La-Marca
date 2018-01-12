using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido : BusinessEntity
    {
        private List<String> expulsados;
        private List<String> goles;
        private List<String> listaAsistencia;
        private String rival;
        private int golesAFavor;
        private int golesEnContra;
        private string descripcion;
        private int nroPartido;
        private DateTime fecha; 
        public int NroPartido { get { return nroPartido; } set { nroPartido = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public List<String> Expulsados { get { return expulsados; } set { expulsados = value; } }
        public List<String> Goles { get { return goles; } set { goles = value; } }
        public String Rival { get { return rival; } set { rival = value; } }
        public int GolesAFavor { get { return golesAFavor; } set { golesAFavor = value; } }
        public int GolesEnContra { get { return golesEnContra; } set { golesEnContra = value; } }
        public List<String> ListaAsistencia { get { return listaAsistencia; } set { listaAsistencia = value; } }
        public Partido()
        {
            goles = new List<String>();
            expulsados = new List<String>();
            listaAsistencia = new List<String>();
        }

        public Partido(String contrario, DateTime fechaP) : this()
        {
            Rival = contrario;
        }

    }
}
