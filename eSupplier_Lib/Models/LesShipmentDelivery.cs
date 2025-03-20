using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesShipmentDelivery
{
    public int Shipmentid { get; set; }

    public int? Orderid { get; set; }

    public string? OrderNo { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? DocumentNo { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? FromPort { get; set; }

    public string? ToPort { get; set; }

    public string? AwbNo { get; set; }

    public decimal? ShipmentQty { get; set; }

    public string? CoName { get; set; }

    public DateTime? EtaDate { get; set; }

    public int? DeliveredBy { get; set; }

    public string? DeliveredByText { get; set; }

    public string? StatusText { get; set; }

    public string? Statusid { get; set; }

    public string? Weight { get; set; }

    public string? Shipper { get; set; }

    public double? QtyPac { get; set; }

    public int? Ordertypeid { get; set; }

    public string? OrderType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public int? Customerid { get; set; }

    public string? Vesselno { get; set; }

    public string? VesselName { get; set; }

    public virtual LesOrder? Order { get; set; }
}
