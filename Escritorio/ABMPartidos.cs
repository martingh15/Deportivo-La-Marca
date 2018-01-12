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
    public partial class ABMPartidos : ApplicationForm
    {
        PartidoLogic partidoLogic;
        JugadorLogic jugadorLogic;
        List<Partido> partidos;
        private Partido partidoActual;

        public Partido PartidoActual
        {
            get { return partidoActual; }
            set { partidoActual = value; }
        }
        public ABMPartidos()
        {
            InitializeComponent();
            partidoLogic = new PartidoLogic();
            partidos = new List<Partido>();
            partidoActual = new Partido();
            jugadorLogic = new JugadorLogic();
        }


        public ABMPartidos(int ID, ApplicationForm.ModoForm modo) : this()
        {
            this.Modo = modo;
            this.PartidoActual = partidoLogic.GetOne(ID);
            // Cargo los datos que no son arreglos (goles, expulsados y asistencia)
            // los arreglos se cargan en ABMPartidos_Load
            this.txtNroPartido.Text = PartidoActual.NroPartido.ToString();
            this.txtDescripcion.Text = PartidoActual.Descripcion;
            this.txtFecha.Text = PartidoActual.Fecha.ToString();
            this.txtRival.Text = PartidoActual.Rival;
            this.txtGolesAFavor.Text = PartidoActual.GolesAFavor.ToString();
            this.txtGolesEnContra.Text = PartidoActual.GolesEnContra.ToString();
        }

        private void ABMPartidos_Load(object sender, EventArgs e)
        {
            ABMGoles.ListaGoles = new List<String>();
            ABMAsistencia.ListaAsistencia = new List<String>();
            ABMExpulsados.ListaExpulsados = new List<String>();
            if (Modo == ModoForm.Alta)
            {
                button.Text = "Agregar Partido";
            }
            if (Modo == ModoForm.Modificacion)
            {
                button.Text = "Modificar Partido";
                ABMAsistencia.ListaAsistencia = partidoLogic.getAsistencias(PartidoActual.NroPartido);
                this.txtCantJugadores.Text = ABMAsistencia.ListaAsistencia.Count.ToString();
            }
            if (Modo == ModoForm.Baja)
            {
                button.Text = "Borrar Partido";
                this.txtDescripcion.Enabled = false;
                this.txtExpulsados.Enabled = false;
                this.txtFecha.Enabled = false;
                this.txtGolesAFavor.Enabled = false;
                this.txtGolesEnContra.Enabled = false;
                this.txtNroPartido.Enabled = false;
                this.txtRival.Enabled = false;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Modo == ModoForm.Alta) AgregarPartido();
                if (Modo == ModoForm.Modificacion) ModificarPartido();
            }
            if (Modo == ModoForm.Baja) BorrarPartido();
            this.Dispose();
        }

        public void AgregarPartido()
        {

            PartidoActual.State = BusinessEntity.States.New;
            PartidoActual.NroPartido = Int32.Parse(txtNroPartido.Text);
            PartidoActual.Descripcion = txtDescripcion.Text;
            PartidoActual.Fecha = DateTime.Parse(txtFecha.Text);
            PartidoActual.Rival = txtRival.Text;
            PartidoActual.GolesAFavor = Int32.Parse(txtGolesAFavor.Text);
            PartidoActual.GolesEnContra = Int32.Parse(txtGolesEnContra.Text);
            if (ABMGoles.GolesCargados)
            {
                PartidoActual.Goles = ABMGoles.GetListaGoles();
            }
            else
            {
                this.Notificar("Alerta", "Falta registrar los goles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ABMExpulsados.RegistroExpulsados)
            {
                PartidoActual.Expulsados = ABMExpulsados.GetExpulsados();
            }
            else
            {
                this.Notificar("Alerta", "Falta registrar si hubo expulsados y quienes fueron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(ABMAsistencia.AsistenciaTomada)
            {
                PartidoActual.ListaAsistencia = ABMAsistencia.GetListaAsistencia();
            }
            else
            {
                this.Notificar("Alerta", "Falta registrar la asistencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (Int32.Parse(txtCantJugadores.Text) == 0)
            {
                ABMAsistencia.AsistenciaTomada = true;
                this.Notificar("Mensaje", "No se presento el otro equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(Int32.Parse(txtExpulsados.Text) == 0)
            {
                ABMExpulsados.RegistroExpulsados = true;
                this.Notificar("Mensaje", "No hubo expulsados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ABMGoles.GolesCargados && ABMExpulsados.RegistroExpulsados && ABMAsistencia.AsistenciaTomada)
            {
                //Guarda en la tabla partidos
                partidoLogic.Save(PartidoActual);
                //Guarda en la tabla jugadores y goles
                jugadorLogic.ActualizaGoles(PartidoActual.Goles, PartidoActual.NroPartido);
                //Guarda en la tabla jugadores y asistencia
                jugadorLogic.SaveAsistencias(PartidoActual.ListaAsistencia, PartidoActual.NroPartido);

                this.Notificar("Excelente", "Ha cargado el partido con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Notificar("Faltan datos", "Agregue lo que haga falta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void ModificarPartido()
        {
            PartidoActual.State = BusinessEntity.States.Modified;
            PartidoActual.NroPartido = Int32.Parse(txtNroPartido.Text);
            PartidoActual.Descripcion = txtDescripcion.Text;
            PartidoActual.Fecha = DateTime.Parse(txtFecha.Text);
            PartidoActual.Rival = txtRival.Text;
            PartidoActual.GolesAFavor = Int32.Parse(txtGolesAFavor.Text);
            PartidoActual.GolesEnContra = Int32.Parse(txtGolesEnContra.Text);
            PartidoActual.Goles = ABMGoles.GetListaGoles();
            if (PartidoActual.Goles != null)
            {
                ABMGoles.GolesCargados= true;
            }
            else
            {
                ABMGoles.GolesCargados = false;
                this.Notificar("Alerta", "Falta registrar los goles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ABMExpulsados.RegistroExpulsados)
            {
                PartidoActual.Expulsados = ABMExpulsados.GetExpulsados();
            }
            else
            {
                this.Notificar("Alerta", "Falta registrar si hubo expulsados y quienes fueron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ABMAsistencia.AsistenciaTomada)
            {
                PartidoActual.ListaAsistencia = ABMAsistencia.GetListaAsistencia();
            }
            else
            {
                this.Notificar("Alerta", "Falta registrar la asistencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (ABMGoles.GolesCargados && ABMExpulsados.RegistroExpulsados && ABMAsistencia.AsistenciaTomada)
            {
                //Guarda en la tabla partidos
                partidoLogic.Save(PartidoActual);
                //Guarda en la tabla jugadores y goles
                jugadorLogic.ActualizaGoles(PartidoActual.Goles,PartidoActual.NroPartido);
                //Guarda en la tabla jugadores y asistencia
                jugadorLogic.SaveAsistencias(PartidoActual.ListaAsistencia, PartidoActual.NroPartido);

                this.Notificar("Excelente", "Ha cargado el partido con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        public void BorrarPartido()
        {

        }

        public bool Validar()
        {
            bool valid = true;

            if (
                String.IsNullOrEmpty(txtNroPartido.Text) ||
                String.IsNullOrEmpty(txtDescripcion.Text) ||
                String.IsNullOrEmpty(txtFecha.Text) ||
                String.IsNullOrEmpty(txtRival.Text) ||
                String.IsNullOrEmpty(txtGolesAFavor.Text) ||
                String.IsNullOrEmpty(txtGolesEnContra.Text))
            {
                this.Notificar("Campos vacios", "Complete todos los campos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else
            {
                if (!validarFecha())
                {
                    this.Notificar("Fecha invalida", "Ingrese dia/mes/año",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }
            if (!validarGoles())
            {
                this.Notificar("Error en goles", "Ingrese goles en numero entero",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            return valid;
        }

        public bool validarGoles()
        {
            bool valido = true;
            try
            {
                Int32 golesF = Convert.ToInt32(txtGolesAFavor.Text);
                Int32 golesC = Convert.ToInt32(txtGolesEnContra.Text);
            }
            catch (Exception)
            {
                valido = false;
            }
            return valido;
        }
        public bool validarFecha()
        {
            bool valido = true;
            try
            {
                DateTime dt = Convert.ToDateTime(txtFecha.Text);
                valido = true;
            }
            catch (Exception)
            {
                valido = false;
            }
            return valido;
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void btnRegistrarGoles_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                int golesFavor = Int32.Parse(txtGolesAFavor.Text);
                ABMGoles ventanaGoles = new Escritorio.ABMGoles(golesFavor, this.Modo);
                ABMGoles.GolesCargados = false;
                ventanaGoles.Visible = true;
            }

        }

        private void btnExpulsados_Click(object sender, EventArgs e)
        {
            if (ValidarCantidadExpulsados())
            {
                ABMExpulsados ventanaExpulsados = new ABMExpulsados(Int32.Parse(txtExpulsados.Text));
                ventanaExpulsados.Visible = true;
            }

        }

        public bool ValidarCantidadExpulsados()
        {
            bool valido = true;
            try
            {
                Int32 cant = Convert.ToInt32(txtExpulsados.Text);
                if (cant > 4)
                {
                    this.Notificar("Alerta", "No puede haber mas de 4 expulsados en un partido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valido = false;
                }
            }
            catch (Exception)
            {
                valido = false;
            }
            return valido;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            if (ValidarAsistencia())
            {
                int cantJug = Int32.Parse(this.txtCantJugadores.Text);
                ABMAsistencia abm = new ABMAsistencia(cantJug, this.Modo);
                abm.ShowDialog();
            }
            

        }

        public bool ValidarAsistencia()
        {
            bool valido = true;
            try
            {
                Int32 cant = Convert.ToInt32(txtCantJugadores.Text);
                if (cant == 0)
                {
                    this.Notificar("Info", "Si ingresa 0 no se presento el otro equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        valido = true;
                    
                }
                if(cant > 14)
                {
                    this.Notificar("Info", "No hay mas de 14 jugadores registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valido = false;
                }
                if(cant < 0)
                {
                    this.Notificar("Info", "No poner un numero negativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valido = false;
                }
            }
            catch (Exception)
            {
                valido = false;
                this.Notificar("Alerta", "Ingrese un numero entero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
        }
    }
}