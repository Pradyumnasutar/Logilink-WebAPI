using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmCountryCode
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryCode2 { get; set; }

    public string? CountryCode3 { get; set; }

    public int? CountryNumber { get; set; }
}
