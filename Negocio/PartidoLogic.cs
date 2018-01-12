using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class PartidoLogic
    {
        private Datos.PartidoAdapter partidoData;

        public Datos.PartidoAdapter PartidoData
        {
            get { return partidoData; }
            set { partidoData = value; }
        }

        public PartidoLogic()
        {
            PartidoData = new Datos.PartidoAdapter();
        }

        public List<Partido> GetAll()
        {
            return PartidoData.GetAll();
        }

        public void Delete(int ID)
        {
            PartidoData.Delete(ID);
        }

        public void Save(Partido jug)
        {
            PartidoData.Save(jug);
        }

        public Partido GetOne(int ID)
        {
            return PartidoData.GetOne(ID);
        }

        public List<string> getAsistencias(int nroPartido)
        {
            return PartidoData.getAsistencias(nroPartido);
        }
    }
}
