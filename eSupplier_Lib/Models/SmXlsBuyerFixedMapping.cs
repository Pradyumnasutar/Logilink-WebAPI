using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmXlsBuyerFixedMapping
{
    public int XlsByrMapid { get; set; }

    public int? Buyerid { get; set; }

    public string? Location { get; set; }

    public string? ExcelCell { get; set; }

    public string? ExcelValue { get; set; }

    public DateTime? UpdateDate { get; set; }
}
