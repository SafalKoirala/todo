using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using todoWebAPI.App_Start;
namespace todoWebAPI.Controllers
{
    public class UsersController : ApiController
    {
        public HttpResponseMessage Get()
        {
            MySqlConnection con = DbConnection.conn();
            MySqlCommand cmd = new MySqlCommand("SELECT userId, userName FROM users", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Request.CreateResponse(HttpStatusCode.OK, dt);
        }

    }
}
