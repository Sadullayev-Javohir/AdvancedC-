using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private static List<Product> _products = new List<Product>()
    {
        new Product() {Id = 1, Name= "Samsung"},
        new Product() {Id = 2, Name = "Nokia"} 
    };
    // GET api/products/
    [HttpGet]
    public IActionResult GetAll() => Ok(_products);
    
    // GET api/products/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _products.FirstOrDefault(x => x.Id == id);
        return product == null ? NotFound() : Ok(product);
    } 
    
    // POST: api/products
    [HttpPost]
    public IActionResult Create(Product product)
    {
        _products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }
}
