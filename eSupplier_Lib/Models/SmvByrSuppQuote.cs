using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvByrSuppQuote
{
    public int Quotationid { get; set; }

    public int Linkid { get; set; }

    public int? Buyerid { get; set; }

    public string? BuyerLinkCode { get; set; }

    public string? VendorLinkCode { get; set; }

    public string? SuppSenderCode { get; set; }

    public string? SuppReceiverCode { get; set; }

    public string? ByrSenderCode { get; set; }

    public string? ByrReceiverCode { get; set; }

    public string? Vrno { get; set; }

    public int? Supplierid { get; set; }
}
