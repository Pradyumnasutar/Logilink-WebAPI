using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesBrokerCustomerLink
{
    public int Brokercustlinkid { get; set; }

    public int? Brokerid { get; set; }

    public int? Customerid { get; set; }

    public int? IsConnected { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
