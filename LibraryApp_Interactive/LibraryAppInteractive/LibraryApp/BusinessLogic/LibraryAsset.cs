using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// A class that represents a singular asset of the library.
    /// </summary>
    public class LibraryAsset
    {
        /// <summary>
        /// Represents a book.
        /// </summary>
        private Book _book;

        /// <summary>
        /// The id for a book.
        /// </summary>
        private int _libID;

        /// <summary>
        /// Status of a book.
        /// </summary>
        private AssetStatus _status;

        /// <summary>
        /// The details for a book loan.
        /// </summary>
        private LoanPeriod _loanPeriod;

        public int LibID
        {
            get { return _libID; }
        }

        public AssetStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public LoanPeriod Loan
        {
            get { return _loanPeriod; }
            set { _loanPeriod = value; }
        }

        public bool IsAvailable
        {
            get { return _status == AssetStatus.Available; }
        }

        /// <summary>
        /// Constructor for LibraryAsset.
        /// </summary>
        /// <param name="libID"></param>
        /// <param name="book"></param>
        public LibraryAsset(int libID, Book book)
        {
            _libID = libID;
            _book = book;
            _status = AssetStatus.Available;
        }
    }
}
