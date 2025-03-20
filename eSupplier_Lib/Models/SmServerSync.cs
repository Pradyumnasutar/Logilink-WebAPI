using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmServerSync
{
    public int Serverid { get; set; }

    public string? ServerName { get; set; }

    public string? ServiceUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
