using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MastCompany
{
    public int Companyid { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string CompanyDescription { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Logopath { get; set; }

    public int Addressid { get; set; }
}
