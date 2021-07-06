using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoWebAPI.Models
{
    public class TasksName
    {
        public int UserID { get; set; }
        public int TaskNameID { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
    }
}