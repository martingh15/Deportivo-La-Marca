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
using System.Text.RegularExpressions;

namespace Escritorio
{
    public partial class ABMJugadores : Form
    {
        JugadorLogic jl;
        List<Jugador> jugadores;
        private Jugador jugadorActual;

        public Jugador JugadorActual
        {
            get { return jugadorActual; }
            set { jugadorActual = value; }
        }


        public ABMJugadores()
        {
            InitializeComponent();
            jl = new JugadorLogic();
            jugadores = new List<Jugador>();
            jugadorActual = new Jugador();
    }
        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        private ModoForm _modo;

        public ModoForm Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }
        

        public ABMJugadores(int ID) : this()
        {
            this.Modo = ModoForm.Modificacion;
            this.JugadorActual = jl.GetOne(ID);
            this.txtNombre.Text = JugadorActual.Nombre;
            this.txtFechaNacimiento.Text = JugadorActual.FechaNacimiento.ToString();
            this.txtNroCamiseta.Text = JugadorActual.NroCamiseta.ToString();
        }
        private void ABMJugadores_Load(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta)
            {
                button.Text = "Agregar";
            }
            if(Modo == ModoForm.Modificacion)
            {
                button.Text = "Modificar";
            }
            if(Modo == ModoForm.Baja)
            {
                button.Text = "Borrar";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Modo == ModoForm.Alta) AgregarJugador();
                if (Modo == ModoForm.Modificacion) ModificarJugador();
                if (Modo == ModoForm.Baja) BorrarJugador();
            }
            this.Dispose();
        }

        public void AgregarJugador()
        {
            JugadorActual.State = BusinessEntity.States.New;
            JugadorActual.NroCamiseta = Int32.Parse(txtNroCamiseta.Text);
            JugadorActual.Nombre = txtNombre.Text;
            JugadorActual.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            //Sacar al agregar partidos
            JugadorActual.Asistencia = 0;
            JugadorActual.Goles = 0;
            //Sacar al agregar partidos
            jl.Save(JugadorActual);
        }

        public void ModificarJugador()
        {
            JugadorActual.State = BusinessEntity.States.Modified;
            JugadorActual.NroCamiseta = Int32.Parse(txtNroCamiseta.Text);
            JugadorActual.Nombre = txtNombre.Text;
            JugadorActual.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            //Sacar al agregar partidos
            JugadorActual.Asistencia = 0;
            JugadorActual.Goles = 0;
            //Sacar al agregar partidos
            jl.Save(JugadorActual);
        }

        public void BorrarJugador()
        {
            JugadorActual.State = BusinessEntity.States.Deleted;
            JugadorActual.NroCamiseta = Int32.Parse(txtNroCamiseta.Text);
            jl.Delete(JugadorActual.NroCamiseta);
        }

        public bool Validar()
        {
            bool valid = true;

            if (
                String.IsNullOrEmpty(txtNombre.Text) ||
                String.IsNullOrEmpty(txtNroCamiseta.Text) ||
                String.IsNullOrEmpty(txtFechaNacimiento.Text))
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
            return valid;
        }
        public bool validarFecha()
        {
            bool valido = true;
            try
            {
                DateTime dt = Convert.ToDateTime(txtFechaNacimiento.Text);
                valido = true;
            }
            catch (Exception)
            {
                this.Notificar("Fecha invalida", "Ingrese dia/mes/año",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
