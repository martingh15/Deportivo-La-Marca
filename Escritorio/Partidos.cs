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
    public partial class Partidos : Form
    {
        PartidoLogic part = new PartidoLogic();

        private Partido partidoActual;

        public Partido PartidoActual
        {
            get { return partidoActual; }
            set { partidoActual = value; }
        }
        public Partidos()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            dgvPartidos.DataSource = part.GetAll();
            PartidoActual = new Partido();
        }

        public void Listar()
        {
            dgvPartidos.DataSource = part.GetAll();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMPartidos abm = new ABMPartidos();
            abm.ShowDialog();
            abm.Modo = ABMPartidos.ModoForm.Alta;
            this.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Partido)this.dgvPartidos.SelectedRows[0].DataBoundItem).NroPartido;
            ABMPartidos abm = new ABMPartidos(ID, ApplicationForm.ModoForm.Modificacion);
            abm.ShowDialog();
            abm.Modo = ABMPartidos.ModoForm.Modificacion;
            this.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Partido)this.dgvPartidos.SelectedRows[0].DataBoundItem).NroPartido;
            ABMPartidos abm = new ABMPartidos(ID, ApplicationForm.ModoForm.Baja);
            abm.ShowDialog();
            this.Listar();
        }
    }
}
