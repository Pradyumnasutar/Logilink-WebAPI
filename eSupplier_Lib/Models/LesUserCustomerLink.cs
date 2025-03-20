using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesUserCustomerLink
{
    public int Usercustomerlinkid { get; set; }

    public int? Userid { get; set; }

    public int? Usertypeid { get; set; }

    public int? IsConnected { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? Companyid { get; set; }

    public int? CustomerAddressid { get; set; }
}
