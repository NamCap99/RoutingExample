using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace RoutingExample.Controllers
{
    //[ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok(new[] {"Product 1", "Product 2"});

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(new[] { $"Product ID: {id}" });


        [HttpPost]
        public IActionResult Create([FromBody] string name) => Ok($"Created {name}");
    }
}
