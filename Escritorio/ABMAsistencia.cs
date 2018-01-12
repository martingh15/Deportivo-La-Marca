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
    public partial class ABMAsistencia : ApplicationForm
    {
        public ABMAsistencia()
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
            jugadorData = new JugadorLogic();
        }

        JugadorLogic jugadorData;
        List<Jugador> jugadores;

        private static List<String> listaAsistencia = new List<string>();

        public static List<String> ListaAsistencia
        {
            get { return listaAsistencia; }
            set { listaAsistencia = value; }
        }

        private static bool asistenciaTomada = false;

        public static bool AsistenciaTomada
        {
            get { return asistenciaTomada; }
            set { asistenciaTomada = value; }
        }


        private int cantidadJugadores;

        public int CantidadJugadores
        {
            get { return cantidadJugadores; }
            set { cantidadJugadores = value; }
        }

        public ABMAsistencia(int cant, ModoForm mod) : this()
        {
            CantidadJugadores = cant;
            this.Modo = mod;
        }

        public static List<String> GetListaAsistencia()
        {
            return ListaAsistencia;
        }

        private void ABMAsistencia_Load_1(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta)
            {
                btnAsistencia.Text = "Listar jugadores";
            }
            if (Modo == ModoForm.Modificacion)
            {
                btnAsistencia.Text = "Modificar lista de asistencia";
            }
            if (Modo == ModoForm.Baja)
            {
                this.Notificar("Alerta", "Ingreso opcion de borrar partido, no esta autorizado a ingresar aqui", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            if (CantidadJugadores == 0)
            {
                ABMAsistencia.AsistenciaTomada= true;
                this.Notificar("Alerta", "No se presento el otro equipo, no hay que registrar asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            txtCantJugadores.Text = CantidadJugadores.ToString();
            EsconderItemsSinUsar(CantidadJugadores);
            ObtenerDatosParaCombos(CantidadJugadores);
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
                    cmbAs2.Visible = false;
                    lblAs2.Visible = false;
                    cmbAs3.Visible = false;
                    lblAs3.Visible = false;
                    cmbAs4.Visible = false;
                    lblAs4.Visible = false;
                    cmbAs5.Visible = false;
                    lblAs5.Visible = false;
                    cmbAs6.Visible = false;
                    lblAs6.Visible = false;
                    cmbAs7.Visible = false;
                    lblAs7.Visible = false;
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 2:
                    cmbAs3.Visible = false;
                    lblAs3.Visible = false;
                    cmbAs4.Visible = false;
                    lblAs4.Visible = false;
                    cmbAs5.Visible = false;
                    lblAs5.Visible = false;
                    cmbAs6.Visible = false;
                    lblAs6.Visible = false;
                    cmbAs7.Visible = false;
                    lblAs7.Visible = false;
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 3:
                    cmbAs4.Visible = false;
                    lblAs4.Visible = false;
                    cmbAs5.Visible = false;
                    lblAs5.Visible = false;
                    cmbAs6.Visible = false;
                    lblAs6.Visible = false;
                    cmbAs7.Visible = false;
                    lblAs7.Visible = false;
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 4:
                    cmbAs5.Visible = false;
                    lblAs5.Visible = false;
                    cmbAs6.Visible = false;
                    lblAs6.Visible = false;
                    cmbAs7.Visible = false;
                    lblAs7.Visible = false;
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 5:
                    cmbAs6.Visible = false;
                    lblAs6.Visible = false;
                    cmbAs7.Visible = false;
                    lblAs7.Visible = false;
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 6:
                    cmbAs7.Visible = false;
                    lblAs7.Visible = false;
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 7:
                    cmbAs8.Visible = false;
                    lblAs8.Visible = false;
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 8:
                    cmbAs9.Visible = false;
                    lblAs9.Visible = false;
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 9:
                    cmbAs10.Visible = false;
                    lblAs10.Visible = false;
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 10:
                    cmbAs11.Visible = false;
                    lblAs11.Visible = false;
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 11:
                    cmbAs12.Visible = false;
                    lblAs12.Visible = false;
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 12:
                    cmbAs13.Visible = false;
                    lblAs13.Visible = false;
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 13:
                    cmbAs14.Visible = false;
                    lblAs14.Visible = false;
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 14:
                    cmbAs15.Visible = false;
                    lblAs15.Visible = false;
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 15:
                    cmbAs16.Visible = false;
                    lblAs16.Visible = false;
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
                    break;
                case 16:
                    cmbAs17.Visible = false;
                    lblAs17.Visible = false;
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
                        cmbAs1.Items.Add(jug.Nombre);
                    }
                    break;
                case 2:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                    }
                    break;
                case 3:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                    }
                    break;
                case 4:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                    }
                    break;
                case 5:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                    }
                    break;
                case 6:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                    }
                    break;
                case 7:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                    }
                    break;
                case 8:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                    }
                    break;
                case 9:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                    }
                    break;
                case 10:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                    }
                    break;
                case 11:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                    }
                    break;
                case 12:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                        cmbAs12.Items.Add(jug.Nombre);
                    }
                    break;
                case 13:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                        cmbAs12.Items.Add(jug.Nombre);
                        cmbAs13.Items.Add(jug.Nombre);
                    }
                    break;
                case 14:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                        cmbAs12.Items.Add(jug.Nombre);
                        cmbAs13.Items.Add(jug.Nombre);
                        cmbAs14.Items.Add(jug.Nombre);
                    }
                    break;
                case 15:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                        cmbAs12.Items.Add(jug.Nombre);
                        cmbAs13.Items.Add(jug.Nombre);
                        cmbAs14.Items.Add(jug.Nombre);
                        cmbAs15.Items.Add(jug.Nombre);
                    }
                    break;
                case 16:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                        cmbAs12.Items.Add(jug.Nombre);
                        cmbAs13.Items.Add(jug.Nombre);
                        cmbAs14.Items.Add(jug.Nombre);
                        cmbAs15.Items.Add(jug.Nombre);
                        cmbAs16.Items.Add(jug.Nombre);
                    }
                    break;
                case 17:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbAs1.Items.Add(jug.Nombre);
                        cmbAs2.Items.Add(jug.Nombre);
                        cmbAs3.Items.Add(jug.Nombre);
                        cmbAs4.Items.Add(jug.Nombre);
                        cmbAs5.Items.Add(jug.Nombre);
                        cmbAs6.Items.Add(jug.Nombre);
                        cmbAs7.Items.Add(jug.Nombre);
                        cmbAs8.Items.Add(jug.Nombre);
                        cmbAs9.Items.Add(jug.Nombre);
                        cmbAs10.Items.Add(jug.Nombre);
                        cmbAs11.Items.Add(jug.Nombre);
                        cmbAs12.Items.Add(jug.Nombre);
                        cmbAs13.Items.Add(jug.Nombre);
                        cmbAs14.Items.Add(jug.Nombre);
                        cmbAs15.Items.Add(jug.Nombre);
                        cmbAs16.Items.Add(jug.Nombre);
                        cmbAs17.Items.Add(jug.Nombre);
                    }
                    break;
                default:
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pregunta", "Seguro que asisieron todos esos jugadores?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes && asistenciaTomada == false)
            {

                if (this.Modo == ModoForm.Modificacion)
                {
                    this.Notificar("Alerta", "Se ha borrado la lista de asistencia del partido, creela de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ABMAsistencia.ListaAsistencia = new List<String>();
                }
                CargarJugadoresALista(CantidadJugadores);
                ABMAsistencia.AsistenciaTomada = true;
                this.Dispose();
            }
            if (ABMAsistencia.AsistenciaTomada)
            {
                this.Notificar("Alerta", "Ya cargaste la asistencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        public void CargarJugadoresALista(int cantidad)
        {
            switch (cantidad)
            {
                
                case 4:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    break;
                case 5:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    break;
                case 6:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    break;
                case 7:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    break;
                case 8:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    break;
                case 9:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    break;
                case 10:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    break;
                case 11:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    break;
                case 12:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    break;
                case 13:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    break;
                case 14:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    break;
                case 15:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs15.SelectedItem.ToString());
                    break;
                case 16:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs15.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs16.SelectedItem.ToString());
                    break;
                case 17:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs15.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs16.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs17.SelectedItem.ToString());
                    break;
                default:
                    this.Notificar("Alerta", "Hubo un error en el switch, llame a Mark", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pregunta", "Seguro que desea cargar la asistencia de esa manera?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes && ABMAsistencia.AsistenciaTomada== false)
            {

                if (this.Modo == ModoForm.Modificacion)
                {
                    this.Notificar("Alerta", "Se ha borrado la lista de asistencia, creela de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ABMAsistencia.ListaAsistencia = new List<String>();
                }
                CargarAsistenciaALista(CantidadJugadores);
                ABMAsistencia.AsistenciaTomada = true;
                this.Dispose();
            }
            if (ABMAsistencia.AsistenciaTomada)
            {
                this.Notificar("Alerta", "Ya cargaste la asistencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        public void CargarAsistenciaALista(int cantidad)
        {
            switch (cantidad)
            {
                case 1:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    break;
                case 2:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    break;
                case 3:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    break;
                case 4:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    break;
                case 5:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    break;
                case 6:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    break;
                case 7:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    break;
                case 8:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    break;
                case 9:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    break;
                case 10:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    break;
                case 11:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    break;
                case 12:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    break;
                case 13:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    break;
                case 14:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    break;
                case 15:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs15.SelectedItem.ToString());
                    break;
                case 16:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs15.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs16.SelectedItem.ToString());
                    break;
                case 17:
                    ABMAsistencia.ListaAsistencia.Add(cmbAs1.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs2.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs3.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs4.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs5.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs6.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs7.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs8.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs9.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs10.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs11.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs12.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs13.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs14.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs15.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs16.SelectedItem.ToString());
                    ABMAsistencia.ListaAsistencia.Add(cmbAs17.SelectedItem.ToString());
                    break;
            }
        }
        
    }
}
