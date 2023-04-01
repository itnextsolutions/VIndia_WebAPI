using System.Collections.Generic;
using System.Data;
using VastraIndiaDAL;
using VastraIndiaWebAPI.Models;
using System.Web.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    // [Route("api/[controller]")]
    // [ApiController]
    public class BlogController : ApiController
    {
        DataTable dt = new DataTable();
        BlogDAL objblog = new BlogDAL();
        SaveImageDAL saveImage = new SaveImageDAL();

        // GET: api/<BlogController>
        [HttpGet]
        [Route("api/Blog/GetBlog")]
        public IHttpActionResult GetBlog()
        {
            dt = objblog.GetBlog();
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
        [Route("api/Blog/GetAllBlog")]
        public IHttpActionResult GetAllBlog()
        {
            dt = objblog.GetAllBlog();
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
        [Route("api/Blog/GetBlogById/")]
        [HttpGet]
        public IHttpActionResult GetBlogById(int id)
        {
            dt = objblog.GetBlogById(id);

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
        //// POST api/<BlogController>
        //[Route("api/Blog/InsertBlog")]
        //[HttpPost]
        //public IHttpActionResult Post([FromBody] BlogModel blog)
        //{
        //    if (blog.Blog_Title != null)
        //    {
        //        dt = objblog.InsertBlog(blog.Blog_Title, blog.Blog_Content, blog.Blog_Topic, blog.Image_Name);
        //        return Json("Added Successfully");
        //    }
        //    else
        //    {
        //        return Json("Please Enter All Details");
        //    }
        //}

        // POST api/<CustomerController>
        [Route("api/Blog/InsertBlog")]
        [HttpPost]
        public async Task<IHttpActionResult> SaveBlog([FromBody] BlogModel blog)
        {

            var Ext = System.IO.Path.GetExtension(blog.formFile.FileName);

            var FileName = blog.Blog_Title + "_" + DateTime.Now.ToString("dd/MM/yyyy") + Ext;

            var BlogFolderName = Path.Combine("C:", "Projects", "VastraIndia", "Vastra", "src", "assets", "img", "blog");


            if (!Directory.Exists(BlogFolderName))
            {
                //If Directory (Folder) does not exists. Create it.
                Directory.CreateDirectory(BlogFolderName);
            }

            dt = objblog.InsertBlog(blog.Blog_Title, blog.Blog_Content, blog.Blog_Topic, FileName);

            var SaveImage = saveImage.SaveImagesAsync(blog.formFile, FileName, BlogFolderName);

            return Json("Added Successfully");
        }

        // POST api/<CustomerController>
        [Route("api/Blog/UpdateBlog")]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateBlog([FromBody] BlogModel blog)
        {

            var Ext = System.IO.Path.GetExtension(blog.formFile.FileName);

            var FileName = blog.Blog_Title + "_" + DateTime.Now.ToString("dd/MM/yyyy") + Ext;

            var BlogFolderName = Path.Combine("C:", "Projects", "VastraIndia", "Vastra", "src", "assets", "img", "blog");

            if (!Directory.Exists(BlogFolderName))
            {
                //If Directory (Folder) does not exists. Create it.
                Directory.CreateDirectory(BlogFolderName);
            }

            dt = objblog.UpdateBlog(blog.Blog_Id, blog.Blog_Title, blog.Blog_Topic, blog.Blog_Content, FileName);

            var SaveImage = saveImage.SaveImagesAsync(blog.formFile, FileName, BlogFolderName);

            return Json("Added Successfully");
        }


        //// PUT api/<BlogController>/5
        //[Route("api/Blog/UpdateBlog")]
        ////  [HttpPut("{id}")]
        //[HttpPut]
        //public IHttpActionResult Put([FromBody] BlogModel blog)
        //{
        //    if (blog != null)
        //    {
        //        if (blog.Blog_Id != 0)
        //        {
        //            dt = objblog.UpdateBlog(blog.Blog_Id, blog.Blog_Title, blog.Blog_Topic, blog.Blog_Content, blog.Image_Name);
        //            return Json("Updated Successfully");
        //        }
        //    }
        //    return Json("Data is not valid");

        //}

        // DELETE api/<BlogController>/5
        [Route("api/Blog/Delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            dt = objblog.DeleteBlog(id);
            return Json("Deleted Successfully");

        }

        [HttpGet]
        [Route("api/Blog/GetAllBlogPagination")]
        public IHttpActionResult GetAllBlogPagination(int pageNo, int pageSize)
        {
            dt = objblog.GetAllBlogPagination(pageNo, pageSize);
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
        [Route("api/Blog/GetAllBlogCount")]
        public IHttpActionResult GetAllBlogCount()
        {
            dt = objblog.GetAllBlogCount();
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
