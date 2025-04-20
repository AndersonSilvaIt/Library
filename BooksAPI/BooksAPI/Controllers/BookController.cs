using BooksAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = GetMockBooks();
            return Ok(books);
        }

        private IEnumerable<BookViewModel> GetMockBooks()
        {
            return new List<BookViewModel>
                {
                    new BookViewModel { Id = Guid.NewGuid(), Title = "1984",                  Author = "George Orwell",            PublicationDate = new DateTime(1949,  6,  8), Price = 29.90m },
                    new BookViewModel { Id = Guid.NewGuid(), Title = "Clean Code",            Author = "Robert C. Martin",         PublicationDate = new DateTime(2008,  8,  1), Price = 79.50m },
                    new BookViewModel { Id = Guid.NewGuid(), Title = "The Pragmatic Programmer", Author = "Andrew Hunt e David Thomas", PublicationDate = new DateTime(1999, 10, 30), Price = 89.90m },
                    new BookViewModel { Id = Guid.NewGuid(), Title = "Domain-Driven Design",  Author = "Eric Evans",               PublicationDate = new DateTime(2003,  8, 30), Price = 99.00m }
                };
        }
    }
}