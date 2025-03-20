using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvQuoteHeaderMtml
{
    public Guid Mtmldocid { get; set; }

    public string? Controlreference { get; set; }

    public string? Identifier { get; set; }

    public string? Preparationdate { get; set; }

    public string? Preparationtime { get; set; }

    public string? Recipeint { get; set; }

    public string? Sender { get; set; }

    public string? Messagereferencenumber { get; set; }

    public string? Messagenumber { get; set; }

    public int? Linecount { get; set; }

    public int? Quotationid { get; set; }

    public string? Vrno { get; set; }

    public string? CurrCode { get; set; }

    public string? QuoteFileRef { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public string? DocType { get; set; }

    public int? VendorStatus { get; set; }

    public string? Versionnumber { get; set; }

    public int? ByrSuppLinkid { get; set; }

    public string? Originatingsystemref { get; set; }

    public string? Referencenumber { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public string? SupplierExportFormat { get; set; }

    public string? ImportPath { get; set; }

    public string? ExportPath { get; set; }

    public int? Linkid { get; set; }

    public DateTime? RfqAckDate { get; set; }

    public DateTime? PoAckDate { get; set; }
}
