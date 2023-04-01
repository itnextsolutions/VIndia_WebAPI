using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using VastraIndiaDAL;
using VastraIndiaWebAPI.Models;

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NotificationController : ApiController
    {
        DataTable dt = new DataTable();
        NotificationDAL objNotificationDAL = new NotificationDAL();
        SqlHelper objsqlHelper = new SqlHelper();

        [HttpGet]
        [Route("api/Notification/GetNotification")]
       public IHttpActionResult GetNotification()
        {
            dt = objNotificationDAL.GetNotification();
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in dt.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return Json(parentRow);
        }

        // POST api/<ProductController>
        [Route("api/Notification/InsertNotification")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] NotificationModel notification)
        {

            dt = objNotificationDAL.InsertNotification(notification.NotificationTitle, notification.FromDate, notification.ToDate, notification.ButtonText, notification.ButtonUrl);
            return Json("Added Successfully");
        }

        // PUT api/<ProductController>/5
        [Route("api/Notification/UpdateNotification")]
        //  [HttpPut("{id}")]
        [HttpPut]
        public IHttpActionResult Put([FromBody] NotificationModel Notification)
        {
            dt = objNotificationDAL.UpdateNotification(Notification.NotificationId, Notification.NotificationTitle, Notification.FromDate, Notification.ToDate, Notification.ButtonText, Notification.ButtonUrl);
            return Json("Updated Successfully");
        }

        [Route("api/Notification/DeleteNotification")]
        [HttpDelete]
        // DELETE api/<ProductController>/5
        public IHttpActionResult DeleteProdctColor(int id)
        {
            dt = objNotificationDAL.DeleteNotification(id);
            return Json("Deleted Successfully");
        }


        [HttpGet]
        [Route("api/Notification/GetNotificationPagination")]
       public IHttpActionResult GetNotificationPagination(int pageNo, int pageSize)
        {
            dt = objNotificationDAL.GetNotificationPagination(pageNo, pageSize);
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in dt.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return Json(parentRow);
        }
        [HttpGet]
        [Route("api/Notification/GetNotificationCount")]
       public IHttpActionResult GetNotificationCount()
        {
            dt = objNotificationDAL.GetNotificationCount();
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in dt.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return Json(parentRow);
        }
    }
}
