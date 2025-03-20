using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvTransactionsCreditnote
{
    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public string? Ordertype { get; set; }

    public string? DocType { get; set; }

    public string? Supplierorgref { get; set; }

    public string? Udf1 { get; set; }

    public int? VendorStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? RfqAckDate { get; set; }

    public DateTime? QuoteRecvdDate { get; set; }

    public double? Freightamt { get; set; }

    public double? QuoteAmount { get; set; }

    public double? Othercosts { get; set; }

    public string? CurrCode { get; set; }

    public DateTime? QuoteValidity { get; set; }

    public DateTime? Podate { get; set; }

    public DateTime? PoAckDate { get; set; }

    public DateTime? PocDate { get; set; }

    public string? PocReference { get; set; }

    public string? PortName { get; set; }

    public string? VesselName { get; set; }

    public string? VesselIdno { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? IsDeclined { get; set; }

    public byte? Version { get; set; }

    public string? Invoiceno { get; set; }

    public int? GrnStatus { get; set; }

    public int? Invoiceid { get; set; }

    public string? QuoteReference { get; set; }
}
