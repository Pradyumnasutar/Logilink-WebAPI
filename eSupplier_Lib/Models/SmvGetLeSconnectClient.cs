using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvGetLeSconnectClient
{
    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public int? Clientid { get; set; }

    public DateTime? LastConnect { get; set; }

    public int? LasConnectBy { get; set; }
}
