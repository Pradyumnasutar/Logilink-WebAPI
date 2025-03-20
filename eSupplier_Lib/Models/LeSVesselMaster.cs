using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LeSVesselMaster
{
    public int Vesselid { get; set; }

    public string? VesselCode { get; set; }

    public string? VesselName { get; set; }

    public string? ImoNo { get; set; }

    public string? VesselEntity { get; set; }

    public string? VesselBuilt { get; set; }

    public string? VesselLength { get; set; }

    public string? GrossTonnage { get; set; }

    public string? DeadWeightTonnage { get; set; }

    public string? VesselFlag { get; set; }

    public int? VesselFlagCountry { get; set; }

    public string? VesselType { get; set; }

    public string? VesselOwner { get; set; }

    public int? VesselTag { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }
}
