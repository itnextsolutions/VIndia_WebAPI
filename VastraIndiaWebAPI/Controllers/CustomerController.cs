using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using VastraIndiaDAL;
using VastraIndiaWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[Route("api/[controller]")]
    // [ApiController]
    public class CustomerController : ApiController
    {
        DataTable dt = new DataTable();
        CustomerDAL customer = new CustomerDAL();
        SaveImageDAL saveImage = new SaveImageDAL();

        // GET: api/<CustomerController>
        [HttpGet]
        [Route("api/Customer/GetCustomerReview")]
       public IHttpActionResult GetCustomerReview()
        {
            dt = customer.GetCustomerReview();
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

        // GET api/<CustomerController>/5
        [Route("api/Customer/GetCustomerReviewByid")]
        [HttpGet]
        public IHttpActionResult GetCustomerReviewById(int id)
        {
            dt = customer.GetCustomerReviewById(id);
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



        // POST api/<CustomerController>
        [Route("api/Customer/InsertCustomerReview")]
        [HttpPost]
        public async Task<IHttpActionResult> SaveCustReview([FromBody] CustomerModel cust)
        {

            var Ext = System.IO.Path.GetExtension(cust.formFile.FileName);

            var FileName = cust.Client_Name + "_" + DateTime.Now.ToString("dd/MM/yyyy") + Ext;

            var ClientReviewsFolderName = Path.Combine("C:", "Projects", "VastraIndia", "Vastra", "src", "assets", "img", "client_reviews");

            if (!Directory.Exists(ClientReviewsFolderName))
            {
                //If Directory (Folder) does not exists. Create it.
                Directory.CreateDirectory(ClientReviewsFolderName);
            }

            dt = customer.InsertCustomerReview(cust.Client_Name, cust.Profession, cust.Review, FileName, cust.Rating);

            var SaveImage = saveImage.SaveImagesAsync(cust.formFile, FileName, ClientReviewsFolderName);

            return Json("Added Successfully");
        }

        // PUT api/<CustomerController>/5
        [Route("api/Customer/UpdateCustomerReview")]
        //  [HttpPut("{id}")]
        [HttpPut]
        public async Task<IHttpActionResult> UpdateCustReview([FromBody] CustomerModel cust)
        {

            var Ext = System.IO.Path.GetExtension(cust.formFile.FileName);

            var FileName = cust.Client_Name + "_" + DateTime.Now.ToString("dd/MM/yyyy") + Ext;

            var ClientReviewsFolderName = Path.Combine("C:", "Projects", "VastraIndia", "Vastra", "src", "assets", "img", "client_reviews");

            if (!Directory.Exists(ClientReviewsFolderName))
            {
                //If Directory (Folder) does not exists. Create it.
                Directory.CreateDirectory(ClientReviewsFolderName);
            }

            dt = customer.UpdateCustomerReview(cust.Customer_Review_Id, cust.Client_Name, cust.Profession, cust.Review, FileName, cust.Rating);
            var SaveImage = saveImage.SaveImagesAsync(cust.formFile, FileName, ClientReviewsFolderName);
            return Json("Updated Successfully");

        }


        // DELETE api/<CustomerController>/5
        [Route("api/Customer/DeleteCustomerReview")]
        [HttpDelete]
        // DELETE api/<ProductController>/5
       public IHttpActionResult Delete(int id)
        {

            dt = customer.DeleteCustomerReviewById(id);
            return Json("Deleted Successfully");
        }

        [HttpGet]
        [Route("api/Customer/GetCustomerReviewPagination")]
       public IHttpActionResult GetCustomerReviewPagination(int pageNo, int pageSize)
        {
            dt = customer.GetCustomerReviewPage(pageNo, pageSize);
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
        [Route("api/Customer/GetCustomerReviewCount")]
       public IHttpActionResult GetCustomerReviewCount()
        {
            dt = customer.GetCustomerReviewCount();
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