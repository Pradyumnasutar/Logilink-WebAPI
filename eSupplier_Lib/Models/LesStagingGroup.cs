using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesStagingGroup
{
    public int StagingGroupid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? VesselName { get; set; }

    public string? CurrCode { get; set; }

    public int? Brokerid { get; set; }

    public string? Category { get; set; }
}
