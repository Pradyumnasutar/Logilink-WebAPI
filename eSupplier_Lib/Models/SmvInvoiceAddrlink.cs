using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvInvoiceAddrlink
{
    public int Addressid { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public int SuppId { get; set; }

    public string? SuppCode { get; set; }

    public string? SuppName { get; set; }
}
