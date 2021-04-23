using MediatorExample.Domain.Command.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [Route("AddProduct")]
        [HttpPost]
        public IActionResult AddProduct(ProductAddCommand productAddCommand)
        {
            return Ok();
        }

        [Route("UpdateProduct")]
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }

        [Route("RemoveProduct")]
        [HttpDelete]
        public IActionResult RemoveProduct()
        {
            return Ok();
        }

        [Route("GetAllProduct")]
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return Ok();
        }
    }
}
