using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesVBrokerCustomerLink
{
    public long? RowNum { get; set; }

    public int Brokercustlinkid { get; set; }

    public int Brokerid { get; set; }

    public int Customerid { get; set; }

    public int IsConnected { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string? CustCode { get; set; }

    public string? CustName { get; set; }

    public string? AddrType { get; set; }

    public int? Companyid { get; set; }

    public int? BrokerName { get; set; }

    public int? Addressid { get; set; }
}
