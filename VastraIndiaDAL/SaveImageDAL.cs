
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace VastraIndiaDAL
{
    public class SaveImageDAL
    {

        public async Task SaveImagesAsync(HttpPostedFileBase formFile, string FileName, string FolderName)
        {
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                var file = formFile;

                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), FolderName);
                if (file.ContentLength > 0)
                {
                    var fileName = FileName;
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(FolderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.SaveAs(fullPath);
                    }
                }
            }

            catch (Exception ex)
            {
                //return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        public async Task SaveProductImagesAsync(HttpPostedFileBase MenFrontImage, HttpPostedFileBase MenSideImage, HttpPostedFileBase MenBackImage, HttpPostedFileBase MenSizeChartImage, string MenFrontImageFile, string MenSideImageFile, string MenBackImageFile, string MenSizeChartImageFile, HttpPostedFileBase WomenFrontImage, HttpPostedFileBase WomenSideImage, HttpPostedFileBase WomenBackImage, HttpPostedFileBase WomenSizeChartImage, string WomenFrontImageFile, string WomenSideImageFile, string WomenBakImageFile, string WomenSizeChartImageFile, string FolderName)
        {
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                var file = MenFrontImage;

                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), FolderName);
                if (file.ContentLength > 0)
                {
                    //var fileName = MenFrontImageFile;
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenFrontImageFile);
                    var dbPath = Path.Combine(FolderName, MenFrontImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.SaveAs(fullPath);
                    }
                }

                var file1 = MenSideImage;

                if (file1.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenSideImageFile);
                    var dbPath = Path.Combine(FolderName, MenSideImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file1.SaveAs(fullPath);
                    }
                }


                var file2 = MenBackImage;

                if (file2.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenBackImageFile);
                    var dbPath = Path.Combine(FolderName, MenBackImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file2.SaveAs(fullPath);
                    }
                }

                var file3 = MenSizeChartImage;

                if (file3.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenSizeChartImageFile);
                    var dbPath = Path.Combine(FolderName, MenSizeChartImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file3.SaveAs(fullPath);
                    }
                }

                var file4 = WomenFrontImage;

                if (file4.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenFrontImageFile);
                    var dbPath = Path.Combine(FolderName, WomenFrontImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file4.SaveAs(fullPath);
                    }
                }

                var file5 = WomenSideImage;

                if (file5.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenSideImageFile);
                    var dbPath = Path.Combine(FolderName, WomenSideImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file5.SaveAs(fullPath);
                    }
                }


                var file6 = WomenBackImage;

                if (file6.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenBakImageFile);
                    var dbPath = Path.Combine(FolderName, WomenBakImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file6.SaveAs(fullPath);
                    }
                }

                var file7 = WomenSizeChartImage;

                if (file7.ContentLength > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenSizeChartImageFile);
                    var dbPath = Path.Combine(FolderName, WomenSizeChartImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file7.SaveAs(fullPath);
                    }
                }
            }

            catch (Exception ex)
            {
                //return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}