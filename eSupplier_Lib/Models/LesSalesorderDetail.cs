using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesSalesorderDetail
{
    public int Salesorderdetailid { get; set; }

    public int? Salesorderid { get; set; }

    public int? Itemno { get; set; }

    public int? Inventoryid { get; set; }

    public string? Partname { get; set; }

    public string? Drawingno { get; set; }

    public string? Posno { get; set; }

    public string? Refno { get; set; }

    public double? VendorUnitprice { get; set; }

    public double? BuyerUnitprice { get; set; }

    public double? Stockinhand { get; set; }

    public string? Makerref { get; set; }

    public double? OrderedQty { get; set; }

    public double? Qty { get; set; }

    public double? Discount { get; set; }

    public int? Buyerunitid { get; set; }

    public int? Supplierunitid { get; set; }

    public int? ConversionFactor { get; set; }

    public int? Stockable { get; set; }

    public int? Tosplit { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public int? Quotationdetailid { get; set; }

    public int? DeliveryDays { get; set; }

    public string? ItemRemarks { get; set; }

    public double? Profitmargin { get; set; }

    public int? PckUnitid { get; set; }

    public double? PackQty { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }
}
