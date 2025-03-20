using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmInvoiceAddrlink
{
    public int? Linkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BankDetails { get; set; }

    public string? AccountNum { get; set; }

    public string? IbanNum { get; set; }

    public string? SwiftNum { get; set; }
}
