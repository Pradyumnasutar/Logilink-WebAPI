using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportManPdf
{
    public int Linkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerLinkCode { get; set; }

    public string? VendorLinkCode { get; set; }

    public string? BuyerFormat { get; set; }

    public short? IsActive { get; set; }

    public int? GroupId { get; set; }

    public string? Buyer { get; set; }

    public string? BuyerName { get; set; }

    public string? Supplier { get; set; }

    public string? SupplierName { get; set; }

    public string? ImportPath { get; set; }
}
