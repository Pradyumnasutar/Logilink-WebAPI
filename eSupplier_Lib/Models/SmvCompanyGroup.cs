using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvCompanyGroup
{
    public string? AddrName { get; set; }

    public string? AddrCode { get; set; }

    public string? CompanyGroupCode { get; set; }

    public string? CompanyGroupType { get; set; }

    public int CompanyGroupId { get; set; }

    public int Addressid { get; set; }
}
