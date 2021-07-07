using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using todoWebAPI.App_Start;

namespace todoWebAPI.Models
{
    public class BaseModel
    {
        public MySqlConnection con = DbConnection.conn();
    }
}