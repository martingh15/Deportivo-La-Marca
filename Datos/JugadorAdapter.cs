using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class JugadorAdapter : Adapter
    {

        public List<Jugador> GetAll()
        {

            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                this.OpenConnection();

                MySqlCommand cmdJugadores = new MySqlCommand("select * from jugadores", MySqlConn);

                MySqlDataReader drJugadores = cmdJugadores.ExecuteReader();

                while (drJugadores.Read())
                {

                    Jugador jug = new Jugador();

                    jug.NroCamiseta = (int)drJugadores["nro_camiseta"];
                    jug.Nombre = (string)drJugadores["nombre"];
                    jug.Goles = (int)drJugadores["goles"];
                    jug.Asistencia = (int)drJugadores["asistencia_total"];
                    jug.FechaNacimiento = (DateTime)drJugadores["fecha_nacimiento"];

                    jugadores.Add(jug);
                }

                drJugadores.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar lista de jugadores", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return jugadores;

        }

        public void Save(Jugador jug)
        {
            if (jug.State == BusinessEntity.States.Deleted)
            {
                this.Delete(jug.NroCamiseta);
            }
            else if (jug.State == BusinessEntity.States.New)
            {
                this.Insert(jug);
            }
            else if (jug.State == BusinessEntity.States.Modified)
            {
                this.Update(jug);
            }
            jug.State = BusinessEntity.States.Unmodified;
        }

        public void AgregarGol(int cant, int nroCamiseta, int nroPartido)
        {
            try
            {
                this.OpenConnection();

                if (nroCamiseta == 0)
                {
                    MySqlCommand cmdSave = new MySqlCommand(
                    "INSERT INTO goles(nro_gol,nro_partido) " +
                    "VALUES(@nro_gol,@nro_partido) ", MySqlConn);

                    cmdSave.Parameters.Add("@nro_gol", MySqlDbType.Int32).Value = cant;
                    cmdSave.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = nroPartido;
                    cmdSave.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmdSave = new MySqlCommand(
                    "INSERT INTO goles(nro_gol,nro_camiseta,nro_partido) " +
                    "VALUES(@nro_gol,@nro_camiseta,@nro_partido) ", MySqlConn);

                    cmdSave.Parameters.Add("@nro_gol", MySqlDbType.Int32).Value = cant;
                    cmdSave.Parameters.Add("@nro_camiseta", MySqlDbType.Int32).Value = nroCamiseta;
                    cmdSave.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = nroPartido;
                    cmdSave.ExecuteNonQuery();
                } 
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al actualizar el gol", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void AgregarAsistencia(int nroCamiseta, int nroPartido)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdSave = new MySqlCommand(
                    "INSERT INTO asistencias(nro_partido, nro_camiseta) " +
                    "VALUES(@nro_partido, @nro_camiseta) ", MySqlConn);

                cmdSave.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = nroPartido;
                cmdSave.Parameters.Add("@nro_camiseta", MySqlDbType.Int32).Value = nroCamiseta;                
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            { 
                throw new Exception("Error al actualizar asistencias", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public int GetAllGoals()
        {
            int cantidadGoles;

            try
            {
                this.OpenConnection();

                MySqlCommand cmdJugadores = new MySqlCommand("select count(nro_gol) from goles", MySqlConn);

                cantidadGoles = Convert.ToInt32(cmdJugadores.ExecuteScalar());
            }
            catch (Exception Ex)
            { 
                throw new Exception("Error al recuperar datos del usuario", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return cantidadGoles;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdDelete = new MySqlCommand("DELETE from jugadores WHERE nro_camiseta=@nro_camiseta", MySqlConn);

                cmdDelete.Parameters.Add("@nro_camiseta", MySqlDbType.Int32).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {             
                throw new Exception("Error al eliminar usuario", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Jugador jug)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdSave = new MySqlCommand(
                    "UPDATE jugadores SET nro_camiseta = @nro_camiseta, nombre = @nombre, " +
                    "goles = @goles, asistencia_total = @asistencia, fecha_nacimiento= @fecha_nacimiento " +
                    "WHERE nro_camiseta=@nro_camiseta", MySqlConn);

                cmdSave.Parameters.Add("@nro_camiseta", MySqlDbType.Int32).Value = jug.NroCamiseta;
                cmdSave.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = jug.Nombre;
                cmdSave.Parameters.Add("@goles", MySqlDbType.Int32).Value = jug.Goles;
                cmdSave.Parameters.Add("@asistencia", MySqlDbType.Int32).Value = jug.Asistencia;
                cmdSave.Parameters.Add("@fecha_nacimiento", MySqlDbType.DateTime).Value = jug.FechaNacimiento;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al modificar datos del jugador", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Jugador GetOne(int ID)
        {
            Jugador jug = new Jugador();

            try
            {
                this.OpenConnection();

                MySqlCommand cmdJugadores = new MySqlCommand("select * from jugadores where nro_camiseta=@nro_camiseta", MySqlConn);

                cmdJugadores.Parameters.Add("@nro_camiseta", MySqlDbType.Int32).Value = ID;

                MySqlDataReader drJugadores = cmdJugadores.ExecuteReader();

                if (drJugadores.Read())
                {

                    jug.NroCamiseta = (int)drJugadores["nro_camiseta"];
                    jug.Nombre = (string)drJugadores["nombre"];
                    jug.FechaNacimiento = (DateTime)drJugadores["fecha_nacimiento"];


                }

                drJugadores.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar datos del usuario", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return jug;
        }

        public Jugador GetOne(string name)
        {
            Jugador jug = new Jugador();

            try
            {
                this.OpenConnection();

                MySqlCommand cmdJugadores = new MySqlCommand("select * from jugadores where nombre=@nombre", MySqlConn);

                cmdJugadores.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = name;

                MySqlDataReader drJugadores = cmdJugadores.ExecuteReader();

                if (drJugadores.Read())
                {

                    jug.NroCamiseta = (int)drJugadores["nro_camiseta"];
                    jug.Nombre = (string)drJugadores["nombre"];
                    jug.Goles = (int)drJugadores["goles"];
                    jug.Asistencia = (int)drJugadores["asistencia_total"];
                    jug.FechaNacimiento = (DateTime)drJugadores["fecha_nacimiento"];
                }

                drJugadores.Close();
            }
            catch (Exception Ex)
            { 
                throw new Exception("Error al recuperar datos del usuario", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return jug;
        }

        public void Insert(Jugador jug)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdSave = new MySqlCommand(
                    "INSERT INTO jugadores(nro_camiseta,nombre,fecha_nacimiento,goles,asistencia_total) " +
                    "VALUES(@nro_camiseta,@nombre,@fecha_nacimiento,0,0) ", MySqlConn);

                cmdSave.Parameters.Add("@nro_camiseta", MySqlDbType.Int32).Value = jug.NroCamiseta;
                cmdSave.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = jug.Nombre;
                cmdSave.Parameters.Add("@fecha_nacimiento", MySqlDbType.DateTime).Value = jug.FechaNacimiento;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al crear usuario", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
