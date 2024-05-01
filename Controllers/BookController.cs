using LibraryApi.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers;
[Route("/")]
[ApiController]
public class BookController : ControllerBase
{


    [HttpPost("/register")]
    [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var newBook = new Book
        {
            Id = Guid.NewGuid().ToString(),
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
            Price = request.Price,
            Supply = request.Supply,
        };


        return Created(string.Empty, newBook.Id);
    }

    [HttpGet("/books")]
    [ProducesResponseType<List<Book>>(StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        List<Book> books = new List<Book>();

        books.Add(new Book
        {
            Id = Guid.NewGuid().ToString(),
            Title = "Percy Jackson and the Olympians",
            Author = "Rick Riordan",
            Gender = "History, Fantasy",
            Price = "129.00",
            Supply = 10,
        });

        books.Add(new Book
        {
            Id = Guid.NewGuid().ToString(),
            Title = "The Fault in Our Stars",
            Author = "John Green",
            Gender = "Drama",
            Price = "129.00",
            Supply = 5,
        });

        return Ok(books);
    }

    [HttpPut("/update")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBookJson request) 
    {

        var newBook = new Book
        {
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
            Price = request.Price,
            Supply = request.Supply,
        };

        return NoContent();
    }

    [HttpDelete]
    [Route("delete/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete(string id)
    {
        return NoContent();
    }



}
