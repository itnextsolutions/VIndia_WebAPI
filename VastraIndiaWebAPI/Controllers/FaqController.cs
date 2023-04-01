
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using System.Web.Http.Cors;
using VastraIndiaDAL;
using VastraIndiaWebAPI.Models;

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class FaqController : ApiController
    {
        DataTable dt = new DataTable();
        FaqDAL objfaq = new FaqDAL();

        [HttpGet]
        [Route("api/Faq/GetAllFaqPagination")]
       public IHttpActionResult GetAllFaqPagination(int pageNo, int pageSize)
        {
            dt = objfaq.GetFaqPagination(pageNo, pageSize);
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
        [Route("api/Faq/GetFaqCount")]
       public IHttpActionResult GetAlFaqCount()
        {
            dt = objfaq.GetFaqCount();
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

        // POST api/<FaqController>
        [Route("api/Faq/InsertFaq")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] FaqModel faq)
        {
            dt = objfaq.InsertFaq(faq.Question, faq.Answer);
            return Json("Added Successfully");
        }
        // PUT api/<FaqController>/5
        [Route("api/Faq/UpdateFaq")]
        //  [HttpPut("{id}")]
        [HttpPut]
        public IHttpActionResult Put([FromBody] FaqModel faq)
        {
            if (faq.Id != 0)
            {
                dt = objfaq.updateFaq(faq.Id, faq.Question, faq.Answer);
                return Json("Updated Successfully");
            }

            return Json("Data is not valid");

        }

        // DELETE api/<FaqController>/5
        [Route("api/Faq/Delete")]
        [HttpDelete]
       public IHttpActionResult Delete(int id)
        {
            dt = objfaq.DeleteFaq(id);
            return Json("Deleted Successfully");
        }
    }
}
