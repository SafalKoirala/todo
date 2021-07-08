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
        public string Post(Tasks taskData)
        {
            try
            {
                task.addTasks(taskData);
                return "Data added Successfully!";
            }
            catch (Exception e)
            {
                return "exception occured:" + e;
            }
        }

        public string Put (Tasks taskData)
        {
            try
            {
              
                task.updateTasks(taskData);
                return ("Task Updated Successfully");
            }catch(Exception e)
            {
                return ("Exception occured:" + e);
            }
        }

        public string Patch(Tasks taskData)
        {
            try
            {
             
                task.taskComplete(taskData);
                return ("Task Status updated!");
            }
            catch (Exception e)
            {
                return ("Exception Occured:" + e);
            }
        }

    }
}
