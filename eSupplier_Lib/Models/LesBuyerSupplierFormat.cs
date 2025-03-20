using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesBuyerSupplierFormat
{
    public int Formatid { get; set; }

    public int? Addressid { get; set; }

    public string? AllowedFormats { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual SmAddress? Address { get; set; }
}
