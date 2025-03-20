using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportSincereindPdf
{
    public int Linkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerMapping { get; set; }

    public string? SupplierMapping { get; set; }

    public string? ImportPath { get; set; }

    public int? GroupId { get; set; }
}
