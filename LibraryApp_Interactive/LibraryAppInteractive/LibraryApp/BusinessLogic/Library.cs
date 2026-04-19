using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// Class that represents a library.
    /// </summary>
    public class Library
    {
        /// <summary>
        /// List of books.
        /// </summary>
        private List<Book> _bookList = new List<Book>();

        /// <summary>
        /// 
        /// </summary>
        private int _libIDGeneratorSeed;

        /// <summary>
        /// The default id to start from.
        /// </summary>
        private const int DEFAULT_LIBID_START = 100;

        /// <summary>
        /// Constructor for a Library.
        /// </summary>
        public Library()
        {
        }

        /// <summary>
        /// Create a set of books to be added.
        /// </summary>
        public void CreateDefaultBooks() { }

        /// <summary>
        /// Determines the ID for a book.
        /// </summary>
        /// <returns></returns>
        private int DetermineLibID() => _libIDGeneratorSeed++;

        /// <summary>
        /// Add and register a book to library.
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="bookISBN"></param>
        /// <param name="authors"></param>
        /// <param name="bookType"></param>
        /// <param name="nCopies"></param>
        /// <returns></returns>
        public Book RegisterBook(string bookName, string bookISBN, string[] authors, BookType bookType, int nCopies)
        {
            Book newBook = bookType switch
            {
                BookType.Paper =>
                    new PaperBook(bookName, bookISBN),

                BookType.Digital => 
                    new DigitalBook(bookName, bookISBN),

                _ => null
            };

            if (newBook != null) 
                _bookList.Add(newBook);
            return newBook;
        }

        /// <summary>
        /// Search for a book, by it's name.
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns></returns>
        public Book FindBookByName(string bookName) => _bookList.Find(slctdBook => slctdBook.Name == bookName);

        /// <summary>
        /// Search book by ISBN.
        /// </summary>
        /// <param name="bookISBN"></param>
        /// <returns></returns>
        public Book FindBookByISBN(string bookISBN) => _bookList.Find(slctdBook => slctdBook.ISBN == bookISBN);
    }
}
