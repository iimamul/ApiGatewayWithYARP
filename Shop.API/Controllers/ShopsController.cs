using Microsoft.AspNetCore.Mvc;

namespace Shop.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShopsController : ControllerBase
{
    // GET: api/<ShopsController>
    [HttpGet]
    public IEnumerable<Shop> Get()
    {
        return new List<Shop>
        {
            new Shop{ Id = 1, ShopName= "Mina bazar", Location= "sector 11, Uttara"},
            new Shop{ Id = 2, ShopName= "CP", Location= "Ashkona, Dakshinkhan"},
            new Shop{ Id = 3, ShopName= "Bata", Location= "Bot-tola"},
        };
    }

    // GET api/<ShopsController>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //// POST api/<ShopsController>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

}

public class Shop
{
    public int Id { get; set; }
    public string ShopName { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}
