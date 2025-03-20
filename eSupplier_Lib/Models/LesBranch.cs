using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesBranch
{
    public int Branchid { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public int? Addressid { get; set; }

    public int? BranchAddressid { get; set; }

    public virtual SmAddress? Address { get; set; }
}
