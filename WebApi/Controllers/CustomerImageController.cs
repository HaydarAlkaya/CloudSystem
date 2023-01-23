using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerImageController : ControllerBase
    {
        ICustomerImagesService _customerImagesService;
        public CustomerImageController(ICustomerImagesService customerImagesService)
        {
            _customerImagesService= customerImagesService;
        }

        [HttpPost("Add")]
        public IActionResult Add(CustomerImages customerImages)
        {
            var result = _customerImagesService.Add(customerImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(CustomerImages customerImages)
        {
            var result = _customerImagesService.Delete(customerImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(CustomerImages customerImages)
        {
            var result = _customerImagesService.Update(customerImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _customerImagesService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _customerImagesService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
