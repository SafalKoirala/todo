using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoWebAPI.Models
{
    public class Tasks
    {
        public int TaskID { get; set; }
        public int TaskNameID { get; set; }
        public string Alltasks { get; set; }
        public bool IsCompleted { get; set; }
    }
}