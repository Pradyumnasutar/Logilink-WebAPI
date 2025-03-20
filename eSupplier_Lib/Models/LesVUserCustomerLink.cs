using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesVUserCustomerLink
{
    public int? Usercustomerlinkid { get; set; }

    public int? Userid { get; set; }

    public int? Usertypeid { get; set; }

    public int? IsConnected { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? Companyid { get; set; }

    public string? CustCode { get; set; }

    public string? CustName { get; set; }

    public string? Usertypedescr { get; set; }

    public string? ExUsercode { get; set; }

    public string? ExUsername { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string CompanyDescription { get; set; } = null!;

    public int Addressid { get; set; }

    public int? CustomerAddressid { get; set; }
}
