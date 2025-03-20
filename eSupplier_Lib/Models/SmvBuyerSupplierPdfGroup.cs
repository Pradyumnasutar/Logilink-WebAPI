using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvBuyerSupplierPdfGroup
{
    public int GroupId { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupDesc { get; set; }

    public string? BuyerFormat { get; set; }

    public string? SupplierFormat { get; set; }

    public string? BuyerExportFormat { get; set; }

    public string? SupplierExportFormat { get; set; }

    public DateTime? UpdateDate { get; set; }
}
