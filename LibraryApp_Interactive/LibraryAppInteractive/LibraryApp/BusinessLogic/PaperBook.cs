using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// Represents a physical book, derives from Book.
    /// </summary>
    public class PaperBook : Book
    {
        /// <summary>
        /// The max days user can borrow a book.
        /// </summary>
        private const int MAX_BORROW_DAYS = 30;

        /// <summary>
        /// The late penalty past due date.
        /// </summary>
        private const float LATE_PENALTY_PER_DAY = 0.25f;

        /// <summary>
        /// Constructor for PaperBook.
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="bookISBN"></param>
        public PaperBook(string bookName, string bookISBN) : base(bookName, bookISBN) { }

        /// <summary>
        /// Method to borrow a book.
        /// </summary>
        /// <returns></returns>
        public override LibraryAsset BorrowBook()
        {
            var asset = findNextAvailableAsset();
            if (asset != null) asset.Status = AssetStatus.Loaned;
            return asset;
        }

        /// <summary>
        /// Method to return a book.
        /// </summary>
        /// <param name="libID"></param>
        /// <returns></returns>
        public override (TimeSpan, int, decimal) ReturnBook(int libID)
        {
            var asset = findLibraryAsset(libID);
            if (asset != null) asset.Status = AssetStatus.Available;
            return (TimeSpan.Zero, 0, 0m);
        }
    }
}
