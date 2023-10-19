using AspNetCoreAPIDemo.Interfaces;
using AspNetCoreAPIDemo.Models;

namespace AspNetCoreAPIDemo.Repositories
{
    public class BookDatabaseRepository : IBooksInterface
    {
        private readonly BooksDb _db;

        public BookDatabaseRepository(BooksDb booksDb)
        {
            _db = booksDb;
        }

        public Book CreateBook(Book newBook)
        {
            _db.Books.Add(newBook);
            _db.SaveChanges();
            return newBook;

        }

        public void DeleteBook(Book bookToBeDeleted)
        {
            _db.Books.Remove(bookToBeDeleted);
            _db.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _db.Books.Find(id);
        }

        public Book UpdateBook(Book bookToUpdate)
        {
            Book bookInDb = _db.Books.Find(bookToUpdate.Id);
            if (bookInDb != null) {
                bookInDb.Title = bookToUpdate.Title;
                bookInDb.Author = bookToUpdate.Author;
                _db.Books.Update(bookInDb);
                _db.SaveChanges();
            }

            return bookInDb;
        }
    }
}