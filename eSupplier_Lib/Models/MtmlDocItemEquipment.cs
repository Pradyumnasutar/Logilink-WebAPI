using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocItemEquipment
{
    public Guid Itemequipid { get; set; }

    public Guid? Mtmlitemid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? EquipName { get; set; }

    public string? Manufacturer { get; set; }

    public string? Serialnumber { get; set; }

    public string? Modeltype { get; set; }

    public string? Drawingnumber { get; set; }

    public string? Description { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
