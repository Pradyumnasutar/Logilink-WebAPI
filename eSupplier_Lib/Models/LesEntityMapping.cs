using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesEntityMapping
{
    public int Entitymappingid { get; set; }

    public string? ModuleName { get; set; }

    public string? TableName { get; set; }

    public string? ClassName { get; set; }

    public string? JsonFieldName { get; set; }

    public string? DbFieldName { get; set; }

    public string? DefaultValue { get; set; }
}
