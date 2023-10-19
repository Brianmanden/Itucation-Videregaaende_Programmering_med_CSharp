using AspNetCoreAPIDemo.Interfaces;
using AspNetCoreAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksInterface _booksRepository;

        public BooksController(IBooksInterface booksRepository)
        {
            _booksRepository = booksRepository;
        }

        // api/books
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return _booksRepository.GetAllBooks();
        }

        // api/books/{id}
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            Book foundBook = _booksRepository.GetBookById(id);

            if (foundBook != null) {
                return foundBook;
            }
            else
            {
                return NotFound($"Book with id {id} was not found");
            }
        }

        // api/books
        [HttpPost]
        public ActionResult<Book> CreateBook(Book newBook) {
            return _booksRepository.CreateBook(newBook);
        }

        // api/books/id
        [HttpDelete("{id}")]
        public ActionResult DeleteBookById(int id) {
            Book bookToBeDeleted = _booksRepository.GetBookById(id);
            if (bookToBeDeleted != null)
            {
                _booksRepository.DeleteBook(bookToBeDeleted);
                return Ok();
            }
            else
            {
                return NotFound($"Book with id {id} was not found");
            }
        }

        // api/books
        [HttpPut, HttpPatch]
        public ActionResult<Book> UpdateBook(Book bookToBeUpdated)
        {
            Book bookInList = _booksRepository.GetBookById(bookToBeUpdated.Id);

            if (bookInList != null)
            {
                _booksRepository.UpdateBook(bookToBeUpdated);
                return Ok();
            }
            else
            {
                return NotFound($"Book with id {bookToBeUpdated.Id} was not found");
            }
        }
    }
}