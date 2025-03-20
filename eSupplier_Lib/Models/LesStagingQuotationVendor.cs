using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesStagingQuotationVendor
{
    public int Quotationid { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public int? ByrSuppLinkid { get; set; }

    public string? Vessel { get; set; }

    public string? Category { get; set; }

    public string? Currency { get; set; }

    public int? Itemcount { get; set; }

    public double? QuoteAmount { get; set; }

    public double? QuoteExchrate { get; set; }

    public int? VendorStatus { get; set; }

    public int? Deliverydays { get; set; }

    public int? IsDeclined { get; set; }

    public int? LinkRecordid { get; set; }

    public string? DocType { get; set; }

    public int? CreatedDateInt { get; set; }

    public int? Exported { get; set; }
}
