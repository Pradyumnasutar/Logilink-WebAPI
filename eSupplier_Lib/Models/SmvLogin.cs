using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvLogin
{
    public int Addressid { get; set; }

    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public string? AddrType { get; set; }

    public short? AddrIsactive { get; set; }

    public int ExUserid { get; set; }

    public int? Linkid { get; set; }

    public string? ExUsercode { get; set; }

    public string? ExUsername { get; set; }

    public string? ExPassword { get; set; }

    public string? ExEmailid { get; set; }

    public int? Usertype { get; set; }

    public byte? ExusersIsactive { get; set; }

    public int? InvUsertype { get; set; }
}
