using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPE3.Class
{
    class Utilitaires
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "tholdi1";
            string username = "root";
            string password = "";

            return BDDConnect.GetDBConnection(host, port, database, username, password);
        }

        public static MySqlParameter CodeParam(string paramName, object value)
        {
            MySqlConnection connect = GetDBConnection();
            MySqlCommand commandSql = connect.CreateCommand();
            MySqlParameter parametre = commandSql.CreateParameter();
            parametre.ParameterName = paramName;
            parametre.Value = value;
            return parametre;
        }
    }
}
