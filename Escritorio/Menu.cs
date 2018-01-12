using System.Windows.Forms;
using Entidades;
using System.Drawing;

namespace Escritorio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void jugadoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Jugadores ventanaJugadores = new Escritorio.Jugadores();
            ventanaJugadores.Visible = true;
        }

        private void partidosToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Partidos ventanaPartidos = new Partidos();
            ventanaPartidos.Visible = true;
        }
    }
}