using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AppELibrary
{
    class BookRepository
    {
        private AppContext context;
        public BookRepository()
        {
            context = new AppContext();
        }

        public Book SelectBookById(int id)
        {
            var bookById = context.Books.FirstOrDefault(book => book.Id == id);
            return bookById;
        }

        public Book[] SelectAll()
        {
            var booksAll = context.Books.ToArray<Book>();
            return booksAll;
        }

        public void AddBook(Book book)
        {
            context.Books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            context.Books.Remove(book);
        }

        public void UpdateReleaseYearById(int id, int newYear)
        {
            var bookById = context.Books.FirstOrDefault(book => book.Id == id);
            bookById.ReleaseYearBook = newYear;
            context.SaveChanges();
        }

        public List<Book> SelectBooks(string sort, int year1, int year2)
        {
            var listBooks = context.Books.Where(book => (book.SortBook.Sort == sort) &&
            book.ReleaseYearBook > year1 && book.ReleaseYearBook < year2).ToList();

            return listBooks;
        }

        public int GetCountBooksOfAuthor(string authorName)
        {
            var countBooks = context.Books.Count(book => book.Writer.FirstName == authorName);
            return countBooks;
        }

        public int GetCountBooksOfSort(string sort)
        {
            var countBooks = context.Books.Count(book => book.SortBook.Sort == sort);
            return countBooks;
        }

        public bool IsAuthorAndTitleInLib(string authorName, string bookTitle)
        {
            var isInLib = context.Books.Any(book => book.TitleBook == bookTitle && book.Writer.FirstName == authorName);
            return isInLib;
        }    

        public Book GetlastYearBook(int year)
        {
            int currentYear = DateTime.Now.Year;

            var lastYearBook = context.Books.FirstOrDefault(book => book.ReleaseYearBook == currentYear);
            return lastYearBook;
        } 

        public List<Book> GetAllListBooks()
        {
            var listBooks = context.Books.OrderBy(book => book.TitleBook).ToList();
            return listBooks;
        }

        public List<Book> GetAllSortAscTitleListBooks()
        {
            var listBooks = context.Books.OrderBy(book => book.TitleBook).ToList();
            return listBooks;
        }

        public List<Book> GetAllSortDescYearListBooks()
        {
            var listBooks = context.Books.OrderByDescending(book => book.ReleaseYearBook).ToList();
            return listBooks;
        }
    }
}
