using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmExternalUser
{
    public int ExUserid { get; set; }

    public int Addressid { get; set; }

    public int? Linkid { get; set; }

    public string? ExUsercode { get; set; }

    public string? ExUsername { get; set; }

    public string? ExPassword { get; set; }

    public string? ExEmailid { get; set; }

    public int? Usertype { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Siteid { get; set; }

    public byte? Exported { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateSite { get; set; }

    public byte? Isactive { get; set; }

    public byte? UpdateInvoice { get; set; }

    public int? PwdExpired { get; set; }

    public int? AccessLevel { get; set; }

    public int? InvUsertype { get; set; }

    public int? DashboardAccess { get; set; }

    public string? CompanyId { get; set; }

    public int? UsertypeLesmonitor { get; set; }
}
