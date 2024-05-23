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
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    
    public IActionResult Create([FromBody] RequestCreateBookJson request)
    {
        var _stockMethods = new StockMethods();

            var result = _stockMethods.StockAdd(request);
            if (result == null) {
                return NotFound("Livro já existe no estoque");
            }
            else
            {
                return Created(string.Empty,result);
            }
        
       
    }

    [HttpGet("all-books")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var _stockMethods = new StockMethods();

        var result = _stockMethods.StockGetAll();

        return Ok(result);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(RequestUpdateBookJson updateBook, int id)
    {
        var _stockMethods = new StockMethods();

        var result = _stockMethods.StockUpdate(updateBook, id);
        if (result == null)
        {
            return NotFound("Livro não encontrado");
        }
        return Ok("Livro atualizado com sucesso");
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute]int id)
    {
        var _stockMethods = new StockMethods();
        var result = _stockMethods.StockRemove(id);

        if (result == null)
        {
            return NotFound("Livro não encontrado");
        }

        return NoContent();
    }
}
