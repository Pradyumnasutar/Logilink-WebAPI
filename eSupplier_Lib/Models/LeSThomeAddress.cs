using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LeSThomeAddress
{
    public int Addressid { get; set; }

    public string? AddrName { get; set; }

    public string? ThomeCode { get; set; }

    public string? LesCode { get; set; }

    public string? EmailId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? LesPwd { get; set; }

    public string? PwdText { get; set; }
}
