using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmXlsBuyerLink
{
    public int XlsBuyerMapid { get; set; }

    public int? ExcelMapid { get; set; }

    public int? BuyerSuppLinkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? MapCell1 { get; set; }

    public string? MapCell1Val1 { get; set; }

    public string? MapCell1Val2 { get; set; }

    public string? MapCell2 { get; set; }

    public string? MapCell2Val { get; set; }

    public string? CompanyName { get; set; }

    public string? MapCellNodisc { get; set; }

    public string? MapCellNodiscVal { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DocType { get; set; }

    public string? FormatMapCode { get; set; }

    public string? XlsSampleFile { get; set; }
}
