using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost("UploadFile")]
        public IActionResult Add([FromForm] FileModel fileModel)
        {
            try
            {
                string path = Path.Combine(@"C:\Users\alkay\OneDrive\Masaüstü\cloudUpload", fileModel.Name);
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    fileModel.File.CopyTo(stream);
                }
                Image image = new Image
                {
                    ImageName = fileModel.Name,
                    ImagePath = path
                };
                _imageService.Add(image);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("Delete")]
        public IActionResult Delete(Image image)
        {
            var result = _imageService.Delete(image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _imageService.GetAll();
            if (result.Success)
            {

                List<ResponseImage> images = new List<ResponseImage>();
                foreach (var item in result.Data)
                {
                    images.Add(new ResponseImage() { Id = item.Id, Name = item.ImageName, ImageBytes = System.IO.File.ReadAllBytes(item.ImagePath) });
                }
                return Ok(images);
            }
            return BadRequest(result);
        }


    }
}
