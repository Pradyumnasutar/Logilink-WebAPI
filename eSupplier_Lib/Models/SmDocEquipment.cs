using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmDocEquipment
{
    public int DocEquipId { get; set; }

    public int? QuotationId { get; set; }

    public string? EquipName { get; set; }

    public string? EquipDescription { get; set; }

    public string? EquipMaker { get; set; }

    public string? EquipType { get; set; }

    public string? EquipSerNo { get; set; }

    public string? EquipDrgNo { get; set; }

    public string? EquipRemarks { get; set; }
}
