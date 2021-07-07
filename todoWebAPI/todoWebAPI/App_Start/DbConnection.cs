using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace todoWebAPI.App_Start
{
    public class DbConnection
    {
        public static MySqlConnection conn()
        {
            string sqlConfig = "server=localhost; port=3306; database=todo; username=root;";
            MySqlConnection conn = new MySqlConnection(sqlConfig);
            return conn;
        }
    }
}