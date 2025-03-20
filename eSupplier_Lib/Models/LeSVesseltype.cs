using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LeSVesseltype
{
    public int Vesseltypeid { get; set; }

    public string? VesseltypeCode { get; set; }

    public string? VesseltypeName { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }
}
