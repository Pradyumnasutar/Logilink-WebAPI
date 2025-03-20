using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesMonitorLoginHistory
{
    public int LoginTrackId { get; set; }

    public int? Userid { get; set; }

    public string? Sessionid { get; set; }

    public string? ClientServerIp { get; set; }

    public DateTime? LoggedIn { get; set; }

    public string? LoggedInRemarks { get; set; }

    public DateTime? LoggedOut { get; set; }

    public string? LoggedOutRemarks { get; set; }

    public DateTime? UpdateDate { get; set; }
}
