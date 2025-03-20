using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesLoginHistory
{
    public int LoginTrackId { get; set; }

    public int Userid { get; set; }

    public string? ExUsercode { get; set; }

    public string Sessionid { get; set; } = null!;

    public string? LoggedIn { get; set; }

    public string? LoggedInRemarks { get; set; }

    public string? LoggedOut { get; set; }

    public string? LoggedOutRemarks { get; set; }

    public string ClientServerIp { get; set; } = null!;

    public DateTime UpdateDate { get; set; }
}
