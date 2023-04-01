using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using VastraIndiaDAL;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class HomeController : ApiController
    {

        DataTable dt = new DataTable();
        HomeDAL objHomeDAL = new HomeDAL();
        BlogDAL objblog = new BlogDAL();
        /* GET FAQ */
        [HttpGet]
        [Route("api/Home/GetFaq")]
        public IHttpActionResult GetFaq()
        {
            dt = objHomeDAL.GetFaq();
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

        /* Menu Binding */

        [HttpGet]
    
        [Route("api/Home/GetMenuList")]

        public IHttpActionResult GetMenuList()
        {
            dt = objHomeDAL.GetMenuList();
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


        //Notification
        [HttpGet]
        [Route("api/Home/GeNotification")]
        public IHttpActionResult GeNotification()
        {
            dt = objHomeDAL.GeNotification();
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
        [Route("api/Home/GetCustomerReview")]
        public IHttpActionResult GetCustomerReview()
        {
            dt = objHomeDAL.GetCustomerReview();
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

        //Search Result
        [Route("api/Home/GetSearchProduct")]
        [HttpGet]
        public IHttpActionResult GetSearchProduct(string search)
        {
            dt = objHomeDAL.GetSearchProduct(search);
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

        //Product Menubar start
        [Route("api/Home/GetProductMenu")]
        public IHttpActionResult GetProductMenu()
        {
            dt = objHomeDAL.GetProductMenu();
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


        [Route("api/Home/GetSimillarProducts")]
        [HttpGet]
        public IHttpActionResult GetSimillarProducts(int id)
        {
            dt = objHomeDAL.GetSimillarProducts(id);
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

        [Route("api/Home/GetProductsBySubCategory")]
        [HttpGet]
        public IHttpActionResult GetProdutsBySubCategory(int id, int subCatId)
        {
            dt = objHomeDAL.GetProductBySubCategory(id, subCatId);
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

        [Route("api/Home/GetProductsByCategory")]
        [HttpGet]
        public IHttpActionResult GetProdutsByCategoryId(int categoryId)
        {
            dt = objHomeDAL.GetProductByCategory(categoryId);
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

        [Route("api/Home/GetProductSizeById")]
        public IHttpActionResult GetProductSizeById(int id)
        {
            dt = objHomeDAL.GetProductSizeById(id);
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

        [Route("api/Home/GetColorCodeListByProductId")]
        [HttpGet]
        public IHttpActionResult GetColorCodeListByProductId(int id)
        {
            dt = objHomeDAL.GetColorCodeListByProductId(id);
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

        [Route("api/Home/GetSizeListByProductId")]
        [HttpGet]
        public IHttpActionResult GetSizeListByProductId(int id)
        {
            dt = objHomeDAL.GetSizeListByProductId(id);
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

        [Route("api/Home/GetSubCategoryByCategoryId")]
        [HttpGet]
        public IHttpActionResult GetSubCategoryByCategoryId(int id)
        {
            dt = objHomeDAL.GetSubCategoryByCategoryId(id);
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

        [Route("api/Home/GetSubCategoryById")]
        [HttpGet]
        public IHttpActionResult GetSubCategoryById(int id)
        {
            dt = objHomeDAL.GetSubCategoryById(id);
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

        //Category start
        [Route("api/Home/GetCategory")]
        public IHttpActionResult GetCategory()
        {
            dt = objHomeDAL.GetProductCategory();
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

        //Category start
        [Route("api/Home/GetAllCategory")]
        public IHttpActionResult GetAllCategory()
        {
            dt = objHomeDAL.GetAllProductCategory();
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

        [Route("api/Home/GetBlog")]
        [HttpGet]
        public IHttpActionResult GetBlog(int number)
        {
            dt = objHomeDAL.GetBlog(number);
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
        [Route("api/Home/GetAllBlogs")]
        public IHttpActionResult GetAllBlogs(int Blog_Id)
        {
            dt = objHomeDAL.GetAllBlogs(Blog_Id);
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

        // GET api/<BlogController>/5
        [Route("api/Home/GetBlogById")]
        [HttpGet]
        public IHttpActionResult GetBlogById(int blog_Id)
        {
            dt = objHomeDAL.GetBlogById(blog_Id);

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
        //[Route("api/Home/GetCategoryById")]
        //public IHttpActionResult GetCategoryById(int id)
        //{
        //    dt = objProductDAL.GetProductCategoryById(id);
        //    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        //    List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
        //    Dictionary<string, object> childRow;
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        childRow = new Dictionary<string, object>();
        //        foreach (DataColumn col in dt.Columns)
        //        {
        //            childRow.Add(col.ColumnName, row[col]);
        //        }
        //        parentRow.Add(childRow);
        //    }
        //    return new IHttpActionResult(parentRow);
        //}
        //Category End


    }
}
