using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MxmlDocItem
{
    public Guid Mxmlitemid { get; set; }

    public Guid? Mxmldocid { get; set; }

    public int? Linenumber { get; set; }

    public string? Originatingsystemref { get; set; }

    public string? Supplierpartid { get; set; }

    public string? ItemDescription { get; set; }

    public double? UnitPrice { get; set; }

    public string? ItemUnit { get; set; }

    public string? ItemComment { get; set; }

    public string? EquipmentDescription { get; set; }

    public string? EquipDrawingno { get; set; }

    public string? EquipManufacturer { get; set; }

    public string? EquipModel { get; set; }

    public string? EquipSerialno { get; set; }

    public string? EquipName { get; set; }

    public double? Quantity { get; set; }

    public double? ListPrice { get; set; }

    public double? ItemDiscount { get; set; }

    public virtual MxmlTransactionHeader? Mxmldoc { get; set; }
}
