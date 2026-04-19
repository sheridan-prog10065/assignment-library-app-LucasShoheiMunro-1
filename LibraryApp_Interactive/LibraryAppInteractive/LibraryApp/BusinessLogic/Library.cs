using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    public class Library
    {
        private List<Book> _bookList = new List<Book>();
        private int _libIDGeneratorSeed;
        private const int DEFAULT_LIBID_START = 100;

        public Library()
        {
            _libIDGeneratorSeed = DEFAULT_LIBID_START;
        }

        public void CreateDefaultBooks() { }

        private int DetermineLibID() => _libIDGeneratorSeed++;

        public Book RegisterBook(string bookName, string bookISBN, string[] authors, BookType bookType, int nCopies)
        {
            Book newBook = bookType switch
            {
                BookType.Paper => new PaperBook(bookName, bookISBN),
                BookType.Digital => new DigitalBook(bookName, bookISBN),
                _ => null
            };

            if (newBook != null) _bookList.Add(newBook);
            return newBook;
        }

        public Book FindBookByName(string bookName) => _bookList.Find(b => b.Name == bookName);
        public Book FindBookByISBN(string bookISBN) => _bookList.Find(b => b.ISBN == bookISBN);
    }
}
