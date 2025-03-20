using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesResendDocNotify
{
    public int ResendId { get; set; }

    public int? QuotationId { get; set; }

    public string? DocType { get; set; }

    public DateTime? UpdateDate { get; set; }
}
