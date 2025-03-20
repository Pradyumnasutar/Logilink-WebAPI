using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesOrder
{
    public int Orderid { get; set; }

    public string? OrderNo { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? DocumentNo { get; set; }

    public string? CustomerReference { get; set; }

    public string? Attachment { get; set; }

    public DateTime? EtaDate { get; set; }

    public decimal? OrderAmount { get; set; }

    public string? Vesselno { get; set; }

    public string? VesselName { get; set; }

    public int? Statusid { get; set; }

    public string? StatusText { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? OrderAmountText { get; set; }

    public int? CustomerId { get; set; }

    public virtual ICollection<LesShipmentDelivery> LesShipmentDeliveries { get; set; } = new List<LesShipmentDelivery>();
}
