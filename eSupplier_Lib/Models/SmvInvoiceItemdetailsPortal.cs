using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvInvoiceItemdetailsPortal
{
    public int InvoiceItemid { get; set; }

    public int? Reqninvoiceid { get; set; }

    public short? Itemno { get; set; }

    public string? Partname { get; set; }

    public string? Drawingno { get; set; }

    public string? Posno { get; set; }

    public string? Refno { get; set; }

    public string? Partunit { get; set; }

    public string? ItemRemarks { get; set; }

    public double? InvoiceQty { get; set; }

    public double? InvoicePrice { get; set; }

    public double? Discount { get; set; }

    public double? Exchrate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public byte? FinalDelivery { get; set; }

    public string? Invoiceno { get; set; }

    public string? Vesselname { get; set; }

    public double? ItemTotal { get; set; }

    public int? Expr1 { get; set; }

    public string? UnitCode { get; set; }
}
