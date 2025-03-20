using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInvoiceaging
{
    public int Invageid { get; set; }

    public int? Invoiceid { get; set; }

    public string? Zeroday { get; set; }

    public string? Oneto30days { get; set; }

    public string? Inv31to60days { get; set; }

    public string? Inv61to90days { get; set; }

    public string? Grt90days { get; set; }

    public int? Customerid { get; set; }

    public decimal? TotalPayables { get; set; }
}
