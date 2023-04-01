using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using VastraIndiaDAL;
using VastraIndiaWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    // [Route("api/[controller]")]
    // [ApiController]
    public class LookupController : ApiController
    {
        DataTable dt = new DataTable();

        LookupDAL lookup = new LookupDAL();

        //LookupMaster start

        // GET: api/<LookupController>
        [HttpGet]
        [Route("api/Lookup/GetLookupMaster")]
       public IHttpActionResult GetLookupMaster()
        {
            dt = lookup.LookupMaster();
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

        // GET api/<LookupController>/5
        [Route("api/Lookup/GetLookupMasterByid")]
        [HttpGet]
        public IHttpActionResult GetLookupMasterById(int id)
        {
            dt = lookup.GetLookupMasterById(id);
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

        // POST api/<LookupController>
        [Route("api/Lookup/InsertLookupMaster")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] LookupMasterModel lookupMaster)
        {
            dt = lookup.InsertLookupMaster(lookupMaster.Lookup_Name);
            return Json("Added Successfully");
        }

        // PUT api/<LookupController>/5
        [Route("api/Lookup/UpdateLookupMaster")]
        //  [HttpPut("{id}")]
        [HttpPut]
        public IHttpActionResult Put([FromBody] LookupMasterModel lookupMaster)
        {
            if (lookupMaster.Lookup_Id != 0)
            {
                ;
                dt = lookup.UpdateLookupMaster(lookupMaster.Lookup_Id, lookupMaster.Lookup_Name);
                return Json("Updated Successfully");
            }
            return Json("Lookup_Id is not valid");

        }

        // DELETE api/<LookupController>/5
        [HttpDelete]
        [Route("api/Lookup/DeleteLookupMaster")]
       public IHttpActionResult Delete(int id)
        {
            dt = lookup.DeleteLookupMaster(id);
            return Json("Deleted Successfully");
        }
        //LookupMaster end


        [HttpGet]
        [Route("api/Lookup/GetLookupDetails")]
       public IHttpActionResult GetLookupDetails()
        {
            dt = lookup.LookupDetails();
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


        [Route("api/Lookup/GetLookupDetailsById")]
        [HttpGet]
        public IHttpActionResult GetLookupDetailsById(int id)
        {
            dt = lookup.GetLookupDetailsById(id);
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

        [Route("api/Lookup/InsertLookupDetails")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] LookupDetailsModel lookupDetail)
        {
            dt = lookup.InsertLookupDetails(lookupDetail.Lookup_Id, lookupDetail.Description, lookupDetail.ColorName);
            return Json("Added Successfully");
        }

        [Route("api/Lookup/UpdateLookupDetails")]
        //  [HttpPut("{id}")]
        [HttpPut]
        public IHttpActionResult Put([FromBody] LookupDetailsModel lookupDetail)
        {
            if (lookupDetail.Lookup_Details_Id != 0)
            {
                ;
                dt = lookup.UpdateLookupDetails(lookupDetail.Lookup_Details_Id, lookupDetail.Lookup_Id, lookupDetail.Description, lookupDetail.ColorName);
                return Json("Updated Successfully");
            }
            return Json("LookupDetailId is not valid");

        }

        // DELETE api/<LookupController>/5
        [HttpDelete]
        [Route("api/Lookup/DeleteLookupDetails")]
       public IHttpActionResult DeleteLookupDetails(int id)
        {
            dt = lookup.DeleteLookupDetailsById(id);
            return Json("Deleted Successfully");
        }

        [HttpGet]
        [Route("api/Lookup/GetLookupNameDropDown")]
       public IHttpActionResult GetLookupNameDropDown()
        {
            dt = lookup.LookupNameDropDown();
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
        [Route("api/Lookup/GetColor")]
       public IHttpActionResult GetColor()
        {
            dt = lookup.GetColor();
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
        [Route("api/Lookup/GetSize")]
       public IHttpActionResult GetSize()
        {
            dt = lookup.GetSize();
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
        [Route("api/Lookup/GetLookupMasterPagination")]
       public IHttpActionResult GetLookupMasterPagination(int pageNo, int pageSize)
        {
            dt = lookup.GetLookupMasterPagination(pageNo, pageSize);
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
        [Route("api/Lookup/GetLookupMasterCount")]
       public IHttpActionResult GetLookupMasterCount()
        {
            dt = lookup.GetLookupMasterCount();
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

        // Lookup Details Pagination  Start
        [HttpGet]
        [Route("api/Lookup/GetLookupDetailsPagination")]
       public IHttpActionResult GetLookupDetailsPagination(int pageNo, int pageSize)
        {
            dt = lookup.GetLookupDetailsPagination(pageNo, pageSize);
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
        [Route("api/Lookup/GetLookupDetailsCount")]
       public IHttpActionResult GetLookupDetailsCount()
        {
            dt = lookup.GetLookupDetailsCount();
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
        // Lookup Details Pagination End
    }
}
