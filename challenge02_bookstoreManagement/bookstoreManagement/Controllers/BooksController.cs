using bookstoreManagement.Communication.Requests;
using bookstoreManagement.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace bookstoreManagement.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult SearchAllBooks()
    {
        var response = new Book
        {
            Id = 1,
            Title = "The Hobbit",
            Author = "J.R.R. Tolkien",
            Gender = "Fantasy",
            Price = 10.99f,
            Quantity = 5
        };

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult SearchBooksById([FromRoute] int id)
    {
        var response = new Book
        {
            Id = id,
            Title = "The Hobbit",
            Author = "J.R.R. Tolkien",
            Gender = "Fantasy",
            Price = 10.99f,
            Quantity = 5
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredJson), StatusCodes.Status201Created)]
    public IActionResult ResgisterNewBook([FromBody] RequestRegisteredBookJson request)
    {
        var response = new ResponseRegisteredJson
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateBook([FromRoute] int id, [FromBody] RequestRegisteredBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        return NoContent();
    }
}
