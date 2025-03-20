using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesSupportTicket
{
    public int AutoNumber { get; set; }

    public int? TicketNo { get; set; }

    public string? Subject { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? Comments { get; set; }

    public DateTime? ClosedTime { get; set; }

    public string? ZohoId { get; set; }

    public string? ZohoTeamid { get; set; }

    public string? ZohoThreadcount { get; set; }

    public string? ZohoWeburl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Refkey1 { get; set; }

    public string? Refkey2 { get; set; }

    public string? Refkey3 { get; set; }
}
