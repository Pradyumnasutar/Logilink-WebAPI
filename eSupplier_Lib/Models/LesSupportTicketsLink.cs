using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesSupportTicketsLink
{
    public int AutoNumber { get; set; }

    public int? TicketNo { get; set; }

    public string? Refkey2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
