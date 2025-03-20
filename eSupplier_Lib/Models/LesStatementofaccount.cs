using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesStatementofaccount
{
    public int SoaId { get; set; }

    public int? Customerid { get; set; }

    public string? CustCode { get; set; }

    public string? CustName { get; set; }

    public int? Supplierid { get; set; }

    public string? Month { get; set; }

    public int? Year { get; set; }

    public DateTime? SoaDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Filename { get; set; }

    public string? DocType { get; set; }
}
