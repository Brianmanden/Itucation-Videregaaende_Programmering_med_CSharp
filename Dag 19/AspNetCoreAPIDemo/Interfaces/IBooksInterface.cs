using AspNetCoreAPIDemo.Models;

namespace AspNetCoreAPIDemo.Interfaces
{
    public interface IBooksInterface
    {
        List<Book> GetAllBooks();               // GET
        Book GetBookById(int id);               // GET
        Book CreateBook(Book book);             // POST
        Book UpdateBook(Book book);             // PATCH or PUT
        void DeleteBook(Book bookToBeDeleted);  // DELETE
    }
}
