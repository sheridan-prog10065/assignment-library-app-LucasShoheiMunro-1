using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive.BusinessLogic
{
    /// <summary>
    /// Enumerator that represents a book's status at the moment.
    /// </summary>
    public enum AssetStatus
    {
        NotAvailable,
        Available,
        Loaned,
        Reserved
    }
}
