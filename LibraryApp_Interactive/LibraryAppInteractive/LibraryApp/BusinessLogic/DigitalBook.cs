using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    public class DigitalBook : Book
    {
        private int _maxBorrowDays;
        private float _latePenaltyPerDay;

        public DigitalBook(string bookName, string bookISBN) : base(bookName, bookISBN) { }

        private float DetermineLoanLicense() => 0.0f;

        public override LibraryAsset BorrowBook()
        {
            var asset = findNextAvailableAsset();
            if (asset != null) asset.Status = AssetStatus.Loaned;
            return asset;
        }

        public override (TimeSpan, int, decimal) ReturnBook(int libID)
        {
            var asset = findLibraryAsset(libID);
            if (asset != null) asset.Status = AssetStatus.Available;
            return (TimeSpan.Zero, 0, 0m);
        }
    }
}
