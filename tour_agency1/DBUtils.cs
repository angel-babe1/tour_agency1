using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tour_agency1
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "tour_agency";
            string username = "monty";
            string password = "password";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}

