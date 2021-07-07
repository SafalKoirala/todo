using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace todoWebAPI.Models
{
    public class Users : BaseModel
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public Users() { }
        public Users(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public Users(int uid, string userName)
        {
            this.userId = uid;
            this.userName = userName;
        }

        public Users(int userId)
        {
            this.userId = userId;
        }


        public DataTable listUsers()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT userId, userName FROM users", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void addUser(Users user)
        {
            string query = @"Insert into users (userName,password) values(@userName, @password)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@userName", MySqlDbType.VarChar, 500).Value = user.userName;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar, 500).Value = user.password;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public void updateUser(Users user)
        {
            string query = @"Update Users set userName = @userName where userId = @userId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@userName", MySqlDbType.VarChar, 500).Value = user.userName;
            cmd.Parameters.Add("@userId", MySqlDbType.Int32, sizeof(Int32)).Value = user.userId;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public void deleteUser(Users user)
        {
            string query = @"Delete from Users where userId = @userId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@userId", MySqlDbType.Int32, sizeof(Int32)).Value = user.userId;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public DataTable userInformation(int uid)
        {
            string query = @"SELECT userId, userName FROM Users where userId = @userId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@userId", MySqlDbType.Int32, sizeof(Int32)).Value = uid;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
    }
}