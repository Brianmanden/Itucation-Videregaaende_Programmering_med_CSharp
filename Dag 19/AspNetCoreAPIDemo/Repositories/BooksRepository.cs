using AspNetCoreAPIDemo.Interfaces;
using AspNetCoreAPIDemo.Models;

namespace AspNetCoreAPIDemo.Repositories
{
    public class BooksRepository : IBooksInterface
    {
        List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title="Bushcraft", Author="Mors Kochanski"},
            new Book { Id = 2, Title="Historier fra en anden verden", Author="Andre Norton, Ernestine Donaldy"},
            new Book { Id = 3, Title="Snøen på Nix Olympica", Author="Øyvind Myhre"},
            new Book { Id = 4, Title="Jonathan Livingston havmåge", Author="Richard Bach"},
            new Book { Id = 5, Title="Kogebog for fattigrøve", Author="Rolf Lund"},
        };

        public Book CreateBook(Book newBook)
        {
            books.Add(newBook);
            return newBook;
        }

        public void DeleteBook(Book bookToBeDeleted)
        {
            books.Remove(bookToBeDeleted);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            Book foundBook = books.FirstOrDefault(book => book.Id == id);
            return foundBook;
        }

        public Book UpdateBook(Book book)
        {
            Book bookInList = GetBookById(book.Id);
            bookInList.Title = book.Title;
            bookInList.Author = book.Author;

            return bookInList;
        }
    }
}
