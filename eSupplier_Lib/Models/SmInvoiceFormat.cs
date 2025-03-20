using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmInvoiceFormat
{
    public int Invformatid { get; set; }

    public string? InvoiceFormat { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AddrType { get; set; }
}
