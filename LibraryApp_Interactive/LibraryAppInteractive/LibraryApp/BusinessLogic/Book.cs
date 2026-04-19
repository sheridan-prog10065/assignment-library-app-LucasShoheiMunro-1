using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// The base class of Book, details are fleshed out in the derived classes.
    /// </summary>
    public abstract class Book
    {
        /// <summary>
        /// Represents a book's name.
        /// </summary>
        private string _bookName;

        /// <summary>
        /// The ISBN for a book.
        /// </summary>
        private string _bookISBN;

        /// <summary>
        /// List of authors.
        /// </summary>
        private List<string> _bookAuthorList;

        /// <summary>
        /// List of saved books.
        /// </summary>
        private List<LibraryAsset> _libAssetList = new List<LibraryAsset>();

        public string Name
        {
            get { return _bookName; }
        }

        public string ISBN
        {
            get { return _bookISBN; }
        }

        public List<string> Authors
        {
            get { return _bookAuthorList; }
        }

        public IEnumerable<LibraryAsset> Assets
        {
            get { return _libAssetList; }
        }

        /// <summary>
        /// Constructor for Book.
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="bookISBN"></param>
        protected Book(string bookName, string bookISBN)
        {
            _bookName = bookName;
            _bookISBN = bookISBN;
            _bookAuthorList = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public (bool, LibraryAsset) CheckAvailability()
        {
            foreach (var asset in _libAssetList)
            {
                if (asset.IsAvailable) return (true, asset);
            }
            return (false, null);
        }

        /// <summary>
        /// Method to borrow a book.
        /// </summary>
        /// <returns></returns>
        public abstract LibraryAsset BorrowBook();

        /// <summary>
        /// Method to return a book.
        /// </summary>
        /// <param name="libID"></param>
        /// <returns></returns>
        public abstract (TimeSpan, int, decimal) ReturnBook(int libID);

        /// <summary>
        /// Search for a book.
        /// </summary>
        /// <param name="libID"></param>
        /// <returns></returns>
        protected LibraryAsset findLibraryAsset(int libID) => _libAssetList.Find(slctdBook => slctdBook.LibID == libID);

        /// <summary>
        /// Find if book is available.
        /// </summary>
        /// <returns></returns>
        protected LibraryAsset findNextAvailableAsset() => _libAssetList.Find(slctdBook => slctdBook.IsAvailable);
    }
}
