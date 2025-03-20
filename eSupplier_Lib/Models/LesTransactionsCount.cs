using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesTransactionsCount
{
    public int TransactionId { get; set; }

    public string ClientCode { get; set; } = null!;

    public int? Rfqcount { get; set; }

    public int? QuoteCount { get; set; }

    public int? Pocount { get; set; }

    public int? Poccount { get; set; }

    public DateTime? ExecutionDate { get; set; }

    public long? RowTotal { get; set; }

    public long? Total { get; set; }

    public bool? SendAlert { get; set; }
}
