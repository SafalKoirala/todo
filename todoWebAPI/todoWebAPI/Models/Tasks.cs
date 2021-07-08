using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace todoWebAPI.Models
{
    public class Tasks :BaseModel
    {
        public int taskId { get; set; }
        public int userId { get; set; }
        public string taskName { get; set; }
        public bool isCompleted { get; set; }

        public Tasks () { }

        public Tasks (int taskId,string taskName) {
            this.taskId = taskId;
            this.taskName = taskName;
       
        }

        public Tasks(int taskId, bool isCompleted)
        {
            this.taskId = taskId;
            this.isCompleted = isCompleted;

        }
        public Tasks (int userId, string taskName, bool isCompleted)
        {
            this.userId = userId;
            this.taskName = taskName;
            this.isCompleted = isCompleted;
        }

        public Tasks(int tasksId, int userId, string taskName, bool isCompleted)
        {
            this.taskId = taskId;
            this.userId = userId;
            this.taskName = taskName;
            this.isCompleted = isCompleted;
        }

        public DataTable listTasks( int userId)
        {
            string query = @"SELECT taskId, taskName, isCompleted FROM tasks WHERE userId=@userId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
   
        public void addTasks (Tasks task)
        {
            string query = @"INSERT into tasks (userId,taskName,isCompleted) values(@userId,@taskName,@isCompleted)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@userId", MySqlDbType.Int32).Value = task.userId;
            cmd.Parameters.Add("@taskName", MySqlDbType.VarChar, 500).Value = task.taskName;
            cmd.Parameters.Add("@isCompleted", MySqlDbType.UInt64).Value = task.isCompleted;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public void updateTasks (Tasks task) {
            string query = @"Update tasks set taskName = @taskName where taskId = @taskId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@taskId", MySqlDbType.Int32).Value = task.taskId;
            cmd.Parameters.Add("@taskName", MySqlDbType.VarChar, 500).Value = task.taskName;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }
        public void deleteTasks (Tasks task) {
            string query = @"Delete from tasks where taskId = @taskId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@taskId", MySqlDbType.Int32).Value = task.taskId;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }
        public void taskComplete(Tasks task) {
            string query = @"UPDATE tasks set isCompleted = @isCompleted WHERE taskId = @taskId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@taskId", MySqlDbType.Int32).Value =task.taskId;
            cmd.Parameters.Add("@isCompleted", MySqlDbType.UInt64).Value =task.isCompleted;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
    }
}