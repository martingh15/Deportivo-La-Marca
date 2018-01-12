using System;
using System.Collections.Generic;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class PartidoAdapter : Adapter
    {
        public List<Partido> GetAll()
        {

            List<Partido> partidos = new List<Partido>();

            try
            {
                this.OpenConnection();

                MySqlCommand cmdPartidos = new MySqlCommand("select * from partidos", MySqlConn);

                MySqlDataReader drPartidos = cmdPartidos.ExecuteReader();

                while (drPartidos.Read())
                {

                    Partido part = new Partido();

                    part.NroPartido = (int)drPartidos["nro_partido"];
                    part.Descripcion = (string)drPartidos["descripcion"];
                    part.Fecha = (DateTime)drPartidos["fecha"];
                    part.Rival = (string)drPartidos["rival"];
                    part.GolesAFavor = (int)drPartidos["goles_favor"];
                    part.GolesEnContra = (int)drPartidos["goles_contra"];

                    partidos.Add(part);
                }

                drPartidos.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar lista de partidos", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return partidos;

        }

        public List<string> getAsistencias(int nroPartido)
        {
            List<String> listaAsistencia = new List<String>();

            try
            {
                this.OpenConnection();

                MySqlCommand cmdPartidos = new MySqlCommand("select nombre from asistencias " +
                    "a inner join jugadores j on a.nro_camiseta = j.nro_camiseta where " +
                    "a.nro_partido = @nro_partido; ", MySqlConn);

                cmdPartidos.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = nroPartido;

                MySqlDataReader drPartidos = cmdPartidos.ExecuteReader();

                while (drPartidos.Read())
                {
                    string nombre = (string)drPartidos["nombre"];
                    listaAsistencia.Add(nombre);
                }

                drPartidos.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar lista de asistencias", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return listaAsistencia;
        }

        public void Save(Partido part)
        {
            if (part.State == BusinessEntity.States.Deleted)
            {
                this.Delete(part.NroPartido);
            }
            else if (part.State == BusinessEntity.States.New)
            {
                this.Insert(part);
            }
            else if (part.State == BusinessEntity.States.Modified)
            {
                this.Update(part);
            }
            part.State = BusinessEntity.States.Unmodified;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdDelete = new MySqlCommand("DELETE from partidos WHERE nro_partido=@nro_partido", MySqlConn);

                cmdDelete.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al eliminar partido", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Partido part)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdSave = new MySqlCommand(
                    "UPDATE partidos SET nro_partido = @nro_partido, descripcion = @descripcion, " +
                    " fecha = @fecha, rival= @rival, goles_favor=@goles_favor, goles_contra = @goles_contra " +
                    "WHERE nro_partido=@nro_partido", MySqlConn);

                cmdSave.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = part.NroPartido;
                cmdSave.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = part.Descripcion;
                cmdSave.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = part.Fecha;
                cmdSave.Parameters.Add("@rival", MySqlDbType.VarChar).Value = part.Rival;
                cmdSave.Parameters.Add("@goles_favor", MySqlDbType.Int32).Value = part.GolesAFavor;
                cmdSave.Parameters.Add("@goles_contra", MySqlDbType.Int32).Value = part.GolesEnContra;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            { 
                throw new Exception("Error al modificar datos del partido", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Partido GetOne(int ID)
        {
            Partido part = new Partido();

            try
            {
                this.OpenConnection();

                MySqlCommand cmdPartidos = new MySqlCommand("select * from partidos where nro_partido=@nro_partido", MySqlConn);

                cmdPartidos.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = ID;

                MySqlDataReader drPartidos = cmdPartidos.ExecuteReader();

                if (drPartidos.Read())
                {

                    part.NroPartido = (int)drPartidos["nro_partido"];
                    part.Descripcion = (string)drPartidos["descripcion"];
                    part.Fecha = (DateTime)drPartidos["fecha"];
                    part.Rival = (string)drPartidos["rival"];
                    part.GolesAFavor = (int)drPartidos["goles_favor"];
                    part.GolesEnContra = (int)drPartidos["goles_contra"];


                }

                drPartidos.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar datos del partido", Ex);
            }
            finally
            {
                this.CloseConnection();
            }

            return part;
        }

        public void Insert(Partido part)
        {
            try
            {
                this.OpenConnection();

                MySqlCommand cmdSave = new MySqlCommand(
                    "INSERT INTO partidos(nro_partido,descripcion,fecha,rival,goles_favor,goles_contra) " +
                    "VALUES(@nro_partido,@descripcion,@fecha,@rival,@goles_favor,@goles_contra) ", MySqlConn);

                cmdSave.Parameters.Add("@nro_partido", MySqlDbType.Int32).Value = part.NroPartido;
                cmdSave.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = part.Descripcion;
                cmdSave.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = part.Fecha;
                cmdSave.Parameters.Add("@rival", MySqlDbType.VarChar).Value = part.Rival;
                cmdSave.Parameters.Add("@goles_favor", MySqlDbType.Int32).Value = part.GolesAFavor;
                cmdSave.Parameters.Add("@goles_contra", MySqlDbType.Int32).Value = part.GolesEnContra;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al crear partido", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
