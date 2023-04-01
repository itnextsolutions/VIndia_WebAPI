
using System.Web;

namespace VastraIndiaWebAPI.Models
{
    public class ProductModel
    {
        public int Product_Id { get; set; }

        public int Category_Id { get; set; }

        public int SubCategory_Id { get; set; }

        public string SizeId { get; set; }

        public string ColorId { get; set; }

        public string Product_Title { get; set; }

        public string Product_Description { get; set; }

        public string Image_Name { get; set; }

        public HttpPostedFileBase MenFrontImgFile { get; set; }

        public HttpPostedFileBase MenSideImgFile { get; set; }
        public HttpPostedFileBase MenBackImgFile { get; set; }

        public HttpPostedFileBase MenSizeChartImgFile { get; set; }

        public string WomenProductDescription { get; set; }
        public HttpPostedFileBase WomenFrontImgFile { get; set; }

        public HttpPostedFileBase WomenBackImgFile { get; set; }
        public HttpPostedFileBase WomenSideImgFile { get; set; }

        public HttpPostedFileBase WomenSizeChartImgFile { get; set; }


    }

}
