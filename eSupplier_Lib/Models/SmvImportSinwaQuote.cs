using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportSinwaQuote
{
    public string? VendorFormat { get; set; }

    public int Addressid { get; set; }

    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public string? AddrInbox { get; set; }

    public int Linkid { get; set; }

    public int? GroupId { get; set; }
}
