using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// A struct that represents the loan period of a book.
    /// </summary>
    public struct LoanPeriod
    {
        /// <summary>
        /// The date a book was borrowed on.
        /// </summary>
        private DateTime _borrowedOn;

        /// <summary>
        /// The date a book was returned on.
        /// </summary>
        private DateTime _returnedOn;

        /// <summary>
        /// The date a book must be returned by.
        /// </summary>
        private DateTime _dueDate;

        public DateTime BorrowedOn
        {
            get { return _borrowedOn; }
            set { _borrowedOn = value; }
        }

        public DateTime ReturnedOn
        {
            get { return _returnedOn; }
            set { _returnedOn = value; }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public TimeSpan LoanDuration
        {
            get { return _returnedOn - _borrowedOn; }
        }

        public TimeSpan LatePeriod
        {
            get
            {
                return DateTime.Now > _dueDate ? DateTime.Now - _dueDate : TimeSpan.Zero;
            }
        }

        /// <summary>
        /// Constructor for LoanPeriod.
        /// </summary>
        /// <param name="borrowedOn"></param>
        /// <param name="returnedOn"></param>
        public LoanPeriod(DateTime borrowedOn, DateTime returnedOn)
        {
            _borrowedOn = borrowedOn;
            _returnedOn = returnedOn;
            _dueDate = borrowedOn.AddDays(14);
        }
    }
}
