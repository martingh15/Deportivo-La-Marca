using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Escritorio
{
    public partial class Jugadores : Form
    {
        JugadorLogic jug = new JugadorLogic();

        private Jugador jugadorActual;

        public Jugador JugadorActual
        {
            get { return jugadorActual; }
            set { jugadorActual = value; }
        }

        public Jugadores()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            dgvJugadores.DataSource = jug.GetAll();
            JugadorActual = new Jugador();
        }

        public void Listar()
        {
            dgvJugadores.DataSource = jug.GetAll();
        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMJugadores abm = new ABMJugadores();
            abm.Visible = true;
            abm.Modo = ABMJugadores.ModoForm.Alta;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvJugadores.DataSource = jug.GetAll();
        }

        private void editarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Jugador)this.dgvJugadores.SelectedRows[0].DataBoundItem).NroCamiseta;
            ABMJugadores abm = new ABMJugadores(ID);
            abm.ShowDialog();
            this.Listar();
        }

        private void borrarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Jugador)this.dgvJugadores.SelectedRows[0].DataBoundItem).NroCamiseta;
            ABMJugadores abm = new ABMJugadores(ID);
            abm.Modo = ABMJugadores.ModoForm.Baja;
            abm.ShowDialog();            
            this.Listar();
        }
    }
}
