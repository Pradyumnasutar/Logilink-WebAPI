using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportShipmentDoc
{
    public int ShipmentId { get; set; }

    public string? Docid { get; set; }

    public string? DocType { get; set; }

    public string? SenderCode { get; set; }

    public string? ReceiverCode { get; set; }

    public string? SenderName { get; set; }

    public string? ReceiverName { get; set; }

    public string? SupplierName { get; set; }

    public string? PoNo { get; set; }

    public string? ShipmentNo { get; set; }

    public string? VesselName { get; set; }

    public string? VesselImono { get; set; }

    public string? PortCode { get; set; }

    public string? PortName { get; set; }

    public double? PoTotal { get; set; }

    public double? SmTotal { get; set; }

    public string? CurrCode { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public DateTime? PoDate { get; set; }

    public DateTime? ReqDelDate { get; set; }

    public DateTime? ActDelDate { get; set; }

    public string? Location { get; set; }

    public string? HdrRemarks { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? WeightUom { get; set; }

    public string? WeightValue { get; set; }

    public string? TransportMode { get; set; }

    public int? Exported { get; set; }

    public string? MsgRef { get; set; }

    public double? QtyShipment { get; set; }

    public string? BillingNo { get; set; }
}
