using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesIfsTransaction
{
    public int Transactionid { get; set; }

    public string? IfsRequestno { get; set; }

    public string? IfsVendorno { get; set; }

    public int? IfsRevisionNo { get; set; }

    public int? Quotationid { get; set; }

    public string? Vrno { get; set; }

    public int? Released { get; set; }

    public int? Exported { get; set; }

    public string? DocType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
