using System;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using todoWebAPI.Models;

namespace todoWebAPI.Controllers
{
    public class TasksController : ApiController
    {
        Tasks task = new Tasks();
        public HttpResponseMessage Get(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = task.listTasks(id);
                return Request.CreateResponse(HttpStatusCode.OK, dt);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, e);
            }
        }

       /* public HttpResponseMessage Get(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = task.taskInformation(id);
                return Request.CreateResponse(HttpStatusCode.OK, dt);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, e);
            }
        }

        public string Post(Tasks taskData)
        {
            try
            {
                task.addTasks();
                return "Data Added successfully !!";
            }
            catch (Exception e)
            {
                return "Failed to insert data: Exception :" + e;
            }
        }

        public string Put(Tasks taskData)
        {
            try
            {
                task.updateTask(taskData);
                return "Updated Data successfull";
            }
            catch (Exception e)
            {
                return "Failed to Update data: Exception :" + e;
            }
        }

        public string Delete(Tasks taskData)
        {
            try
            {
                task.deleteTask(taskData);
                return "Task Removed Successfully";
            }
            catch (Exception e)
            {
                return "Delete Failed";
            }
        }*/
    }
}
