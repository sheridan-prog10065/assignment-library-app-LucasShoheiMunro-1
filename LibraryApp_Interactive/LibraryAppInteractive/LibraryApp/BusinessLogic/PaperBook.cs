using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    public class PaperBook : Book
    {
        private const int MAX_BORROW_DAYS = 30;
        private const float LATE_PENALTY_PER_DAY = 0.25f;

        public PaperBook(string bookName, string bookISBN) : base(bookName, bookISBN) { }

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
