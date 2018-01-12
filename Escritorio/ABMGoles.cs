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
    public partial class ABMGoles : ApplicationForm
    {
        JugadorLogic jugadorData;
        List<Jugador> jugadores;
        public ABMGoles()
        {
            InitializeComponent();
            jugadorData = new JugadorLogic();
            jugadores = new List<Jugador>();
            
        }

        private static List<String> listaGoles = new List<string>();

        public static List<String> ListaGoles
        {
            get { return listaGoles; }
            set { listaGoles = value; }
        }

        private static bool golesCargados = false;

        public static bool GolesCargados
        {
            get { return golesCargados; }
            set { golesCargados = value; }
        }


        private int golesAFavor;

        public int GolesAFavor
        {
            get { return golesAFavor; }
            set { golesAFavor = value; }
        }

        public ABMGoles(int golesF, ModoForm mod) : this()
        {
            GolesAFavor = golesF;
            this.Modo = mod;
        }


        private void ABMGoles_Load(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta)
            {
                btnGoles.Text = "Agregar goles";
            }
            if (Modo == ModoForm.Modificacion)
            {
                btnGoles.Text = "Modificar goles";
            }
            if (Modo == ModoForm.Baja)
            {
                this.Notificar("Alerta", "Ingreso opcion de borrar partido, no esta autorizado a ingresar aqui", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            txtCantGoles.Text = GolesAFavor.ToString();
            if(GolesAFavor == 0)
            {
                this.Notificar("Alerta", "No hay goles para cargar",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                ABMGoles.GolesCargados = true;
                this.Dispose();
            }
            EsconderItemsSinUsar(GolesAFavor);
            ObtenerDatosParaCombos(GolesAFavor);
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void EsconderItemsSinUsar(int goles)
        {
            switch(goles)
            {
                case 1:
                    cmbGol2.Visible = false;
                    lblGol2.Visible = false;
                    cmbGol3.Visible = false;
                    lblGol3.Visible = false;
                    cmbGol4.Visible = false;
                    lblGol4.Visible = false;
                    cmbGol5.Visible = false;
                    lblGol5.Visible = false;
                    cmbGol6.Visible = false;
                    lblGol6.Visible = false;
                    cmbGol7.Visible = false;
                    lblGol7.Visible = false;
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 2:
                    cmbGol3.Visible = false;
                    lblGol3.Visible = false;
                    cmbGol4.Visible = false;
                    lblGol4.Visible = false;
                    cmbGol5.Visible = false;
                    lblGol5.Visible = false;
                    cmbGol6.Visible = false;
                    lblGol6.Visible = false;
                    cmbGol7.Visible = false;
                    lblGol7.Visible = false;
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 3:
                    cmbGol4.Visible = false;
                    lblGol4.Visible = false;
                    cmbGol5.Visible = false;
                    lblGol5.Visible = false;
                    cmbGol6.Visible = false;
                    lblGol6.Visible = false;
                    cmbGol7.Visible = false;
                    lblGol7.Visible = false;
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 4:
                    cmbGol5.Visible = false;
                    lblGol5.Visible = false;
                    cmbGol6.Visible = false;
                    lblGol6.Visible = false;
                    cmbGol7.Visible = false;
                    lblGol7.Visible = false;
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 5:
                    cmbGol6.Visible = false;
                    lblGol6.Visible = false;
                    cmbGol7.Visible = false;
                    lblGol7.Visible = false;
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 6:
                    cmbGol7.Visible = false;
                    lblGol7.Visible = false;
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 7:
                    cmbGol8.Visible = false;
                    lblGol8.Visible = false;
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 8:
                    cmbGol9.Visible = false;
                    lblGol9.Visible = false;
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 9:
                    cmbGol10.Visible = false;
                    lblGol10.Visible = false;
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 10:
                    cmbGol11.Visible = false;
                    lblGol11.Visible = false;
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 11:
                    cmbGol12.Visible = false;
                    lblGol12.Visible = false;
                    break;
                case 12:
                    break;
                default:
                    break;
            }
        }

        public void ObtenerDatosParaCombos(int goles)
        {
            jugadores = jugadorData.GetAll();

            cmbGol1.Items.Add("autogol");
            cmbGol2.Items.Add("autogol");
            cmbGol3.Items.Add("autogol");
            cmbGol4.Items.Add("autogol");
            cmbGol5.Items.Add("autogol");
            cmbGol6.Items.Add("autogol");
            cmbGol7.Items.Add("autogol");
            cmbGol8.Items.Add("autogol");
            cmbGol9.Items.Add("autogol");
            cmbGol10.Items.Add("autogol");
            cmbGol11.Items.Add("autogol");
            cmbGol12.Items.Add("autogol");

            switch (goles)
            {
                case 1:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                    }
                    break;
                case 2:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                    }
                    break;
                case 3:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                    }
                    break;
                case 4:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                    }
                    break;
                case 5:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                    }
                    break;
                case 6:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                    }
                    break;
                case 7:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                        cmbGol7.Items.Add(jug.Nombre);
                    }
                    break;
                case 8:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                        cmbGol7.Items.Add(jug.Nombre);
                        cmbGol8.Items.Add(jug.Nombre);
                    }
                    break;
                case 9:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                        cmbGol7.Items.Add(jug.Nombre);
                        cmbGol8.Items.Add(jug.Nombre);
                        cmbGol9.Items.Add(jug.Nombre);
                    }
                    break;
                case 10:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                        cmbGol7.Items.Add(jug.Nombre);
                        cmbGol8.Items.Add(jug.Nombre);
                        cmbGol9.Items.Add(jug.Nombre);
                        cmbGol10.Items.Add(jug.Nombre);
                    }
                    break;
                case 11:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                        cmbGol7.Items.Add(jug.Nombre);
                        cmbGol8.Items.Add(jug.Nombre);
                        cmbGol9.Items.Add(jug.Nombre);
                        cmbGol10.Items.Add(jug.Nombre);
                        cmbGol11.Items.Add(jug.Nombre);
                    }
                    break;
                case 12:
                    foreach (Jugador jug in jugadores)
                    {
                        cmbGol1.Items.Add(jug.Nombre);
                        cmbGol2.Items.Add(jug.Nombre);
                        cmbGol3.Items.Add(jug.Nombre);
                        cmbGol4.Items.Add(jug.Nombre);
                        cmbGol5.Items.Add(jug.Nombre);
                        cmbGol6.Items.Add(jug.Nombre);
                        cmbGol7.Items.Add(jug.Nombre);
                        cmbGol8.Items.Add(jug.Nombre);
                        cmbGol9.Items.Add(jug.Nombre);
                        cmbGol10.Items.Add(jug.Nombre);
                        cmbGol11.Items.Add(jug.Nombre);
                        cmbGol12.Items.Add(jug.Nombre);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnGoles_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cargar los goles de esa manera?", "Pregunta", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes && golesCargados == false)
            {

                if (this.Modo == ModoForm.Modificacion)
                {
                    this.Notificar("Alerta", "Se ha borrado la lista de goles del partido, creela de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ABMGoles.ListaGoles = new List<String>();
                }
                CargarGolesALista(GolesAFavor);
                ABMGoles.GolesCargados = true;
                this.Dispose();                
            }
            if(ABMGoles.GolesCargados)
            {
                this.Notificar("Alerta", "Ya cargaste los goles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        public void CargarGolesALista(int goles)
        {
            switch(goles)
            {
                case 1:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    break;
                case 2:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    break;
                case 3:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    break;
                case 4:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    break;
                case 5:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    break;
                case 6:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    break;
                case 7:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol7.SelectedItem.ToString());
                    break;
                case 8:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol7.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol8.SelectedItem.ToString());
                    break;
                case 9:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol7.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol8.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol9.SelectedItem.ToString());
                    break;
                case 10:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol7.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol8.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol9.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol10.SelectedItem.ToString());
                    break;
                case 11:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol7.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol8.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol9.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol10.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol11.SelectedItem.ToString());
                    break;
                case 12:
                    ABMGoles.ListaGoles.Add(cmbGol1.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol2.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol3.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol4.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol5.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol6.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol7.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol8.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol9.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol10.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol11.SelectedItem.ToString());
                    ABMGoles.ListaGoles.Add(cmbGol12.SelectedItem.ToString());
                    break;
            }
        }

        public static List<String> GetListaGoles()
        {
            return ListaGoles;
        }

    }
}
