using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvQuotationsVendorAddress
{
    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public byte? Version { get; set; }

    public string? VesselName { get; set; }

    public string? VesselOwner { get; set; }

    public DateTime? Latedate { get; set; }

    public string? PortName { get; set; }

    public int? VendorStatus { get; set; }

    public string? QuoteReference { get; set; }

    public string? BuyerRemarks { get; set; }

    public string? QuoteRemarks { get; set; }

    public DateTime? ReplyByDate { get; set; }

    public string? NetItemTotal { get; set; }

    public string? CurrCode { get; set; }

    public DateTime? Podate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? QuoteValidity { get; set; }

    public DateTime? QuoteSubmitDate { get; set; }

    public string? BuyerCode { get; set; }

    public string? PocReference { get; set; }

    public DateTime? Deliverytime { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerContact { get; set; }

    public string? BuyerEmail { get; set; }

    public string? BillName { get; set; }

    public string? BillContact { get; set; }

    public string? BillAddress1 { get; set; }

    public string? BillAddress2 { get; set; }

    public string? BillCity { get; set; }

    public string? BillCountry { get; set; }

    public string? BillZipcode { get; set; }

    public string? BillPhone { get; set; }

    public string? BillEmail { get; set; }

    public string? ShipName { get; set; }

    public string? ShipContact { get; set; }

    public string? ShipAddress1 { get; set; }

    public string? ShipAddress2 { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipCountry { get; set; }

    public string? ShipZipcode { get; set; }

    public string? ShipPhone { get; set; }

    public string? ShipEmail { get; set; }

    public string? DocType { get; set; }

    public string? Doctype1 { get; set; }

    public string? BillAddrType { get; set; }

    public string? BuyerAddrType { get; set; }

    public string? ShipAddrType { get; set; }
}
