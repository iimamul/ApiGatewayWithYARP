using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        IEnumerable<Product> productList = new List<Product>
        {
            new Product{Id = 1, Name="Somusa"  },
            new Product{Id = 2, Name="Singara"  },
        };

        return productList;
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}
