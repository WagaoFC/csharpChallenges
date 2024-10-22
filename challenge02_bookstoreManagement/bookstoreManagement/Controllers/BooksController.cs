using Microsoft.AspNetCore.Http;
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
}
