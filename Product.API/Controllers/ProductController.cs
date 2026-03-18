using Microsoft.AspNetCore.Mvc;
using Product.Application.DTO.Request;
using Product.Application.Interfaces;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<IActionResult> Get(int productId)
        {
            var data = await _productService.GetProductAsync(productId);

            return Ok(data);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _productService.GetProductAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductRequest request)
        {
            var data = await _productService.CreateProductAsync(request);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}
