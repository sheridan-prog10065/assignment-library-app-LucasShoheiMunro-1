using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// Represents a digital book class, that derives from Book.
    /// </summary>
    public class DigitalBook : Book
    {
        /// <summary>
        /// The maximum days a book can be borroed.
        /// </summary>
        private int _maxBorrowDays;

        /// <summary>
        /// A late penalty for each date past due date.
        /// </summary>
        private float _latePenaltyPerDay;

        /// <summary>
        /// Constructor for DigitalBook.
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="bookISBN"></param>
        public DigitalBook(string bookName, string bookISBN) : base(bookName, bookISBN) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private float DetermineLoanLicense() => 0.0f;

        /// <summary>
        /// Method to borrow a book.
        /// </summary>
        /// <returns></returns>
        public override LibraryAsset BorrowBook()
        {
            // Set a variable to the given book provided by user.
            // var asset = findNextAvailableAsset();

            // Check if the book exists, then set it's status to loeaned.
            // if (asset != null) asset.Status = AssetStatus.Loaned;
            return null;
        }

        /// <summary>
        /// Method to return a book.
        /// </summary>
        /// <param name="libID"></param>
        /// <returns></returns>
        public override (TimeSpan, int, decimal) ReturnBook(int libID)
        {
            // Set a variable to the ID of a book chosen.
            // var asset = findLibraryAsset(libID);

            // Check if ID exists, then sets it's status to available.
            // if (asset != null) asset.Status = AssetStatus.Available;
            return (TimeSpan.Zero, 0, 0m);
        }
    }
}
