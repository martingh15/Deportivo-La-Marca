using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class ABMExpulsados : ApplicationForm
    {
        JugadorLogic jugadorData;
        List<Jugador> jugadores;
        public ABMExpulsados()
        {
            InitializeComponent();
            jugadorData = new JugadorLogic();
            jugadores = new List<Jugador>();
        }

        public ABMExpulsados(int cantidad) : this()
        {
            this.CantidadExpulsados = cantidad;
        }

        private static bool registroExpulsados = false;

        public static bool RegistroExpulsados
        {
            get { return registroExpulsados; }
            set { registroExpulsados = value; }
        }

        private static List<String> listaExpulsados = new List<String>();

        public static List<String> ListaExpulsados
        {
            get { return listaExpulsados; }
            set { listaExpulsados = value; }
        }



        private int cantidadExpulsados;

        public int CantidadExpulsados
        {
            get { return cantidadExpulsados; }
            set { cantidadExpulsados = value; }
        }

        private void ABMExpulsados_Load(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta)
            {
                btnExpulsados.Text = "Agregar Expulsados";
            }
            if (Modo == ModoForm.Modificacion)
            {
                btnExpulsados.Text = "Modificar Expulsados";
            }
            if (Modo == ModoForm.Baja)
            {
                this.Notificar("Alerta", "Ingreso opcion de borrar partido, no esta autorizado a ingresar aqui", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            if (CantidadExpulsados == 0)
            {
                ABMExpulsados.RegistroExpulsados = true;
                this.Notificar("Alerta", "No hubo expulsados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

            EsconderItemsSinUsar(CantidadExpulsados);
            ObtenerDatosParaCombos(CantidadExpulsados);
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void EsconderItemsSinUsar(int cantidad)
        {
            switch (cantidad)
            {
                case 1:
                    lblExpulsado2.Visible = false;
                    cmbExpulsado2.Visible = false;
                    lblExpulsado3.Visible = false;
                    cmbExpulsado3.Visible = false;
                    lblExpulsado4.Visible = false;
                    cmbExpulsado4.Visible = false;
                    break;
                case 2:
                    lblExpulsado3.Visible = false;
                    cmbExpulsado3.Visible = false;
                    lblExpulsado4.Visible = false;
                    cmbExpulsado4.Visible = false;
                    break;
                case 3:
                    lblExpulsado4.Visible = false;
                    cmbExpulsado4.Visible = false;
                    break;
                default:
                    break;
            }
        }

        public void ObtenerDatosParaCombos(int cantidad)
        {
            jugadores = jugadorData.GetAll();

            switch (cantidad)
            {
                case 1:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbExpulsado1.Items.Add(jug.Nombre);
                    }
                    break;
                case 2:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbExpulsado1.Items.Add(jug.Nombre);
                        cmbExpulsado2.Items.Add(jug.Nombre);
                    }
                    break;
                case 3:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbExpulsado1.Items.Add(jug.Nombre);
                        cmbExpulsado2.Items.Add(jug.Nombre);
                        cmbExpulsado3.Items.Add(jug.Nombre);
                    }
                    break;
                case 4:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbExpulsado1.Items.Add(jug.Nombre);
                        cmbExpulsado2.Items.Add(jug.Nombre);
                        cmbExpulsado3.Items.Add(jug.Nombre);
                        cmbExpulsado4.Items.Add(jug.Nombre);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnExpulsados_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pregunta", "Seguro que desea cargar los expulsados de esa manera?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes && ABMExpulsados.RegistroExpulsados == false)
            {

                if (this.Modo == ModoForm.Modificacion)
                {
                    this.Notificar("Alerta", "Se ha borrado la lista de expulsados, creela de nuevo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    ABMExpulsados.ListaExpulsados = new List<String>();
                }
                CargarExpulsadosALista(CantidadExpulsados);
                ABMExpulsados.RegistroExpulsados = true;
                this.Dispose();
            }
            if (ABMExpulsados.RegistroExpulsados)
            {
                this.Notificar("Alerta", "Ya cargaste los expulsados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        public void CargarExpulsadosALista(int cantidad)
        {
            switch (cantidad)
            {
                case 1:
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado1.SelectedItem.ToString());
                    break;
                case 2:
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado1.SelectedItem.ToString());
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado2.SelectedItem.ToString());
                    break;
                case 3:
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado1.SelectedItem.ToString());
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado2.SelectedItem.ToString());
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado3.SelectedItem.ToString());
                    break;
                case 4:
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado1.SelectedItem.ToString());
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado2.SelectedItem.ToString());
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado3.SelectedItem.ToString());
                    ABMExpulsados.ListaExpulsados.Add(cmbExpulsado4.SelectedItem.ToString());
                    break;
            }
        }

        public static List<String> GetExpulsados()
        {
            return ABMExpulsados.ListaExpulsados;
        }
    }
}
