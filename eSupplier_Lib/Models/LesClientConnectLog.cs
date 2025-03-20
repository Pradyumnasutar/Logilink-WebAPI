using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesClientConnectLog
{
    public int Connectid { get; set; }

    public int? Clientid { get; set; }

    public DateTime? LastConnect { get; set; }

    public DateTime? LastConnect1 { get; set; }

    public string? LisenceKey { get; set; }

    public double? NotifyCnt { get; set; }
}
