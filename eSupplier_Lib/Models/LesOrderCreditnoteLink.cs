using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesOrderCreditnoteLink
{
    public int Keyid { get; set; }

    public int Quotationid { get; set; }

    public int Invoiceid { get; set; }

    public string? Invoiceno { get; set; }

    public int GrnStatus { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual SmQuotationsVendor Quotation { get; set; } = null!;
}
