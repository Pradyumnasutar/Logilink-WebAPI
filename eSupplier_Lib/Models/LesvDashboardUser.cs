using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesvDashboardUser
{
    public int Addressid { get; set; }

    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public int Userid { get; set; }

    public string? Loginid { get; set; }

    public string? Username { get; set; }

    public string? Mail { get; set; }

    public string? SecCode { get; set; }

    public int? Usertype { get; set; }

    public string? Usertypedescr { get; set; }

    public byte? Isactive { get; set; }

    public string UserStatus { get; set; } = null!;

    public int? DashboardAccess { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Companyid { get; set; }
}
