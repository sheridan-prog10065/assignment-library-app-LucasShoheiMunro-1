using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    public class LibraryAsset
    {
        private Book _book;
        private int _libID;
        private AssetStatus _status;
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

        public LibraryAsset(int libID, Book book)
        {
            _libID = libID;
            _book = book;
            _status = AssetStatus.Available;
        }
    }
}
