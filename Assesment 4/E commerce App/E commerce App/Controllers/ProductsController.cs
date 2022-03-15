#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_commerce_App;
using E_commerce_App.Data;

namespace E_commerce_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }
        //Gets the products of same category and with price >1000
        // GET: api/Products
        [HttpGet("Category")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductByCategory(string category)
        {
            var products = from cust in _context.Products
                           where cust.Product_Category == category && cust.Product_Price > 1000
                           select cust;
            if (products == null)
                return BadRequest("Not Found");
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
//Updates the details of the preregirsetred object
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Product_Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        //New Products could be added multiple post requests....
        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<Product>> AddProdcuts([FromBody] List<Product> products)
        {
            foreach(Product product in products)
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(await _context.Products.ToListAsync());
        }

 
        //Deletes the product when name is provided

        // DELETE: api/Products/Name
        [HttpDelete("{name}")]
        public async Task<ActionResult> DeleteProdcutByName(string name)
        {
            var product = _context.Products.Where(x => x.Product_Name == name).Single<Product>();
            if (product == null)
                return BadRequest("Not Found");
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok(await _context.Products.ToListAsync());
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Product_Id == id);
        }
    }
}
