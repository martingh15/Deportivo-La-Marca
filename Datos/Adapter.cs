using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Adapter
    {
        protected MySqlConnection mySqlConn;

        public MySqlConnection MySqlConn
        {
            get { return mySqlConn; }
            set { mySqlConn = value; }
        }

        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringMySql";

        protected void OpenConnection()
        {

            string conMan = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            MySqlConn = new MySqlConnection(conMan);
            MySqlConn.Open();
        }

        protected void CloseConnection()
        {
            MySqlConn.Close();
            MySqlConn = null;
        }
    }
}
