using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TcheloLibrary.Communication.Requests;
using TcheloLibrary.Entities;

namespace TcheloLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StockController : TcheloBooksBaseController
{
    [HttpPost("create-book")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Create([FromBody] RequestCreateBookJson request)
    {
        var book = new Book
        {
            Title = request.Title,
            Author = request.Author,
            Price = request.Price,
            StockQnt = request.StockQnt,
        };
        
        return Ok(book);
    }
}
