using DesafioDotNetCoreKhipo.Interfaces;
using DesafioDotNetCoreKhipo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDotNetCoreKhipo.api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class products : ControllerBase
    {

        private readonly IProductsService productsService;
        public products(IProductsService productsService)
        {
            this.productsService = productsService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await this.productsService.GetProducts();

            if (products == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No products in database");
            }

            return StatusCode(StatusCodes.Status200OK, products);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetProducts(int id)
        {
            Products products = await this.productsService.GetProducts(id);

            if (products == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"No Products found for id: {id}");
            }

            return StatusCode(StatusCodes.Status200OK, products);
        }

        [HttpPost]
        public async Task<ActionResult<Products>> AddProducts(Products products)
        {
            var dbProducts = await this.productsService.AddProducts(products);

            if (dbProducts == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{products.Name} could not be added.");
            }

            return CreatedAtAction("GetProducts", new { id = products.ID }, products);
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateProducts(int id, Products products)
        {
            if (id != products.ID)
            {
                return BadRequest();
            }

            Products dbProducts = await this.productsService.UpdateProducts(products);

            if (dbProducts == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{products.Name} could not be updated");
            }

            return CreatedAtAction("GetProducts", new { id = products.ID }, products);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteProducts(int id)
        {
            var products = await this.productsService.GetProducts(id);
            if (products == null)
                return StatusCode(StatusCodes.Status204NoContent, "Product not found");

            (bool status, string message) = await this.productsService.DeleteProducts(products);

            if (status == false)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }

            return StatusCode(StatusCodes.Status200OK, products);
        }
    }
}
