using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    public abstract class Book
    {
        private string _bookName;
        private string _bookISBN;
        private List<string> _bookAuthorList;
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

        protected Book(string bookName, string bookISBN)
        {
            _bookName = bookName;
            _bookISBN = bookISBN;
            _bookAuthorList = new List<string>();
        }

        public (bool, LibraryAsset) CheckAvailability()
        {
            foreach (var asset in _libAssetList)
            {
                if (asset.IsAvailable) return (true, asset);
            }
            return (false, null);
        }

        public abstract LibraryAsset BorrowBook();
        public abstract (TimeSpan, int, decimal) ReturnBook(int libID);

        protected LibraryAsset findLibraryAsset(int libID) => _libAssetList.Find(slctdBook => slctdBook.LibID == libID);

        protected LibraryAsset findNextAvailableAsset() => _libAssetList.Find(slctdBook => slctdBook.IsAvailable);
    }
}
