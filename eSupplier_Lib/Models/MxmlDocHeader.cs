using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MxmlDocHeader
{
    public Guid Mxmldocheaderid { get; set; }

    public Guid? Mxmldocid { get; set; }

    public string? DocPayloadid { get; set; }

    public DateTime? ReqDeliveryDate { get; set; }

    public string? Quoteid { get; set; }

    public string? Originatingsystemref { get; set; }

    public DateTime? QuoteDate { get; set; }

    public DateTime? ReplyByDate { get; set; }

    public DateTime? QuoteExpiryDate { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Messagenumber { get; set; }

    public string? DeliveryPort { get; set; }

    public string? PortName { get; set; }

    public string? DeliveryPier { get; set; }

    public string? VesselId { get; set; }

    public string? VesselName { get; set; }

    public DateTime? Arrivaldate { get; set; }

    public DateTime? Departuredate { get; set; }

    public string? DocCurrency { get; set; }

    public double? DocTotalAmount { get; set; }

    public string? DocComments { get; set; }

    public int? Exported { get; set; }

    public string? QuoteComments { get; set; }

    public DateTime? QuoteSubmitDate { get; set; }

    public string? PoMessagenumber { get; set; }

    public string? PoPayloadid { get; set; }

    public string? SupplierQuoteId { get; set; }

    public string? PaymentTerms { get; set; }
}
