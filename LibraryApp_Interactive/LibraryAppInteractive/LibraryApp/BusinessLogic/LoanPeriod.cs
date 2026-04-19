using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    public struct LoanPeriod
    {
        private DateTime _borrowedOn;
        private DateTime _returnedOn;
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

        public LoanPeriod(DateTime borrowedOn, DateTime returnedOn)
        {
            _borrowedOn = borrowedOn;
            _returnedOn = returnedOn;
            _dueDate = borrowedOn.AddDays(14);
        }
    }
}
