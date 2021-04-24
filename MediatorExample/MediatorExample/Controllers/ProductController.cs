using MediatorExample.Application.Interfaces;
using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Queries.Request;
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
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("AddProduct")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddCommand productAddCommand)
        {
            return Ok(await _productService.AddProduct(productAddCommand));
        }

        [Route("UpdateProduct")]
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateCommand productUpdateCommand)
        {
            return Ok(await _productService.UpdateProduct(productUpdateCommand));
        }

        [Route("RemoveProduct")]
        [HttpDelete]
        public async Task<IActionResult> RemoveProduct(ProductRemoveCommand productRemoveCommand)
        {
            return Ok(await _productService.RemoveProduct(productRemoveCommand));
        }

        [Route("GetAllProduct")]
        [HttpGet]
        public async Task<IActionResult> GetAllProduct([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return Ok(await _productService.GetAllProduct(getAllProductQueryRequest));
        }

        [Route("GetProduct")]
        [HttpGet]
        public async Task<IActionResult> GetProduct([FromQuery] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            return Ok(await _productService.GetByIdProduct(getByIdProductQueryRequest));
        }
    }
}
