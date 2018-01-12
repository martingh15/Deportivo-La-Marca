using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class JugadorLogic
    {
        private Datos.JugadorAdapter jugadorData;

        public Datos.JugadorAdapter JugadorData
        {
            get { return jugadorData; }
            set { jugadorData = value; }
        }
        public JugadorLogic()
        {
            JugadorData = new Datos.JugadorAdapter();
        }

        public List<Jugador> GetAll()
        {
            return JugadorData.GetAll();
        }

        public void Delete(int ID)
        {
            JugadorData.Delete(ID);
        }

        public void Save(Jugador jug)
        {
            JugadorData.Save(jug);
        }

        public Jugador GetOne(int ID)
        {
            return JugadorData.GetOne(ID);
        }

        public void ActualizaGoles(List<string> goles, int nro_partido)
        {

            foreach (String str in goles)
            {
                SumarGoles(str);
                AgregarTablaGoles(str, nro_partido);               
            }
        }

        public void SumarGoles(string nombre)
        {
            if (nombre != "autogol")
            {
                Jugador jugActual = JugadorData.GetOne(nombre);
                jugActual.Goles = jugActual.Goles + 1;
                JugadorData.Update(jugActual);
            } 
        }

        public void AgregarTablaGoles(string nombre, int nro_partido)
        {
            int cant = JugadorData.GetAllGoals();
            cant++;
            if(nombre != "autogol")
            {
                Jugador jugActual = JugadorData.GetOne(nombre);
                JugadorData.AgregarGol(cant, jugActual.NroCamiseta, nro_partido);
            }
            else
            {
                JugadorData.AgregarGol(cant, 0, nro_partido);
            }
        }

        public void SaveAsistencias(List<string> listaAsistencia, int nroPartido)
        {
            foreach (String str in listaAsistencia)
            {
                SumarAsistencia(str);
                AgregarTablaAsistencia(str, nroPartido);
            }
        }

        private void AgregarTablaAsistencia(string nombre, int nroPartido)
        {
            Jugador jugActual = JugadorData.GetOne(nombre);
            JugadorData.AgregarAsistencia(jugActual.NroCamiseta, nroPartido);
        }

        private void SumarAsistencia(string nombre)
        {
            Jugador jugActual = JugadorData.GetOne(nombre);
            jugActual.Asistencia = jugActual.Asistencia + 1;
            JugadorData.Update(jugActual);
        }
    }
}
