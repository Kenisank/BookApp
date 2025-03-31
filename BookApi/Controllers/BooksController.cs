using BookApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace BookApi.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult GetBooks()
        {
            return Ok(_books);
        }




















        private Book[] _books = new Book[]
        {
            new Book {Id=1, Author= "Author One", Title="Book One"},
            new Book {Id=2, Author= "Author Two", Title="Book Two"},
            new Book {Id=3, Author= "Author Three", Title="Book Three"},
            new Book {Id=4, Author= "Author Four", Title="Book Four"}
        };
    }
}