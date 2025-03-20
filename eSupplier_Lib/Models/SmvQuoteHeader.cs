using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvQuoteHeader
{
    public string? FromPartyid { get; set; }

    public string? ToPartyid { get; set; }

    public string? Doctype { get; set; }

    public string? Quoteid { get; set; }

    public DateTime? ReqDeliveryDate { get; set; }

    public DateTime? QuoteDate { get; set; }

    public string? DocPayloadid { get; set; }

    public DateTime? QuoteExpiryDate { get; set; }

    public string? DeliveryPort { get; set; }

    public string? VesselId { get; set; }

    public string? VesselName { get; set; }

    public string? Originatingsystemref { get; set; }

    public string? Messagenumber { get; set; }

    public string? Payloadid { get; set; }

    public string? PoMessagenumber { get; set; }

    public string? ServerTimestamp { get; set; }

    public string? FromAdapteruid { get; set; }

    public string? Useragent { get; set; }

    public Guid Mxmldocid { get; set; }

    public string? PoPayloadid { get; set; }
}
