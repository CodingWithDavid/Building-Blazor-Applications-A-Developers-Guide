using Microsoft.AspNetCore.Mvc;
using ProductExampleAPI.Models;

namespace ProductExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99m },
            new Product { Id = 2, Name = "Product 2", Price = 20.99m },
            new Product { Id = 3, Name = "Product 3", Price = 30.99m },
            new Product { Id = 4, Name = "Product 4", Price = 40.99m },
            new Product { Id = 5, Name = "Product 5", Price = 50.99m },
            new Product { Id = 6, Name = "Product 6", Price = 60.99m },
            new Product { Id = 7, Name = "Product 7", Price = 70.99m },
            new Product { Id = 8, Name = "Product 8", Price = 80.99m },
            new Product { Id = 9, Name = "Product 9", Price = 90.99m },
            new Product { Id = 10, Name = "Product 10", Price = 100.99m }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> PostProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            // Generate a new Id
            product.Id = products.Any() ? products.Max(p => p.Id) + 1 : 1;

            products.Add(product);

            // Return the newly created product with a 201 status code
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}
