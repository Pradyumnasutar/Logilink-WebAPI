using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MxmlTransactionHeader
{
    public Guid Mxmldocid { get; set; }

    public string? Payloadid { get; set; }

    public string? ServerTimestamp { get; set; }

    public string? FromPartyid { get; set; }

    public string? FromAdapteruid { get; set; }

    public string? ToPartyid { get; set; }

    public string? Doctype { get; set; }

    public string? Useragent { get; set; }

    public virtual ICollection<MxmlAddress> MxmlAddresses { get; set; } = new List<MxmlAddress>();

    public virtual ICollection<MxmlDocItem> MxmlDocItems { get; set; } = new List<MxmlDocItem>();
}
